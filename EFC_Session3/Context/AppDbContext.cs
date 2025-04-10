using EFC_Session3.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Session3.Context
{
    internal class AppDbContext :DbContext 
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = NADAAEISSAA ;Database = EFC3; Trusted_Connection = True; TrustServerCertificate = True  ");
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEployeesm { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployee { get; set; }

    }
}
