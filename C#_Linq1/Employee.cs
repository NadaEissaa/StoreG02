using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Linq1
{
    internal class Employee
    {
        public String Name { get; set; }
        public int Id { get; set; }
        public decimal Salary { get; set; }


        public override string ToString()
        {
            return $"{Name} , {Id} , {Salary}";
        }



    }
}
