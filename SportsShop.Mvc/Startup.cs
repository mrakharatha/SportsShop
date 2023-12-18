using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using SportsShop.Infra.Data.Context;
using SportsShop.Infra.IoC;

namespace SportsShop.Mvc
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
            services.AddMvc(options => options.EnableEndpointRouting = false);

            string connectionString = Configuration.GetConnectionString("DefaultContextConnection");

            #region SqlServer

            services.AddDbContext<SportsShopDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });


            #endregion



            #region Authentication

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = "User_Schema";
            }).AddCookie("User_Schema", options =>
            {
                options.LoginPath = "/Login";
                options.LogoutPath = "/Logout";
                options.AccessDeniedPath = "/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);

            }).AddCookie("Admin_Schema", options =>
            {
                options.LoginPath = "/Admin/Account/Login";
                options.LogoutPath = "/Admin/Account/Logout";
                options.AccessDeniedPath = "/Admin/AccessDenied";
                options.ExpireTimeSpan = TimeSpan.FromMinutes(43200);

            });
            #endregion

            #region Session

            //services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(5);
            });

            #endregion

            #region RequestBodySize
            services.Configure<FormOptions>(x =>
            {
                x.ValueLengthLimit = int.MaxValue;
                x.MultipartBodyLengthLimit = long.MaxValue;
                x.MultipartBoundaryLengthLimit = int.MaxValue;
                x.MultipartHeadersCountLimit = int.MaxValue;
                x.MultipartHeadersLengthLimit = int.MaxValue;
            });
            services.Configure<IISServerOptions>(options =>
            {
                options.MaxRequestBodySize = int.MaxValue;
            });
            services.Configure<KestrelServerOptions>(options =>
            {
                options.Limits.MaxRequestBodySize = int.MaxValue;
            });
            #endregion




            RegisterServices(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            else
                app.UseExceptionHandler("/Error");


            app.UseRouting();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();
            app.UseMvc();

            app.Use(async (context, next) =>
            {
                var principal = new ClaimsPrincipal();

                var result1 = await context.AuthenticateAsync("User_Schema");
                if (result1?.Principal != null)
                {
                    principal.AddIdentities(result1.Principal.Identities);
                }


                var result2 = await context.AuthenticateAsync("Admin_Schema");
                if (result2?.Principal != null)
                {
                    principal.AddIdentities(result2.Principal.Identities);
                }

                context.User = principal;
                await next();
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "Admin",
                    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
        public static void RegisterServices(IServiceCollection services)
        {
            DependencyContainer.RegisterServices(services);
        }
    }
}
