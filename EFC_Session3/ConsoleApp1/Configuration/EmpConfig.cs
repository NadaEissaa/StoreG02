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
    internal class EmpConfig : IEntityTypeConfiguration<Emp>
    {
       public void Configure(EntityTypeBuilder<Emp> builder)
        {
            builder.HasKey(E => E.Id);
            builder.Property(E => E.Id).UseIdentityColumn(10, 10);
            builder.Property(E => E.Name)
                .HasColumnName("EmployessName")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

        }
    
    }
}
