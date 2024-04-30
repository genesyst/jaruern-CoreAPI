using Genesyst.Models;
using jaruernCore.localLib;
using jaruernCore.Models;
using jaruernCore.Models.dbs_jaruern;
using jaruernCore.Models.dbs_jmmdatacenter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using ServiceJaruern;
using ServiceLib;

namespace jaruernCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRegisterController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public UserRegisterController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;

        }

        [HttpPost("NewRegister")]
        public async Task<ActionResult> NewRegister(mdlNewRegister Values)
        {
            mdlGValue res = new mdlGValue();
            using (var db = new JaruernContext())
            {
                bool user_dupp = false;
                var isVerifyEmail = db.Users.Where(c=>c.Email.ToUpper()==Values.Email.ToUpper()).FirstOrDefault();
                if(isVerifyEmail!=null)
                    user_dupp=true;
                
                if(!user_dupp)
                {
                    var jrn_transaction = db.Database.BeginTransaction();
                    try
                    {
                        Guid UserId = Guid.NewGuid();
                        Guid TeamId = serviceCfg.GetExternalTeamId();

                        #region verify empcode with jmmdatacenter
                        if (!string.IsNullOrEmpty(Values.EmpCode)) 
                        {
                            using (var jmmdb = new JmmdatacenterContext())
                            {
                                var isEmp = jmmdb.Employees.Where(c =>
                                                            c.Empcode.ToUpper() == Values.EmpCode.ToUpper() &&
                                                            c.Stt != "X"
                                                            ).FirstOrDefault();
                                if (isEmp != null)
                                {
                                    UserId = isEmp.Empid;
                                    TeamId = new Guid(isEmp.Teamid.Split(';')[0]);
                                }
                                else
                                {
                                    res.Key = 2;
                                    res.Value = "Empcode is in valid user";
                                    return Ok(res);
                                }
                            }
                        }
                        #endregion

                        int hasSecret = Values.Email.GetHashCode();

                        TimeSpan y2kday = DateTime.Now - new DateTime(2000, 1, 1);
                        int timeSecret = (int)y2kday.TotalDays;

                        string secretCode = hasSecret.ToString().Replace("-","")+ timeSecret.ToString();
                        string encPassword = new ServiceSecure().EncryptData(Values.Password, secretCode);

                        db.Users.Add(new User()
                        {
                            Activate = false,
                            Email = Values.Email,
                            CreateBy = UserId,
                            CreateDate = DateTime.Now,
                            Empcode = Values.EmpCode,
                            Id = UserId,
                            Stt = "A",
                            UpdateBy = null,
                            UpdateDate = null,
                            Password = encPassword,
                            Secretcode = secretCode,
                        });

                        db.SaveChanges();
                        #region store adding
                        using (var jmmdb = new JmmdatacenterContext())
                        {
                            Guid StoreId = new Guid(Values.StoreId);
                            var isStore = jmmdb.Stores.Where(c => c.Id == StoreId && c.Stt != "X").FirstOrDefault();
                            if (isStore == null)
                            {
                                res.Key = 3;
                                res.Value = "Store is not exist";
                                return Ok(res);
                            }
                            else
                            {
                                var isDuppStore = jmmdb.Storestaffs.Where(c =>
                                                                    c.Staffid == UserId &&
                                                                    c.Storeid == isStore.Id &&
                                                                    c.Stt != "X")
                                                                    .FirstOrDefault();
                                if (isDuppStore == null)
                                {
                                    var jmmdb_transaction = jmmdb.Database.BeginTransaction();
                                    try
                                    {
                                        jmmdb.Storestaffs.Add(new Storestaff()
                                        {
                                            CreateBy = UserId,
                                            CreateDate = DateTime.Now,
                                            Id = Guid.NewGuid(),
                                            Staffid = UserId,
                                            Stt = "A",
                                            Storeid = isStore.Id,
                                            Teamid = TeamId.ToString() + ";",
                                            UpdateBy = null,
                                            UpdateDate = null
                                        });

                                        jmmdb.SaveChanges();
                                        jmmdb_transaction.Commit();
                                    }
                                    catch (Exception ex)
                                    {
                                        jmmdb_transaction.Rollback();
                                        jrn_transaction.Rollback();

                                        res.Key = 1;
                                        res.Value = "Store Staff adding " + ex.Message;

                                        return Ok(res);
                                    }
                                }
                            }
                        }

                        #endregion

                        jrn_transaction.Commit();

                        res.Key = 0;
                        res.Value = "Success";
                    }
                    catch(Exception ex)
                    {
                        jrn_transaction.Rollback();

                        res.Key = 1;
                        res.Value = ex.Message;
                    }
                }
                else
                {
                    res.Key = -1;
                    res.Value = "Email or Empcode Duplicate";
                }
            }


            return Ok(res);
        }

    }
}
