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

            //Bussiness layer'da, IOC klasörünün içinde geniþlettiðimiz
            //services IService interface'i buradaki services parametresi.
            services.AddDependencies(Configuration);

            services.AddAutoMapper(typeof(Startup));
            //Bussiness katmaný içinde yazmýþ olduðumuz validasyon kurallarýnýn çalýþmasý için gerekli
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

            // Kayýt iþlemimizi gerçekleþtiriyoruz, AddMvc() den önce eklediðinizden emin olunuz.
            services.AddLocalization(options =>
            {
                // Resource (kaynak) dosyalarýmýzý ana dizin altýnda “Resources” klasorü içerisinde tutacaðýmýzý belirtiyoruz.
                options.ResourcesPath = "Resources";
            });

            services.AddMvc(option => option.EnableEndpointRouting = false)
                .AddViewLocalization(Microsoft.AspNetCore.Mvc.Razor.LanguageViewLocationExpanderFormat.Suffix)
                .AddDataAnnotationsLocalization();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // Bu bölüm UseMvc()’ den önce eklenecektir.
            // Uygulamamýz içerisinde destek vermemizi istediðimiz dilleri tutan bir liste oluþturuyoruz.
            var supportedCultures = new List<CultureInfo>
            {
                new CultureInfo("tr-TR"),
                new CultureInfo("en-US"),
            };
            // SupportedCultures ve SupportedUICultures’a yukarýda oluþturduðumuz dil listesini tanýmlýyoruz.
            // DefaultRequestCulture’a varsayýlan olarak uygulamamýzýn hangi dil ile çalýþmasý gerektiðini tanýmlýyoruz.
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

            //wwwroot içindeki dosyalarý dýþarýya açar
            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "areas", pattern: "{area}/{controller=Home}/{action=Index}/{id?}");
                //default baþlangýç sayfasýný belirledik
                endpoints.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });



            //app.UseMvc();
        }
    }
}
