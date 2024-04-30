namespace jaruernCore.localLib
{
    public class serviceCfg
    {
        public static string setting_filename = "appsettings.json";

        public serviceCfg()
        {

        }

        public static string GetImageVirtualUrl(string name)
        {
            var conF = new ConfigurationBuilder().AddJsonFile(serviceCfg.setting_filename).Build();
            var url = conF.GetValue<string>("ImageUrls:" + name);
            return url;
        }

        public static string GetConnectionString(string name)
        {
            var conF = new ConfigurationBuilder().AddJsonFile(serviceCfg.setting_filename).Build();
            var ConStr = conF.GetValue<string>("ConnectionStrings:" + name);
            return ConStr;
        }

        public static Guid GetExternalTeamId()
        {
            var conF = new ConfigurationBuilder().AddJsonFile(serviceCfg.setting_filename).Build();
            var id = conF.GetValue<string>("TeamidExternal");
            return new Guid(id);
        }

        public static Guid GetAdminId()
        {
            var conF = new ConfigurationBuilder().AddJsonFile(serviceCfg.setting_filename).Build();
            var id = conF.GetValue<string>("AdminUser");
            return new Guid(id);
        }

        public static int GetTicketTimeOut()
        {
            var conF = new ConfigurationBuilder().AddJsonFile(serviceCfg.setting_filename).Build();
            int timeout = conF.GetValue<int>("TicketConfig:Time-out");
            return timeout;
        }

    }
}
