using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum SecurityLevel { Guest, Developer, Secretary, DBA }

namespace AssignmentOOP1
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public SecurityLevel Security { get; set; }
        public decimal Salary { get; set; }
        public HireDate HireDate { get; set; }
        public char Gender { get; set; }

        public Employee(int id, string name, SecurityLevel security, decimal salary, HireDate hireDate, char gender)
        {
            ID = id;
            Name = name;
            Security = security;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender == 'M' || gender == 'F' ? gender : throw new ArgumentException("Invalid Gender");
        }

        public override string ToString()
        {
            return $"ID: {ID}, Name: {Name}, Security: {Security}, Salary: {Salary:C}, Hire Date: {HireDate}, Gender: {Gender}";
        }

        public int CompareTo(Employee other)
        {
            return HireDate.Year == other.HireDate.Year ?
                (HireDate.Month == other.HireDate.Month ?
                    HireDate.Day.CompareTo(other.HireDate.Day) :
                    HireDate.Month.CompareTo(other.HireDate.Month)) :
                HireDate.Year.CompareTo(other.HireDate.Year);
        }
    }
}
