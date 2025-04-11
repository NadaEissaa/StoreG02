using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.InterfaceEX02
{
    internal interface Iseries
    {
        int Current { get; set; }

        void Next();

        void Reset();
    }
}
