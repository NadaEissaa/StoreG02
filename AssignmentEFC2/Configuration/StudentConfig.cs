using Assignment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Configuration
{
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students");
            builder.HasKey(s => s.ID);
            builder.Property(s => s.FName).HasMaxLength(50).IsRequired();
            builder.Property(s => s.LName).HasMaxLength(50).IsRequired();
            builder.Property(s => s.Address).HasMaxLength(100);
        }
    }
}
