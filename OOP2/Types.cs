using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
     class TypeA
    {
        public int A { get; set; }
        public void fun01() 
        {
            Console.WriteLine("Fun From TypeA");
        }
        public void fun02() {

            Console.WriteLine($"A : {A}");

        }
    }

    class TypeB : TypeA
    {
        public int B { get; set; }
        public void fun01()
        {
            Console.WriteLine("Fun From TypeB");
        }
        public void fun02()
        {

            Console.WriteLine($"B: {B}");

        }
    }

    class TypeC :TypeB
    {
        public int C { get; set; }
        public void fun01()
        {
            Console.WriteLine("Fun From TypeC");
        }
        public void fun02()
        {

            Console.WriteLine($"C: {C}"); 

        }
    }
    class TypeD : TypeC
    {
        public int D { get; set; }
        public void fun01()
        {
            Console.WriteLine("Fun From TypeD");
        }
        public void fun02()
        {

            Console.WriteLine($"D: {D}");

        }
    }

    class TypeE : TypeD
    {
        public int E{ get; set; }
        public void fun01()
        {
            Console.WriteLine("Fun From TypeE");
        }
        public void fun02()
        {

            Console.WriteLine($"E: {E}");

        }
    }


}
