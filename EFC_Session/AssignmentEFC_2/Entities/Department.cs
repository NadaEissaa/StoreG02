using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEFC_2.Entities
{
    internal class Department
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public int Ins_ID { get; set; }
        public DateTime HiringDate { get; set; }
        public Instructor Instructor { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
