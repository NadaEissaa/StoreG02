using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal struct Point
    {
        public int X;
        public int Y;

        //Constructor :Special Methods
        //            1.Named Like Struct
        //            2. Has to return Type
        //CLR : will generate parameterless constructor
        //this constructor will initialize the attribute with the default value

        //Constructor
        //public Point()
        //{

        //}
        //.Net 5.0 C# 9.0

        //public Point(int x , int y)
        //{
        //    X = x;
        //    Y = y;

        //}

        //public void printPoint()
        //{
        //    Console.WriteLine($"({X},{Y})");
        //}
        //public override string ToString()
        //{
        //    return $"({X},{Y})";
        //}
    }
}
