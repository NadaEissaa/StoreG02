using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskEFC.Entitites;

namespace TaskEFC.Context
{
    public class AppDbContext :DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student"); // Convention Mapping
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Course>().ToTable("Course");

            modelBuilder.Entity<Instructor>(entity =>
            {
                entity.ToTable("Instructor");
                entity.Property(i => i.Salary).HasColumnType("decimal(18,2)"); 

            });

            modelBuilder.Entity<Stud_Course>().HasKey(sc => new { sc.Stud_ID, sc.Course_ID });
            modelBuilder.Entity<Course_Inst>().HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
        }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI_DB;Trusted_Connection=True;");
        }
    }
}
