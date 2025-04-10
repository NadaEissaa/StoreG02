using EFC_Session.Configuration;
using EFC_Session.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Session.Contexts
{
    internal class AppDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>().Property(E => E.Id).UseIdentityColumn(10, 10);
            //modelBuilder.Entity<Employee>().Property(E => E.Name)
            //    .HasColumnName("EmployessName")
            //    .HasColumnType("varchar")
            //    .HasMaxLength(50)
            //    .IsRequired();
            //modelBuilder.Entity<Department>().HasKey(D => D.Id
            //
            //modelBuilder.ApplyConfiguration(new EmployeeConfig());
            //modelBuilder.ApplyConfiguration(new DepartmentConfig());
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NADAAEISSAA ;Database = AppDB02; Trusted_Connection = True; TrustServerCertificate = True ");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }


    }
}
