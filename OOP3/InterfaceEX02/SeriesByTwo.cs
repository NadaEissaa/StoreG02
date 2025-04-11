using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.InterfaceEX02
{
    internal class SeriesByTwo : Iseries
    {
        public int Current { get; set; }

        public void Next()
        {
            Current += 2;
        }
        public void Reset()
        {
            Current = 0;
        }
    }
}
