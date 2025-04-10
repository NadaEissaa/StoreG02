using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2.Inheritence
{
    internal class Parent
    {

        //public Parent()
        //{

        //}
        public int X { get; set; }
        public int Y { get; set; }

        public Parent(int x , int y)
        {
            this.X = x;
            this.Y = y;

        }

        public void Fun()
        {
            Console.WriteLine("I'm Parent/Base");
        }

        public void Fun2()
        {
            Console.WriteLine($"X : {X} , Y : {Y}");
        }



        public override string ToString()
        {
            return $"X : {X} , Y {Y}";
        }
    }
}
