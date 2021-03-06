﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SonOfCod.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SonOfCod
{
    public class Startup
    {

        public IConfigurationRoot Configuration { get; set; }
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json");
            Configuration = builder.Build();
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddEntityFramework()
                .AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));
            services.AddIdentity<ApplicationUser, IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();
        }

        public void Configure(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.GetService<ApplicationDbContext>();
            CreateMarketingPageStuff(context);
            app.UseIdentity();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=index}/{id?}");
            });

            app.UseStaticFiles();

            app.Run(async (context1) =>
            {
                await context1.Response.WriteAsync("Hello World!");
            });
        }
        private static void CreateMarketingPageStuff(ApplicationDbContext context)
         {
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE MarketingPages");
            var testPage1 = new MarketingPage();
 
             context.MarketingPages.Add(testPage1);
 
             context.SaveChanges();
         }
    }
}
