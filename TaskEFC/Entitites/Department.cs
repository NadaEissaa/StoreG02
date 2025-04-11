using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskEFC.Entitites
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Ins_ID { get; set; } // Foreign Key (Not enforced)
        public DateTime HiringDate { get; set; }
    }
}
