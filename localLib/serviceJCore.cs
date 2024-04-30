

using jaruernCore.Models.dbs_jaruern;
using jaruernCore.Models.dbs_jaruern_inv;
using jaruernCore.Models.dbs_jmmdatacenter;

namespace jaruernCore.localLib
{
    public class serviceJCore
    {
        public string UserName(Guid UserId)
        {
            string res = "";
            try
            {
                using (var jdb = new JaruernContext())
                {
                    var user = jdb.Users.Where(c=>c.Id == UserId).FirstOrDefault();
                    if(user!=null)
                    {
                        if(!string.IsNullOrEmpty(user.Empcode))
                        {
                            using (var jmmdb = new JmmdatacenterContext())
                            {
                                var emp = jmmdb.Employees.Where(c=>c.Empid == user.Id && c.Stt!="X").FirstOrDefault();
                                if(emp!=null)
                                    res = emp.Firstname + " " + emp.Lastname;
                                else
                                    res = user.Email;
                            }
                        }
                        else
                        {
                            res = user.Email;
                        }
                    }
                }
            }
            catch (Exception ex) { }

            return res;
        }

        public int GetRunning(Guid StoreId,String typename,string keycode)
        {
            int newno = 0;
            using (var jivdb = new JaruernInvContext())
            {
                var runn = jivdb.Runnings.Where(c=>
                                                c.Storeid == StoreId && 
                                                c.Typename.ToUpper()==typename.ToUpper() &&
                                                c.Keycode.ToUpper() == keycode.ToUpper() 
                                                ).FirstOrDefault();

                var jrn_transaction = jivdb.Database.BeginTransaction();
                try
                {
                    if (runn == null)
                    {
                        newno = 1;

                        jivdb.Runnings.Add(new Running()
                        {
                            Value = newno,
                            Id = Guid.NewGuid(),
                            Storeid = StoreId,
                            Typename = typename,
                            Lastupdate = DateTime.Now,
                            Keycode = keycode,
                        });

                        jivdb.SaveChanges();
                    }
                    else
                    {
                        newno = runn.Value + 1;

                        runn.Value = newno;
                        runn.Lastupdate = DateTime.Now;
                        jivdb.SaveChanges();
                    }

                    jrn_transaction.Commit();
                }
                catch
                {
                    jrn_transaction.Rollback();
                }
            }

            return newno;
        }
    }
}
