using System.Security.Cryptography.X509Certificates;

namespace OOP1


{

    //Class
    //Struct
    //Interface
    //Enum
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Struct
            //Struct : Value types :STACK


            //Employee
            //Id,Name,Salary

            // point

            //Point P01;

            //Declare For object from type 'point'
            //po1:object
            //allocate unintialized 8 Bytes at stack

            //Console.WriteLine(P01.X);

            //P01.X = 12;
            //P01.Y = 12;

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);

            //P01 = new Point(1, 2);
            //new used for select the constructor

            //Console.WriteLine(P01.X);
            //Console.WriteLine(P01.Y);
            //P01.printPoint();
            //Console.WriteLine(P01.ToString());

            #endregion

            #region OOP OverView
            //OOP: OBject orientedd programming

            //programming paradigm

            //OOP: The paradigm use for build any business

            //Class : Blueprint of the object
            //Object: specific instant from class

            // 4 pillars

            //1. Encapsulation

            //2. Inheritance

            //3. Polymorphism

            //4. Abstraction
            #endregion

            #region Encapsulation
            //1.Encapsulation
            //Class or Struct
            //Seperate the data (Attribites) definition from it's use
            //setter - getter method -- properties

            //Emplyee
            // Id Name Salary

            //1.End User Access Data Itself
            //2. No Data Validation
            //3. No read only filed

            //Apply Encapsulation
            //1.Make all data (Attributes)private
            //2.Access data through
            //2.1 setter getter method
            //2.2 properties

            //Employee E01 = new Employee(1 , "Nada", 27000);
            //Console.WriteLine(E01);
            //E01.Id = 1;
            //E01.name = "Nada";
            //E01.salary = 23000;

            //Console.WriteLine(E01.Id);
            //Console.WriteLine(E01.name);
            //Console.WriteLine(E01.salary);

            //E01.SetId(7);
            //E01.SetSalary(25000);
            //E01.setName("NadaEissa");

            //Console.WriteLine(E01.GetSalary());
            //Console.WriteLine(E01.GetID());
            //Console.WriteLine(E01.GetNaeme());
            #endregion

            #region Indexer

            //Indexer : Special property
            //named this

            //phonebook : 

            //PhoneBook PhoneBook = new PhoneBook(3);

            //PhoneBook.Addperson("Nada", 222, 0);
            //PhoneBook.Addperson("Ahmed", 333, 1);
            //PhoneBook.Addperson("Mohamed", 235, 2);

            //Console.WriteLine(PhoneBook.GetNumber("Ahmed"));

            //Console.WriteLine(PhoneBook["Ahmed"]);
            //PhoneBook["Ahmed"] = 666;

            //Console.WriteLine(PhoneBook["Nada"]);
            #endregion

            #region Class
            ////Class :Reference Type :Heap

            ////Car : Id Model Speed

            //Car C01 = new Car();

            //Console.WriteLine(C01.Id);
            #endregion


        }
    }
}
