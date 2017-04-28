using System;
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
            app.UseIdentity();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Account}/{action=index}/{id?}");
            });

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
        private static void AddTestData(ApplicationDbContext context)
         {
            var testPage1 = new Models.MarketingPage { };
            
                testPage1.BannerImageUrl = "https://hginthesea.files.wordpress.com/2011/11/img_0291.jpg";
            testPage1.BannerTitle = "May Cod Be With You.";
            testPage1.NewsImageUrl = "http://northwestseafood.com/wp-content/uploads/2015/12/dreamstime_xl_38406132-1030x687.jpg";
                testPage1.NewsSummary = "Warty angler large-eye bream gar graveldiver four-eyed fish buri, yellowmargin triggerfish glass catfish northern lampfish discus graveldiver; sábalo. Hake butterfly ray giant wels scorpionfish: pompano dolphinfish combtail gourami saury roughy rough sculpin, Japanese eel, sucker. Herring smelt pompano dolphinfish clown triggerfish crappie, powen rocket danio: bandfish. Alooh pompano marblefish, grunion yellowfin tuna, snipe eel mojarra. White croaker bull trout, bamboo shark collared dogfish marine hatchetfish searobin Oregon chub. Prickly shark Billfish flier dwarf gourami elver Asiatic glassfish whale shark. Wrasse lanternfish; snipe eel, gray eel-catfish barred danio yellow jack. Oldwife, rough scad redside pink salmon scissor-tail rasbora European minnow, bleak blue catfish.";
            testPage1.NewsTitle = "News & Stuff";
            testPage1.ProductsTitle = "Our Products";
            testPage1.SummaryImageUrl = "https://www.pacseafood.com/images/librariesprovider3/default-album/product-line.jpg?sfvrsn=0";
            testPage1.SummaryText = "Dusky grouper, tommy ruff pineconefish croaker, Atlantic eel Redfin perch hillstream loach mudsucker ilisha, wolffish, central mudminnow. Mahi-mahi, eel cod jewel tetra: shark fire bar danio greenling sand goby scabbard fish chain pickerel bent-tooth smoothtongue bull shark? Priapumfish mahi-mahi snake eel New Zealand sand diver. Darter bichir gianttail gar ghost pipefish. Denticle herring velvetfish needlefish electric eel--parrotfish velvet catfish smelt-whiting. Yellowtail snapper three spot gourami, whiptail gulper. Longnose dace candiru grideye deep sea bonefish lancetfish sand tiger.";
            testPage1.SummaryTitle = "Cod Bless";
 
             context.MarketingPages.Add(testPage1);
 
             context.SaveChanges();
         }
    }
}
