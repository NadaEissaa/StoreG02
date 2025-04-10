using System.Drawing;
using System.Runtime.CompilerServices;

namespace C__Session1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Generics E01:SWAP
            //Generics:
            //C# Feature 2005 C# 2.0
            //Before 2005 Class object

            //SWAP
            //int A = 4;
            //int B = 5;
            //Console.WriteLine($"A: {A} , B : {B}");
            //Console.WriteLine("AfterSwap");

            //Swap.SWAP( ref A,  ref B);
            //Console.WriteLine($"A: {A} , B : {B}");

            //double L = 4;
            //double K = 5;
            //Console.WriteLine($"L: {L} , K : {K}");
            //Console.WriteLine("AfterSwap");

            //Swap.SWAP(ref L, ref K);

            //Console.WriteLine($"L: {L} , K : {K}");

            //------------------------------------------------
            //int A = 4;
            //int B = 5;
            //Console.WriteLine($"A: {A} , B : {B}");
            //Console.WriteLine("AfterSwap");

            //Swap.SWAP<int>(ref A, ref B);

            //Console.WriteLine($"A: {A} , B : {B}");

            //double L = 4;
            //double K = 5;
            //Console.WriteLine($"L: {L} , K : {K}");
            //Console.WriteLine("AfterSwap");

            //Swap.SWAP(ref L, ref K);

            //Console.WriteLine($"L: {L} , K : {K}");

            #endregion

            #region Generic E02:LinearSearch
            //Linear Search
            //4 7 8 9 10 1 2 3 5 12 -1 -13 11
            //Index 

            //int[] Numbers = { 8, 5, 7, 9, 7, 10, 15 };
            //int Index = Swap.LinearSearch(Numbers, 4);
            //Console.WriteLine($"Index: {Index}");

            //Employess E4= new Employess()
            //{
            //    Id = 1, Name = "Nada", Age = 22, Salary = 25000
            //};
            //Employess E5 = new Employess()
            //{
            //    Id = 2,
            //    Name = "Ahmed",
            //    Age = 17,
            //    Salary = 20000
            //};
            //Employess E6 = new Employess()
            //{
            //    Id = 3,
            //    Name = "Mohamed",
            //    Age = 50,
            //    Salary = 50000
            //};
            //Employess[] employess = { E6, E5, E4 };


            //Swap.LinearSearch(employess, E5);
            //Console.WriteLine($"{E4}");
            #endregion

            #region Equality in Class or Struct

            // Equality in Class or Struct
            // Equals 
            //Class : has equals function which inherited from object class --> compare based on reference
            //Struct : has equals function which inherited from object class --> compare based on Data
            //Note : Struct don't have implementation for the == operator

            //Employess E4 = new Employess()
            //{
            //    Id = 1,
            //    Name = "Nada",
            //    Age = 22,
            //    Salary = 25000
            //};
            //Employess E7 = new Employess()
            //{
            //    Id = 1,
            //    Name = "Nada",
            //    Age = 22,
            //    Salary = 25000
            //};
            //Employess E5 = new Employess()
            //{
            //    Id = 2,
            //    Name = "Ahmed",
            //    Age = 17,
            //    Salary = 20000
            //};
            //if (E4.Equals(E7))
            //{
            //    Console.WriteLine("TRue");
            //}
            //else
            //{
            //    Console.WriteLine("Not");
            //}

            //if (E4 == E7)
            //{
            //    Console.WriteLine("TRue");
            //}
            //else
            //{
            //    Console.WriteLine("Not");
            //}
            #endregion

            #region Generic E03 :BubbleSort
            //Generic E03 :
            // 2, 3 , 9, 8 , 7,6 , 1 , 12 , -1 , 0
            // Sorting : Bubble Sort
            int[] Numbers = { 2, 3, 9, 8, 7, 6, 1, 12, -1, 0 };

            Console.WriteLine(Numbers);
            Swap.BubbleSort(Numbers);
            Console.WriteLine(Numbers);

            Point[] Points = { new Point( 1,1),
               new Point (2,2 ),
                new Point   (3,3 ),
                 new Point (4,5 )
            };
            Swap.BubbleSort(Points);
            #endregion



        }
    }
}
