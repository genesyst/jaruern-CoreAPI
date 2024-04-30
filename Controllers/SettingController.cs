using Genesyst.Models;
using jaruernCore.Models;
using jaruernCore.Models.dbs_jaruern_inv;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace jaruernCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingController : BaseController
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public SettingController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost("SetValues")]
        public async Task<ActionResult> SetValues(mdlSettingValue Values)
        {
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var jrn_transaction_upd = jivdb.Database.BeginTransaction();
                    try
                    {
                        String spText = "EXECUTE spSettResetOldVal @p0 ";
                        jivdb.Database.ExecuteSqlRaw(spText, Values.StoreId);
                        jrn_transaction_upd.Commit();
                    }
                    catch
                    {
                        jrn_transaction_upd.Rollback();
                        throw;
                    }

                    var jrn_transaction = jivdb.Database.BeginTransaction();
                    try
                    {
                        foreach(var val in Values.settValues)
                        {
                            #region check value type
                            decimal? decVal = null;
                            int? intVal = null;
                            string strVal = null;

                            switch(val.dType.ToLower())
                            {
                                case "dou":decVal = Convert.ToDecimal(val.Value); break;
                                case "int": intVal = Convert.ToInt32(val.Value); break;
                                default:
                                    strVal = val.Value; break;
                            }

                            #endregion

                            jivdb.Setts.Add(new Sett()
                            {
                                Active = true,
                                CreateDate = DateTime.Now,
                                CreateBy = this.UserId.Value,
                                Id = Guid.NewGuid(),
                                Stt = "A",
                                Storeid = Values.StoreId,
                                Setkey = val.Key.ToString().ToUpper(),
                                SetvalStr = strVal,
                                SetvalInt = intVal,
                                SetvalDou = decVal,
                            });
                        }

                        jivdb.SaveChanges();
                        jrn_transaction.Commit();
                    }
                    catch
                    {
                        jrn_transaction.Rollback();
                        throw;
                    }


                    return Ok(new { id = 0, msg = "SUCCESS" });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("GetValues")]
        public async Task<ActionResult> GetValues(Guid StoreId)
        {
            try
            {
                this.GetUser();
                using (var jivdb = new JaruernInvContext())
                {
                    var setts = jivdb.Setts.Where(c=>
                                                c.Storeid == StoreId && c.Stt!="X").OrderBy(o=>o.Setkey).ToList();

                    return Ok(new { id = 0, msg = "SUCCESS" , data = setts });
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
