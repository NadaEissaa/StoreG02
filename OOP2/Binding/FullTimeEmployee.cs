using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Binding
{
    internal class FullTimeEmployee :Employee
    {


        public int Salary { get; set; }

        public new void fun01()
        {
            Console.WriteLine("I'm full time employee");
        }

        public virtual void fun02()
        {
            Console.WriteLine($"Salary : {Salary}");
        }
    }
}
