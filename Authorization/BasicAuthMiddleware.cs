using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;

namespace jaruernCore.Authorization
{
    public class BasicAuthMiddleware
    {
        private readonly RequestDelegate _next;

        public BasicAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(context.Request.Headers["Authorization"]);

                if (authHeader != null)
                {
                    var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                    var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':', 2);
                    var username = credentials[0];
                    var password = credentials[1];

                    // authenticate credentials with user service and attach user to http context
                    //context.Items["User"] = await userService.Authenticate(username, password);
                    context.Items["User"] = username;

                    if (credentials[0] != "" && credentials[1] != "")
                    {
                        var claims = new[] { new Claim("name", credentials[0]), new Claim(ClaimTypes.Role, "Admin") };
                        var identity = new ClaimsIdentity(claims, "Basic");
                        context.User = new ClaimsPrincipal(identity);
                        context.Response.StatusCode = 200;

                        
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    context.Response.StatusCode = 400;
                    await context.Response.WriteAsync("User authorized is needed");
                    return;
                }
            }
            catch
            {
                // do nothing if invalid auth header
                // user is not attached to context so request won't have access to secure routes

                context.Response.StatusCode = 404;
                await context.Response.WriteAsync("Authentication Something went wrong");
                return;
            }

            await _next(context);
        }
    }
}
