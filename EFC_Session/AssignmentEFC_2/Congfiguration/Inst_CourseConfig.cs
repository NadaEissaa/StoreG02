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
    internal class Inst_CourseConfig : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {

            builder.HasKey(ci => new { ci.Inst_ID, ci.Course_ID });
        }
    }
}
