using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkOrderCore.Infrastructure.Persistence.DataContext;
using WorkOrderCore.Middlewares;
using WorkOrderCore.Services;

namespace WorkOrderApplication
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
            services.AddDistributedMemoryCache();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromSeconds(900);
                //options.Cookie.HttpOnly = true;
                //options.Cookie.IsEssential = true;
            });

            services.AddHttpContextAccessor();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => false;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddDbContext<WorkOrderDBContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("UsingIdentityContextConnection"),
                          sqlServerOptionsAction: sqlOptions =>
                          {
                              sqlOptions.EnableRetryOnFailure();
                          });
            });
            services.AddTransient<IJobCardService, JobCardService>();
            services.AddTransient<ILookupService, LookupService>();
            services.AddTransient<IActivityService, ActivityService>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<ITransactionService, TransactionService>();
            services.AddTransient<IAttachmentsService, AttachmentsService>();

            
            services.AddSignalR();
            services.AddCors(options => {
                options.AddPolicy("mypolicy", builder => builder
                 .AllowAnyOrigin()
                 .SetIsOriginAllowed((host) => true)
                 .AllowAnyMethod()
                 .AllowAnyHeader());
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseCustomExceptionHandler();
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseAuthentication(); 
            app.UseRouting(); 
            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Account}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
                endpoints.MapHub<SignalServer>("/signalServer");

            });
        }
    }
}
