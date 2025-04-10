using AssignmentEFC_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFC_2.Congfiguration
{
    internal class InstructorsConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {

            builder.ToTable("Instructors");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.Name).HasMaxLength(100).IsRequired();
            builder.Property(i => i.Address).HasMaxLength(100);
            builder.Property(i => i.Salary).HasPrecision(18, 2);
            builder.Property(i => i.HourRateBonus).HasPrecision(18, 2);
        }
    }
}
