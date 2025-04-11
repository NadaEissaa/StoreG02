using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.OperatorOverloading
{
    internal class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }
 

        //Operator overloading
        // *
        //Must be Public - Static

        //Binary: have two operands
        public static Complex operator +(Complex left , Complex right)
        {
            return new Complex()
            {
                Real = left?.Real?? 0 + right?.Real??0,
                Imag = left?.Imag??0 + right?.Imag??0
            };


        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = left?.Real ?? 0 - right?.Real ?? 0,
                Imag = left?.Imag ?? 0 - right?.Imag ?? 0
            };


        }

        //Unary Operator
        //OP overloading ++ --

        // Function : public static
        //public static Complex operator ++ (Complex complex)
        //{
        //    if (Complex != null)
        //    {
        //        Complex.Real++;
        //        return Complex;
        //    }
        //    else new Complex();       
        //}

        //Comparison operator Binary : < > = !=
        // return type must be boolean

        //public static  bool operator > (Complex left , Complex right)
        //{
        //    if (left.Real == right.Real)
        //    {
        //        return left.Imag > right.Imag;

            
        //    }
        //    return left.Real > right.Real;
        //}

        //public static bool operator < (Complex left, Complex right)
        //{
        //    if (left.Real == right.Real)
        //    {
        //        return left.Imag < right.Imag;


        //    }
        //    return left.Real < right.Real;
        //}

        //user defined user operator

        //Implicit / Explicit
        public static  explicit operator string(Complex complex)
        {
            return complex.ToString();

        }
        public static implicit operator int(Complex complex)
        {
            return 155;
        }

        public override string ToString()
        {
            return $"{Real} + {Imag} i";
        }


    }
}
