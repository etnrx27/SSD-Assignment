using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SSD_Assignment.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
//added pages
using SendGrid;
using SendGrid.Helpers.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using SSD_Assignment.Pages.Services;



namespace SSD_Assignment
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
            services.AddRazorPages();

            services.AddDbContext<SSD_AssignmentContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("SSD_AssignmentContext")));
            services.AddIdentity<Models.ApplicationUser, Models.ApplicationRole>()
               .AddDefaultUI()
                .AddEntityFrameworkStores<SSD_AssignmentContext>()
                .AddDefaultTokenProviders();
            //google external login
            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    IConfigurationSection googleAuthNSection =
                        Configuration.GetSection("Authentication:Google");

                    options.ClientId = googleAuthNSection["ClientID"];
                    options.ClientSecret = googleAuthNSection["ClientSecret"];
                });
            //facebook external login
            services.AddAuthentication().AddFacebook(facebookOptions =>
            {
                facebookOptions.AppId = Configuration["Authentication:Facebook:AppId"];
                facebookOptions.AppSecret = Configuration["Authentication:Facebook:AppSecret"];
            });
            //Microsoft External Login is Broken
            //Microsoft external login
            services.AddAuthentication().AddMicrosoftAccount(microsoftOptions =>
            {
                microsoftOptions.ClientId = Configuration["Authentication:Microsoft:ClientId"];
                microsoftOptions.ClientSecret = Configuration["Authentication:Microsoft:ClientSecret"];
            });

            services.AddMvc()
            .AddRazorPagesOptions(options =>
            {
                //Authorize All Page Path To prevent Customers from accessing the Pages From URL
                // options.Conventions.AllowAnonymousToFolder("/Books");
                options.Conventions.AuthorizePage("/Audit/Create");
                options.Conventions.AuthorizePage("/Audit/Delete");
                options.Conventions.AuthorizePage("/Audit/Details");
                options.Conventions.AuthorizePage("/Audit/Edit");
                options.Conventions.AuthorizePage("/Audit/Index");
                options.Conventions.AuthorizePage("/Books/Cart");
                options.Conventions.AuthorizePage("/Books/Create");
                options.Conventions.AuthorizePage("/Books/Delete");
                options.Conventions.AuthorizePage("/Books/Edit");
                options.Conventions.AuthorizePage("/FeedbackList/Feedback");
                options.Conventions.AuthorizePage("/FeedbackList/FeedbackDelete");
                options.Conventions.AuthorizePage("/FeedbackList/FeedbackDetails");
                options.Conventions.AuthorizePage("/PaymentPage/Payment");
                options.Conventions.AuthorizePage("/PaymentPage/PaymentSuccess");
                options.Conventions.AuthorizePage("/Roles/Create");
                options.Conventions.AuthorizePage("/Roles/Delete");
                options.Conventions.AuthorizePage("/Roles/Details");
                options.Conventions.AuthorizePage("/Roles/Edit");
                options.Conventions.AuthorizePage("/Roles/Index");
                options.Conventions.AuthorizePage("/Roles/Manage");
                options.Conventions.AuthorizeAreaPage("Identity", "/Manage/Accounts");
            });

            //configuration to support email.
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);

            services.Configure<IdentityOptions>(options =>
            {

                // Password settings
                options.Password.RequireDigit = true;
                options.Password.RequiredLength = 5;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequireLowercase = true;
                options.Password.RequiredUniqueChars = 1;

                //enable email confirmation
                options.SignIn.RequireConfirmedEmail = true;


                // Lockout settings
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                options.Lockout.MaxFailedAccessAttempts = 10;
                options.Lockout.AllowedForNewUsers = true;

                // User settings
                options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                options.User.RequireUniqueEmail = true;



            });

            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
                // If the LoginPath isn't set, ASP.NET Core defaults
                // the path to /Account/Login
                options.LoginPath = "/Identity/Account/Login";
                // If  AccessDeniedPath isn't set, ASP.NET Core defaults 
                // the path to /Account/AccessDenied.
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;

            });

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
                app.UseStatusCodePages("text/html", "<h1>Status code page</h1> <h2>Status Code: {0}</h2>");
                app.UseExceptionHandler("/Error");
                //The default HSTS value is 30 days.You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
