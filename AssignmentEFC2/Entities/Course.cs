using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    internal class Course
    {
        public int ID { get; set; }
        public int Duration { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int? Top_ID { get; set; }
        public List<Topic> Topics { get; set; } = new List<Topic>();
        public List<Stud_Course> Stud_Courses { get; set; } = new List<Stud_Course>();
        public List<Course_Inst> Course_Instructors { get; set; } = new List<Course_Inst>();
    }
}
