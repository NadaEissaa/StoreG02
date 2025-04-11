//using EFC_Session1.Entites;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace EFC_Session1.Contexts
//{
//    internal class AppdbContext : DbContext
//    {
//        public AppdbContext() :base()
//        {
             
//        }
//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            optionsBuilder.UseSqlServer("Server = .; Database = EFC1 ; Trusted_Connection = True ");

//        }
//        public DbSet<Employee> Employees { get; set; }

//        public DbSet<Department> Departments { get; set; }
//    }
//}

