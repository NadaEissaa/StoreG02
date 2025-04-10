using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFC_Session3.Entities
{
    internal class PartTimeEmployee:Employee
    {
        public double Salary { get; set; }
        public double hourRate { get; set; }
    }
}
