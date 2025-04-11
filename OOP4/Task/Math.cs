using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal static class Math
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a , int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        public static double Divide(double a , double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot Divide be zero!");
            }

            return (double)a / b;
        }


    }

}
