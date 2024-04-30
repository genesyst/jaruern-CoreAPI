using jaruernCore.localLib;
using jaruernCore.Models.dbs_jaruern;
using Microsoft.AspNetCore.Mvc;
using ServiceJaruern;
using ServiceLib;
using System.Threading;

namespace jaruernCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthenController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public AuthenController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

        }

        [HttpGet("GetCurrentUser")]
        public async Task<ActionResult> GetCurrentUser()
        {
            return Ok(new {Key = new ServiceTicket(HttpContext).GetAccessToken() });
        }

        [HttpGet("VerifyAccessToken")]
        public async Task<ActionResult> VerifyAccessToken()
        {
            string token = new ServiceTicket(HttpContext).GetAccessToken();
            try
            {
                int timeout = serviceCfg.GetTicketTimeOut();
                using (var db = new JaruernContext())
                {
                    var isToken = db.TckAccesses.Where(c => 
                                                    c.Token.ToUpper() == token.ToUpper() && 
                                                    c.Active).FirstOrDefault();
                    if(isToken!=null)
                    {
                        TimeSpan ts = DateTime.Now - isToken.CreateDate;
                        if (ts.TotalHours >= timeout)
                            return Ok(new { id = 1, msg = "time-out" });
                    }
                }
            }
            catch(Exception ex)
            {
                return Ok(new { id = 2, msg = ex.Message });
            }

            return Ok(new {id = 0,msg = token });
        }

        [HttpPost("RenewAccessToken")]
        public async Task<ActionResult> RenewAccessToken()
        {
            string token = new ServiceTicket(HttpContext).GetAccessToken();
            try
            {
                using (var db = new JaruernContext())
                {
                    var isToken = db.TckAccesses.Where(c =>
                                                    c.Token.ToUpper() == token.ToUpper() &&
                                                    c.Active).FirstOrDefault();
                    if (isToken != null)
                    {
                        string rdCode = "";

                        while (true)
                        {
                            rdCode = new ServiceSecure().CreateRandomPasswordWithSpecial(50);
                            if (!rdCode.Contains("@") && !rdCode.Contains("/") && !rdCode.Contains(@"\"))
                                break;
                        }

                        var user = db.Users.Where(c=>c.Id == isToken.Userid 
                                                    && c.Stt!="X" 
                                                    && c.Activate==true
                                                    ).FirstOrDefault();

                        if (user == null)
                        {
                            return Ok(new { id = 1, msg = "User not active/exist" });
                        }
                        else
                        {
                            string new_token = new ServiceSecure().GenerateToken(
                                                            user.Id.ToString(),
                                                            user.Id + rdCode,
                                                            user.Secretcode);

                            var db_transaction = db.Database.BeginTransaction();
                            try
                            {
                                var access_list = db.TckAccesses.Where(c => c.Active && c.Userid == user.Id).ToList();
                                foreach(var access in access_list)
                                {
                                    var acc = db.TckAccesses.Where(c => c.Id == access.Id).FirstOrDefault();
                                    if(acc!=null)
                                    {
                                        acc.UpdateDate = DateTime.Now;
                                        acc.Active = false;
                                    }
                                }

                                db.TckAccesses.Add(new TckAccess() { 
                                    Active = true,
                                    CreateDate = DateTime.Now,
                                    Id = Guid.NewGuid(),
                                    Usercode = user.Email,
                                    Userid = user.Id,
                                    Token = new_token
                                });


                                db.SaveChanges();
                                db_transaction.Commit();
                            }
                            catch
                            {
                                db_transaction.Rollback();
                                throw;
                            }

                            return Ok(new { id = 0, msg = new_token });
                        }
                    }
                    else
                        return Ok(new { id = 3, msg = "Token not active/exist" });
                }
            }
            catch (Exception ex)
            {
                return Ok(new { id = 2, msg = ex.Message });
            }
            
        }

    }
}
