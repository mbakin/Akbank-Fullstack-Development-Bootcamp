using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AbaoutMiddleware.Infrastructure;
using Microsoft.AspNetCore.Http;

namespace AbaoutMiddleware
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // The parts that run the operations to be done on the http request are called middleware, and their working order is called the pipeline.
            /*
             * Request Editing
             * Response Editing
             * Content Editing
             */

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            // Run : Don't run other middleware just 'Run'/
            //app.Run(async (context) =>
            //{
            //    context.Response.ContentType = "text/plain";
            //    await context.Response.WriteAsync("Response successful");
            //});
            // Run middleware only when (/test) goes to the specified address.
            app.Map("/test", builder =>
            {
                builder.Run(async (context) =>
                {
                    if (context.Request.Query.ContainsKey("id"))
                    {
                        await context.Response.WriteAsync("Test result : " + context.Request.Query["id"]);
                    }
                    else
                    {
                        await context.Response.WriteAsync("Failed. Please try again.");
                    }
                });
            });

            app.UseMiddleware<CheckforIE>();
            //app.UseWelcomePage();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
