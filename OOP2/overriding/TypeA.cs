using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.overriding
{
    internal class TypeA
    {
        public int A { get; set; }

        public void fun01()
        {
            Console.WriteLine("Fun01  from TypeA");
        }
        public virtual void fun02()
        {
            Console.WriteLine("A : {A}");
        }
    }
}
