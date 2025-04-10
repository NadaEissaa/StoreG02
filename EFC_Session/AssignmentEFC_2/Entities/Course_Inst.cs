using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFC_2.Entities
{
    internal class Course_Inst
    {
        public int Inst_ID { get; set; }
        public Instructor? Instructor { get; set; }
        public int Course_ID { get; set; }
        public Course? Course { get; set; }
        public string? Evaluate { get; set; }
    }
}
