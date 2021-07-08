using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace AbaoutMiddleware.Infrastructure
{
    public class CheckforIE
    {
        // 1. It is necessary to get context from previous middleware
        private RequestDelegate requestDelegate; 

        public CheckforIE(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        // 2. What will this middleware do on the context?
        // If the request comes from IE, we want to add an information

        public async Task Invoke(HttpContext httpContext)
        {
            var item = httpContext.Request.Headers["User-Agent"].Any(value => value.ToLower().Contains("trident"));
            httpContext.Items["IE"] = item;
            
            
            // Send next middleware
            await requestDelegate.Invoke(httpContext);
        }
    }
}
