using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Binding
{

    //Conatiner
    internal class Employee
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public String Email { get; set; }

        public String Address { get; set; }


        public void fun01()
        {
            Console.WriteLine("I'm  employee");
        }

        public virtual void fun02()
        {
            Console.WriteLine($"Salary : ??");
        }
    }
}
