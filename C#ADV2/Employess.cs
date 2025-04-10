using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_ADV2
{
    internal class Employess :IComparable<Employess>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public double Age { get; set; }

        public int CompareTo(Employess? other)
        {
            Employess E = (Employess)other;
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Id} , {Name} , {Salary} , {Age}";

        }

    }
}
