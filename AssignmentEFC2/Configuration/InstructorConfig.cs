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
    internal class InstructorConfig : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {

            builder.ToTable("Instructors");
            builder.HasKey(i => i.ID);
            builder.Property(i => i.Name).HasMaxLength(100).IsRequired();
            builder.Property(i => i.Address).HasMaxLength(100); throw new NotImplementedException();
        }
    }
}
