using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Session1
{
    internal class Point : IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point (int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
