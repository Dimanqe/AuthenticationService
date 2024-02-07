using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace AuthenticationService
{
    public class LogMiddleware
    {

        private readonly RequestDelegate _next;
        private readonly ILogger _logger;
        public LogMiddleware(RequestDelegate next, ILogger logger)
        {
            _next = next;

            _logger = logger;

        }


        public async Task Invoke(HttpContext context)
        {
            var clientIP = context.Connection.LocalIpAddress.MapToIPv6();
            _logger.WriteEvent(clientIP.ToString());
            await _next(context);
        }
    }
}
