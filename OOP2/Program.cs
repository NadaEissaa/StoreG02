using OOP2.Binding;
using OOP2.Inheritence;
using OOP2.overriding;
using System.Security.AccessControl;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP2
{
    internal class Program
    {
        #region Functions
        //static int sum(int X , int Y)
        //{
        //    return X + Y;
        //}

        //static double sum(double X, double Y)
        //{
        //    return X + Y;
        //}


        //static void EmployeeProcess(FullTimeEmployee employee)
        //{
        //    employee.fun01();
        //    employee.fun02();

        //}

        //static void EmployeeProcess(PartTimeEmployee employee)
        //{
        //    employee.fun01();
        //    employee.fun02();

        //}
    

        //static void EmployeeProcess(Employee employee)
        //{
        //    if (employee is not null)
        //    {
        //        employee.fun01();
        //        employee.fun02();

        //    }

        //}
#endregion
        static void Main(string[] args)
        {
            #region Class Vs Struct
            //Class Vs Struct
            #endregion

            #region  Inheritance
            // 2. Inheritance : 
            // X --> Y 
            //DRY 

            //Parent parent = new Parent(1, 4);
            //Console.WriteLine(parent);

            //parent.Fun();
            //parent.Fun2();

            //Child child = new Child(1, 4, 7);

            //child.Fun();
            //child.Fun2();
            #endregion

            #region polymorphism overview
            //3. Polymorphusm
            //3.1 polymorphism Methods (Functions) Overloading
            //3.2 polymorphism Method ( Functions ) Overriding
            #endregion


            #region polymorphism Methods (Functions) Overloading
            //3.1 polymorphism Methods (Functions) Overloading
            //there are more than one function(in the same scope | class or struct) .. these functions have the same name but have different signature
            //Signature? (Count - type - order) parameters

            //sum(2, 5);
            //sum(2.2, 3.5);
            #endregion

            #region polymorphism Method ( Functions ) Overriding
            //3.2 polymorphism Method ( Functions ) Overriding
            //there are more than one function [in different class] these function have the same name
            // the same signature but the difference with the behaviour.. it means the body of the function

            //TypeB typeB = new TypeB() { A = 12 , B = 13};

            //typeB.A = 12;
            //typeB.B = 13;
            //Console.WriteLine(typeB.A);
            //Console.WriteLine(typeB.B);

            //typeB.fun01();
            //typeB.fun02();
            #endregion

            #region What is binding?

            //Binding 
            //What is binding?

            //Reference from parent --> object child
            //Static Binding
            //Compiler will bind function call based on reference type not object type
            //At compilation time

            //Dynamic Binding
            //CLR will bind the func call based on the type not the reference type
            //TypeA Ref;

            //Ref = new TypeA();


            //Child is a parent

            //TypeB is a  TypeA

            //Ref = new TypeB();

            //Ref.A = 122;
            //Ref.B = 12; //X

            //Ref.fun01(); //Static Binded method
            //Ref.fun02();
            #endregion


            #region Not Binding
            //Binding
            //RefParent --> ObjectChild

            //TypeA Ref = new TypeA;
            //Ref = new TypeB();

            //TypeB Ref = new TypeB();

            //Ref = new TypeA();

            //Child is a parent

            //Animal --> Dog , Dog is an animal
            //Dog --> Animal , Animal is a Dog?


            //TypeA Ref = new TypeA();
            //Ref = new TypeB();

            //TypeB typeB = (TypeB)Ref; //Not Binding

            #endregion

            #region When U need binding??
            //When U need binding??

            //Full time Employee : Id , name , address , email , salary

            //FullTimeEmployee FullTime = new FullTimeEmployee()
            //{
            //    Id = 1,
            //    Name = "Nada",
            //    Email = "nada@gmail",
            //    Address = "Cairo",
            //    Salary = 15000



            //};
            //EmployeeProcess(FullTime);

            ////Part time : full time attributs + hour rate & num of hours


            //PartTimeEmployee PartTime = new PartTimeEmployee()
            //{

            //    Id = 1,
            //    Name = "Ali",
            //    Email="Ali@",
            //    Address = "Giza",
            //    HourRate= 300,
            //    NumOfHours=200



            //};
            ////EmployeeProcess(PartTime);

            //EmployeeProcess(FullTime);
            #endregion

            #region Binding Example
            TypeA typeA;

            typeA = new TypeA();
            typeA = new TypeB();
            typeA = new TypeC();
            typeA = new TypeD();


            typeA.fun01();
            typeA.fun02();
            #endregion



            #region Protected , Private Protected , Internal Protected


            //protected : When a member of a class is marked as protected, it is accessible by only classes in the same package or by a subclass in different package / Assembly.
            //Private Protected :The class in which it is defined.
            //Any class that derives from it, but only if the derived class is in the same assembly.
            //Internal Protected:The same assembly.
            //Any class that derives from it, even if the derived class is in a different assembly.

            #endregion

        }

}
}
