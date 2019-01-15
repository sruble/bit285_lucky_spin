﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LuckySpin.Controllers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace LuckySpin
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //
            //register use mvc // must go first//
            services.AddMvc();

            //register the lucky 7
            services.AddTransient<Lucky7>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, Lucky7 lucky7)
        {

            app.UseMvc(routes =>
            {
                routes.MapRoute("Default",
                    "{controller=Spinner}/{action=Index}/{luck:range(1,9)?}"
                    );
            });

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync(lucky7.Output());


            //});
         }
    }
}
