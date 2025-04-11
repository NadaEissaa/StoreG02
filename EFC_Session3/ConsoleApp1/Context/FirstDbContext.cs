using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConsoleApp1.Entities;

namespace ConsoleApp1.Context
{
    internal class FirstDbContext : DbContext
    {

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NADAAEISSAA ;Database = AppDB02; Trusted_Connection = True; TrustServerCertificate = True ");
        }

        public DbSet<Emp> Employees { get; set; }
        public DbSet<Dep> Departments { get; set; }
    }
}
