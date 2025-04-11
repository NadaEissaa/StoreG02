using ConsoleApp1.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Circle :ICircle
    {
        public double Radius { get; set; }
        public double Area => Math.PI * Radius * Radius;
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle : Radius = {Radius} , Area : {Area}");
        }
    }


}
