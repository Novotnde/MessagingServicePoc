using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.MessageSender.Contracts;
using Core.MessageSender.Twilio;
using MessagingWebApplication.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace MessagingWebApplication
{
    public class Startup
    {
        
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
           
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            ConfigureDependencyInjection(ref services);
            ConfigureTwilio();
          
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("SqlConnectionString")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.

        private void ConfigureTwilio()
        {
            var twilioAccountSID = "AC4fd78b7c21f0e6523a001c0a7fde0bae";
            var twilioAuthToken = "c2c9aa3013caad1bb072edddfd55b909";

            TwilioSenderExtensions.InitTwilioClient(twilioAccountSID, twilioAuthToken);
        }
        private void ConfigureDependencyInjection(ref IServiceCollection services)
        {
            services.AddTransient<IMessageSender, TwilioMessageSender>();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
