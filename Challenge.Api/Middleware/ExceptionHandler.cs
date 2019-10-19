using Challenge.Api.DataContracts.Out;
using Challenge.Core.Constants;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Challenge.Api.Middleware
{
    public class ExceptionHandler
    {
        private readonly RequestDelegate next;
        private readonly ILogger logger;

        public ExceptionHandler(RequestDelegate next, ILogger<ExceptionHandler> logger)
        {
            this.next = next;
            this.logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext context, Exception ex)
        {
            logger.LogError(LogEventIds.UNHANDLED_EXCEPTION, ex, ex.Message);

            var result = JsonConvert.SerializeObject(new ErrorDto { Error = ErrorMessages.SOMETHING_WENT_WRONG });
            context.Response.ContentType = "application/json";
            context.Response.StatusCode = 500;
            return context.Response.WriteAsync(result);
        }
    }
}