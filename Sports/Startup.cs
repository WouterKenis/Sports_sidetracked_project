using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Sports.Services;

namespace Sports
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddScoped<ISportsData, InMemorySportsData>();
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseMvc(ConfigureRoutes);

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Not Found.");
            });
        }

        private void ConfigureRoutes(IRouteBuilder routeBuilder)
        {

            routeBuilder.MapRoute("Default",
                                   "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
