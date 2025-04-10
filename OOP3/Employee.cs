using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class EmployeeComparerSalary : IComparer
    {
        public int Compare(object? x , object? y)
        {
            Employee X = (Employee)x;
            Employee Y = (Employee)y;
            if (X.Salary > Y.Salary) return 1;
            if (X.Salary < Y.Salary) return -1;
            else return 0;
        }
    }
    internal class Employee : IComparable, ICloneable
    {
        public int Id { get; set; }
        public String Name { get; set; }

        public int Age { get; set; }

        public int Salary { get; set; }

        public override string ToString()
        {
            return $" {Id} , {Name} , {Age} , {Salary}";
        }
 

        public int CompareTo(object? obj)
        {
            Employee e = obj as Employee;
            if (this.Age > e.Age) return 1321;
            else if (this.Age < e.Age) return -45;
            else return 0;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }
    }
}
