using OOP4.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4
{
    internal class Rectangle : Shape /* implement and inheret from shape */

    {
        public override double perimeter
        {
            get
            {
                return (Dim02 + Dim01) *2 ;
            }
        }

        public override int GetArea()
        {
            return Dim01 * Dim02;
        }
    }
}
