using System;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.IdentityModel.Xml;
using Newtonsoft.Json;

namespace HiCar.Api.Utils
{
    public sealed class ExceptionHandler
    {
        private readonly RequestDelegate _next;

        public ExceptionHandler(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext ctx)
        {
            try
            {
                await _next(ctx);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(ctx, ex);
            }
        }

        private Task HandleExceptionAsync(HttpContext ctx, Exception ex)
        {
            // return an envelope with the error 
            string result = JsonConvert.SerializeObject(Envelope.Error(ex.Message));
            ctx.Response.ContentType = "application/json";
            ctx.Response.StatusCode = (int) HttpStatusCode.InternalServerError;
            return ctx.Response.WriteAsync(result);

        }
    }
}
