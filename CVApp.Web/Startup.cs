using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using CVApp.Bussiness.IOC;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CVApp.Web
{
    public class Startup
    {


        private IConfiguration Configuration { get; set; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {

            //addTransiet ve addScoped?
            //Area Attribute?
            //middleware?

            //Bussiness layer'da, IOC klas�r�n�n i�inde geni�letti�imiz
            //services IService interface'i buradaki services parametresi.
            services.AddDependencies(Configuration);

            services.AddAutoMapper(typeof(Startup));
            //Bussiness katman� i�inde yazm�� oldu�umuz validasyon kurallar�n�n �al��mas� i�in gerekli
            services.AddControllersWithViews().AddFluentValidation();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(opt =>
            {
                opt.Cookie.HttpOnly = true;
                opt.Cookie.SameSite = SameSiteMode.Strict;
                opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
                opt.ExpireTimeSpan = TimeSpan.FromDays(10);
                opt.Cookie.Name = "cozv";
                opt.LoginPath = new PathString("/Admin/Auth/Login");
            });

            // Kay�t i�lemimizi ger�ekle�tiriyoruz, AddMvc() den �nce ekledi�inizden emin olunuz.
            services.AddLocalization(options =>
            {
                // Resource (kaynak) dosyalar�m�z� ana dizin alt�nda �Resources� klasor� i�erisinde tutaca��m�z� belirtiyoruz.
                options.ResourcesPath = "Resources";
            });

            services.AddMvc(option => option.EnableEndpointRouting = false)
                .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Bu b�l�m UseMvc()� den �nce eklenecektir.
            // Uygulamam�z i�erisinde destek vermemizi istedi�imiz dilleri tutan bir liste olu�turuyoruz.
            var supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("tr-TR"),
                new CultureInfo("en-US"),
            };
            // SupportedCultures ve SupportedUICultures�a yukar�da olu�turdu�umuz dil listesini tan�ml�yoruz.
            // DefaultRequestCulture�a varsay�lan olarak uygulamam�z�n hangi dil ile �al��mas� gerekti�ini tan�ml�yoruz.
            app.UseRequestLocalization(new RequestLocalizationOptions
            {
                SupportedCultures = supportedCultures,
                SupportedUICultures = supportedCultures,
                DefaultRequestCulture = new RequestCulture("tr-TR"),
                RequestCultureProviders = new List<IRequestCultureProvider>
                {
                    new QueryStringRequestCultureProvider()
                }
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            //wwwroot i�indeki dosyalar� d��ar�ya a�ar
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "areas", pattern: "{area}/{controller=Home}/{action=Index}/{id?}");
                //default ba�lang�� sayfas�n� belirledik
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });



            //app.UseMvc();
        }
    }
}
