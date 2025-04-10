using OOP3.Inteface;
using OOP3.InterfaceEX02;

namespace OOP3
{
    internal class Program
    {

        #region Interface EX02
        static void Print10Number(SeriesByTwo series)
        {

            for(int i = 0; i <10; i++)
            {
                Console.WriteLine($"series : {series}");
                series.Next();
            }
            Console.WriteLine(";;");
            series.Reset();
        }
        #endregion
        static void Main(string[] args)
        {

            #region Interface EX01
            // Inteface : Reference Type

            //Code Contract : Between the developer who wrote it and the developer who uses it
            //It 

            //IMytype myType = new IMytype(); //Invalid
            //IMytype.Myfun();

            // Note : con't create any object from any interface

            //Can create Ref from Interface and this Ref can refere to object from class whick implement the interface
            //From class which implemet the interface


            //MyType myType = new MyType();
            //myType.MyFun();
            #endregion

            #region Interface EX02
            //SeriesByTwo seriesByTwo = new SeriesByTwo();

            //int[] Numbers = { 8, 6, 5, 3, 4, 10 };
            //Employee[] employess = new Employee[3]
            //{
            //    new Employee(){Id = 1 , Name = "Ahmed" , Age = 29 , Salary =12000},
            //    new Employee(){Id = 1 , Name = "Nada" , Age = 20 , Salary =12000},
            //    new Employee(){Id = 1 , Name = "Eissa" , Age = 80 , Salary =12000}
            //};
            //Array.Sort(Numbers);

            //foreach(int item in Numbers)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion

            #region Interface EX03

            //Car car = new Car();
            //Car.Forward()
            #endregion

            #region SHallow Copy vs Deep Copy
            //Sallow copy vs Deep Copy

            //Shallow Copy

            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };
            //Console.WriteLine($"Arr01 :  { Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 :  {Arr02.GetHashCode()}");

            //Arr02 = Arr01(); //Shallow copy

            ////Clone Method will copy the object state [Date] of the caller
            ////This func will Generate new identity
            ////Object : Identity (Address) +  object State (Date)
            ////Idenetity

            //Arr02[0] = 100;
            //Console.WriteLine(Arr01[0]);


            //Deep copy


            //int[] Arr01 = { 1, 2, 3 };
            //int[] Arr02 = { 4, 5, 6 };

            //Console.WriteLine();
            //Console.WriteLine($"Arr01 :  {Arr01.GetHashCode()}");
            //Console.WriteLine($"Arr02 :  {Arr02.GetHashCode()}");

            //Arr02 =(int[]) Arr01.Clone(); //Deep copy

            ////Object : Identity (Address) +  object State (Date)
            ////Idenetity

            //Arr02[0] = 100;

            //Console.WriteLine(Arr01[0]);
            #endregion

            #region Built-In Interface IComparable

            //Employee[] employess = new Employee[3]
            //{
            //    new Employee(){Id = 1 , Name = "Ahmed" , Age = 29 , Salary =12000},
            //    new Employee(){Id = 1 , Name = "Nada" , Age = 20 , Salary =12000},
            //    new Employee(){Id = 1 , Name = "Eissa" , Age = 80 , Salary =12000}
            //};

            //int X = employess[0].CompareTo(employess[1]);

            //foreach (Employee item in employess)
            //{
            //    Console.WriteLine($"{item}");
            //}

            //Array.Sort(employess);
            #endregion

            #region Built-In Interface IComparer
            //   Employee[] employess = new Employee[3]
            //{
            //       new Employee(){Id = 1 , Name = "Ahmed" , Age = 29 , Salary =12000},
            //       new Employee(){Id = 1 , Name = "Nada" , Age = 20 , Salary =12000},
            //       new Employee(){Id = 1 , Name = "Eissa" , Age = 80 , Salary =12000}
            //};

            //   int X = employess[0].CompareTo(employess[1]);

            //   Array.Sort(employess , new EmployeeComparerSalary());

            //   foreach (Employee item in employess)
            //   {
            //       Console.WriteLine($"{item}");
            //   }


            #endregion

        }
    }
}
