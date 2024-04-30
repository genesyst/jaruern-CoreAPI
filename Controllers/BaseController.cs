using jaruernCore.localLib;
using jaruernCore.Models.dbs_jaruern;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace jaruernCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        protected Guid? UserId { get; set; }
        protected Guid? TeamId { get; set; }
        protected bool isExternalUser { get; set; }
        protected string UserName { get; set; }

        protected bool GetUser()
        {
            Guid? userid = null;
            Guid? teamid = null;
            bool externalUser = true;
            string username = "";
            if (new serviceAuthen(HttpContext).GetUser(ref userid, ref username, ref teamid,ref externalUser))
            {
                this.UserId = userid;
                this.TeamId = teamid;
                this.isExternalUser = externalUser;
                this.UserName = username;

                return true;
            }

            return false;
        }
    }
}
