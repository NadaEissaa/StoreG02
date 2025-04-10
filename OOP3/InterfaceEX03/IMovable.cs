using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.InterfaceEX03
{
    internal interface IMovable
    {
        public int Speed { get; set; }
        public int Forward { get; set; }
        public int Backwrd { get; set; }
        public int Left { get; set; }

        public int Right { get; set; }

    }
}
