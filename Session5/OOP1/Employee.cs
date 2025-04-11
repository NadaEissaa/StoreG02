using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal struct Employee
    {
        private int Id;
        private string name;
        private int salary;

        #region setter_Getter Method
        //Apply Enc user setter getter method

        //setter

        //public void SetId(int Id)
        //{
        //    this.Id = Id;
        //}
        //public void setName(string name)
        //{
        //    this.name = name;
        //}

        //public void SetSalary(int salary)
        //{
        //    if(salary > 0) { 
        //        this.salary = salary; 
        //    }

        //}
        //Getter

        //public int GetID()
        //{
        //    return Id;
        //}
        //public int GetSalary()
        //{
        //    return salary;
        //} 

        //public String GetNaeme()
        //{
        //    return name;
        //}

        //public Employee (int Id , string name , int salary)
        //{
        //    setName(name);
        //    SetId(Id);
        //    SetSalary(salary);
        //}

        //public override string ToString()
        //{
        //    return $" id {Id} : Name {name} : Salary {salary}";
        //}
        #endregion

        /////Apply Encapsulation user properties
        //1. Full Property

        // to access id
        //public int Id
        //{
        //    //set
        //    //Get
        //    set
        //    {
        //        Id = value;
        //    }

        //    get
        //    {
        //        return Id;

        //    }
        //}

        //public string Name
        //{
        //    set
        //    {
        //        name = value;

        //    }
        //    get
        //    {
        //        return name;

        //    }
        //}


        //2. Automatic Property
        //public string Address { set; get; }


        //3. Special Property [Indexer]

    }
}
