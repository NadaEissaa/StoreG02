using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Inheritence
{
    internal class Child : Parent
    {

        public int Z { get; set; }

        public Child(int x , int y , int z) :base(x ,y)
        {
            this.Z = z;
        }
        public override string ToString()
        {
            return $"X:{X}, Y : {Y} , Z : {Z}";
        }

        //override or hide

        public void Fun()
        {
            Console.WriteLine("I'm Child/Derived");
        }

        public void Fun2()
        {
            Console.WriteLine($"X : {X} , Y : {Y} , Z : {Z}");
        }
    }
}
