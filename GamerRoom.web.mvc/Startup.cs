using GamerRoom.web.mvc.Handlers;
using GamerRoom.web.mvc.Service.Interfaces;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GamerRoom.web.mvc
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

            #region Refit

            HttpClientHandler clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };

            services.AddTransient<BearerTokenMessageHandler>();

            services
                .AddRefitClient<IGameService>()
                .AddHttpMessageHandler<BearerTokenMessageHandler>()
                .ConfigureHttpClient(c =>
                {
                    c.BaseAddress = new Uri(Configuration.GetValue<string>("UrlApiGamesRoom"));
                }).ConfigurePrimaryHttpMessageHandler(c => clientHandler);

            services
               .AddRefitClient<IAuthService>()
               .AddHttpMessageHandler<BearerTokenMessageHandler>()
               .ConfigureHttpClient(c =>
               {
                   c.BaseAddress = new Uri(Configuration.GetValue<string>("UrlApiGamesRoom"));
               }).ConfigurePrimaryHttpMessageHandler(c => clientHandler);

            #endregion

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            services.AddHttpContextAccessor();
            services.AddRazorPages().AddRazorRuntimeCompilation();
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseAuthentication();
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
