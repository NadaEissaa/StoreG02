using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.overriding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }

        //override or hide
        //apply override
        //1. apply override using 'new' keyword
        //2. apply override using 'override' keyword

        public new void fun01()
        {
            Console.WriteLine("Fun01  from TypeB");
        }
        //must be not private and virtual
        public override void fun02()
        {
            Console.WriteLine($"A : {A}, B : {B}");
        }
    }
}
