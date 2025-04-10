using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Binding
{
    internal class PartTimeEmployee :Employee
    {



        public int Salary { get; set; }

        public double HourRate { get; set; }

        public int NumOfHours { get; set; }

        public new void fun01()
        {
            Console.WriteLine("I'm Part time employee");
        }

        public override void fun02()
        {
            Console.WriteLine($"Salary : {HourRate * NumOfHours}");
        }
    }
}
