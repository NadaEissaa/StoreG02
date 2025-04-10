using AssignmentEFC_2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFC_2.Congfiguration
{
    internal class DepartmentConfig : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
           
      builder.HasOne(d => d.Instructor)
      .WithOne(i => i.Department)
      .HasForeignKey<Instructor>(i => i.Dept_ID)
      .OnDelete(DeleteBehavior.Cascade); // Optional: Cascade delete
        }
    }
}
