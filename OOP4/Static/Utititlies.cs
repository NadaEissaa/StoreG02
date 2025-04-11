using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4.Static
{
    internal class Utititlies
    {
        public int X { get; set; }
        public int Y { get; set; }

        private static double pi = 3.14;

        public Utititlies()
        {
            pi = 3.14;
        }

        //Class member method
        public static double CmToInch(double cm)
        {
            return cm / 2.45;
        }

        public static double PI
        {
            get
            {
                return PI;
            }
        }
    }
}
