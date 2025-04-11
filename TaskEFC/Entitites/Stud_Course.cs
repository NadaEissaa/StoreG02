using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEFC.Entitites
{
    public class Stud_Course
    {
        [Key]
        public int Stud_ID { get; set; }
        [Key]
        public int Course_ID { get; set; }
        public decimal Grade { get; set; }
    }
}
