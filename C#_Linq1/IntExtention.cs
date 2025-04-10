using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Linq1
{
    internal static class IntExtention
    {
        public static int Reverse (this int number)
        {
            int ReversedNumber = 0, lastDigit;
            while(number > 0)
            {
                lastDigit = number % 10;
                ReversedNumber = ReversedNumber * 10 + lastDigit;
                number /= 10;
            }

            return ReversedNumber;
        }
    }
}
