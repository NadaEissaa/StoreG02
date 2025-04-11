using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEFC.Entitites
{
    public class Course_Inst
    {
        [Key]
        public int Inst_ID { get; set; }
        [Key]
        public int Course_ID { get; set; }
        public string Evaluate { get; set; } = string.Empty;
    }

}
