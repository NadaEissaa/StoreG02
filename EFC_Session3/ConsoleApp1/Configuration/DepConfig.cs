using ConsoleApp1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Configuration
{
    internal class DepConfig : IEntityTypeConfiguration<Dep>
    {
       
             public void Configure(EntityTypeBuilder<Dep> builder)
        {
            builder.HasKey(D => D.Id);
            builder.Property(D => D.Id).UseIdentityColumn(100, 100);
            builder.Property(D => D.DeptName).HasColumnName("DepartmentName")
                .HasColumnType("varchar")
                .HasMaxLength(100);
        }
    }
    
}
