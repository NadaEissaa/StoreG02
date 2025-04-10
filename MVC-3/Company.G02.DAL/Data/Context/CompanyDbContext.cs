using Company.G02.DAL.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Company.G02.DAL.Data.Context
{
    public class CompanyDbContext : IdentityDbContext<AppUser>
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options):base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Seed Roles
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = "42985960-DEC0-4611-A26F-FEE23079388E",
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole()
            {
                Id = "5F701205-7E32-42EF-B43E-AD0B42B31FC8",
                Name = "User",
                NormalizedName = "USER"
            });

            PasswordHasher<AppUser> passwordHasher = new PasswordHasher<AppUser>();

            // Seed a User
            modelBuilder.Entity<AppUser>().HasData(new AppUser()
            {
                Id = "1225AE25-67AD-4AE0-8EBF-1DC351BC6242",
                FirstName = "Nada",
                LastName = "Eissa",
                Email = "nadaeissa13@gmail.com",
                PasswordHash = passwordHasher.HashPassword(null, "nada0307#")
            });

            // Map the user to the Admin role
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>()
            {
                RoleId = "42985960-DEC0-4611-A26F-FEE23079388E",  // Admin role
                UserId = "1225AE25-67AD-4AE0-8EBF-1DC351BC6242"   // User
            });

            base.OnModelCreating(modelBuilder);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=.; Database=CompanyG02; Trusted_connection=True; TrustServerCertificate=True");
        //}
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        

    }
}
