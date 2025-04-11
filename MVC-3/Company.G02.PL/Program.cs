using Company.G02.BLL;
using Company.G02.BLL.Interfaces;
using Company.G02.BLL.Repositories;
using Company.G02.DAL.Data.Context;
using Company.G02.DAL.Models;
using Company.G02.PL.Helpers;
using Company.G02.PL.Mapping;
using Company.G02.PL.Services;
using Company.G02.PL.Services.Settings;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Company.G02.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // Register built-in MVC services

            // Configure database context
            builder.Services.AddDbContext<CompanyDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });

            // Configure Identity for authentication
            builder.Services.AddIdentity<AppUser, IdentityRole>()
                            .AddEntityFrameworkStores<CompanyDbContext>()
                            .AddDefaultTokenProviders();

            // Configure cookie-based authentication for local login
            builder.Services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
            })
            .AddCookie(options =>
            {
                options.LoginPath = "/Account/SignIn"; // Redirect to the SignIn page if unauthenticated
            })
            .AddGoogle(options =>
            {
                options.ClientId = builder.Configuration["Authentication:Google:ClientId"];
                options.ClientSecret = builder.Configuration["Authentication:Google:ClientSecret"];
            });

            // Configure AutoMapper
            builder.Services.AddAutoMapper(M => M.AddProfile(new EmployeeProfile()));
            builder.Services.AddAutoMapper(M => M.AddProfile(new DepartmentProfile()));

            // Configure other services
            builder.Services.Configure<MailSettingsWorkshop>(builder.Configuration.GetSection(nameof(MailSettingsWorkshop)));
            builder.Services.AddTransient<ISMSService, SMSService>();
            builder.Services.AddTransient<IMailSettingsWorkshop, EmailSettingsWorkshop>();

            // Register UnitOfWork and repositories
            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>(); // Register IUnitOfWork and its implementation
            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>(); // Register repository for department

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
           name: "default",
           pattern: "{controller=Account}/{action=SignUp}/{id?}");


            app.Run();
        }
    }
}
