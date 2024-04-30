using jaruernCore.localLib;
using ServiceJaruern;
using System.Security.Claims;
using static System.Net.Mime.MediaTypeNames;

namespace jaruernCore.Middleware
{
    public class ApiAccessVerify
    {
        private readonly RequestDelegate _next;
        private const string ACCRESS_KEY = "access";

        public ApiAccessVerify(RequestDelegate next) {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            int timeout = serviceCfg.GetTicketTimeOut();
            ServiceTicket serviceTicket = new ServiceTicket(context);
            try
            {
                if (!context.Request.Headers.TryGetValue(ACCRESS_KEY, out var input_acckey))
                {
                    context.Response.StatusCode = 401;
                    await context.Response.WriteAsync("Access key was not provided ");
                    return;
                }

                var appSettings = context.RequestServices.GetRequiredService<IConfiguration>();
                var register_key = appSettings.GetValue<string>("register_key");
                if (register_key.Equals(input_acckey)) //is register process
                {
                    serviceTicket.assignClaimBasicValue("regis", input_acckey);
                }
                else
                {
                    string connectionString = serviceCfg.GetConnectionString("JRConnection");
                    int valid = serviceTicket.VerifyAccessKey(input_acckey, connectionString,timeout);
                    if (valid == 0)
                    {
                        serviceTicket.assignClaimBasicValue("access", input_acckey);
                    }
                    else if (valid == 1)
                    {
                        context.Response.StatusCode = 410;
                        await context.Response.WriteAsync("access time_out");
                        return;
                    }
                    else
                    {
                        context.Response.StatusCode = 401;
                        await context.Response.WriteAsync("Unauthorized client");
                        return;
                    }
                }
            }
            finally
            {
                serviceTicket = null;
            }

            await _next(context);
        }

        
    }
}
