using jaruernCore.Models.dbs_jaruern;
using jaruernCore.Models.dbs_jmmdatacenter;
using ServiceJaruern;

namespace jaruernCore.localLib
{
    public class serviceAuthen
    {
        public string token;

        public serviceAuthen(HttpContext context)
        {
            this.token = new ServiceTicket(context).GetAccessToken();
        }

        public bool GetUser(ref Guid? UserId, ref string UserName,ref Guid? TeamId,ref bool externalUser)
        {
            try
            {
                externalUser = true;
                using (var db = new JaruernContext())
                {
                    var access = db.TckAccesses.Where(c => 
                                    c.Token.ToUpper() == this.token.ToUpper() && 
                                    c.Active).FirstOrDefault();
                    if(access!=null)
                    {
                        UserId = access.Userid;

                        if(!string.IsNullOrEmpty(access.Usercode))
                        {
                            using (var jmmdb = new JmmdatacenterContext())
                            {
                                var emp = jmmdb.Employees.Where(c=>c.Stt!="X" && 
                                                    c.Empid == access.Userid).FirstOrDefault();
                                if (emp != null)
                                {
                                    if (!string.IsNullOrEmpty(emp.Teamid))
                                    {
                                        TeamId = new Guid(emp.Teamid.Split(';')[0]);
                                        externalUser = false;
                                        UserName = emp.Firstname + " " + emp.Lastname;
                                    }
                                }
                                else
                                {
                                    TeamId = serviceCfg.GetExternalTeamId();

                                    var user = db.Users.Where(c=>c.Id == access.Userid).FirstOrDefault();
                                    if(user != null) {
                                        UserName = user.Email;
                                    }
                                }
                            }
                        }

                        return true;
                    }
                    else
                        return false;
                }
            }
            catch(Exception ex)
            {
                throw;
            }
        }
    }
}
