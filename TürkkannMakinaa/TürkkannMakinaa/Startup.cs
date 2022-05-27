using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using TürkkannMakinaa.Entities;
using TürkkannMakinaa.Services;
using TürkkannMakinaa.Services.Email;
using TürkkannMakinaa.Services.Upload;
using TürkkannMakinaa.Validators;

namespace TürkkannMakinaa
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }



        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<ProductCreateValidator>();

            services.AddDbContext<ApplicationDbContext>(optionsAction =>
            {
                optionsAction.UseSqlServer(Configuration.GetConnectionString("ApplicationConnection"));
            });
            services.AddIdentity<ApplicationUser, ApplicationRole>(
               opt =>
               {
                   opt.User.RequireUniqueEmail = true;
                   opt.Password.RequiredLength = 8;
                   opt.Password.RequireLowercase = true;
                   opt.Password.RequireDigit = true;
                   opt.Password.RequireUppercase = true;
                   opt.SignIn.RequireConfirmedEmail = true;
                   opt.Password.RequireNonAlphanumeric = false;
               }

               ).AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/Auth/Login";
                options.SlidingExpiration = true;
            });

            services.AddTransient<IEmailSender, NetSmtpEmail>();
            services.AddTransient<IFileUploader, FileSystemFileUploader>();
            services.AddMvc().AddRazorPagesOptions(opt => { opt.AllowAreas = true; }).AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<Startup>());
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseStaticFiles();

            app.UseStaticFiles(new StaticFileOptions()
            {
                FileProvider = new PhysicalFileProvider(
                           Path.Combine(Directory.GetCurrentDirectory(), @"Images")),
                RequestPath = new PathString("/site/images")
            });

            //app.UseMvc();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
         name: "area",
         template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                   name: "default",
                   template: "{controller=Home}/{action=Index}/{id?}");
            });


            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("Hello World!");
            //});
        }
    }
}
