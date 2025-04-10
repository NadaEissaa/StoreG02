using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Abstraction
{
    internal abstract class Shape
    {
        //Abstract Class;; partial class [not fully implemented class]
        //Concret class ;; Fully implemented class
        public int Dim01 { get; set; }
        public int Dim02 { get; set; }


        //Abstract method : like Virtual method without implementation
        public abstract int GetArea();

        //Make this method abstract
        //Abstract property : Like Virtial property without implementation
        public abstract double perimeter { get; }
       

    }
}
