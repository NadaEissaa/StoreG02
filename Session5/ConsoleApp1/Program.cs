using Common;

namespace ConsoleApp1
{
    internal class Program
    {
        #region F1
        //static void DoSomeCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        X = int.Parse(Console.ReadLine()); //format exception

        //        Y = int.Parse(Console.ReadLine());//format exception

        //        Z = X / Y; //Divide by zero exception

        //        int[] arr = { 1, 2, 3 };
        //        arr[99] = 100;
        //    }catch(DivideByZeroException E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }catch(FormatException E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //    finally
        //    {
        //        //Code
        //        //Console.WriteLine("Finally");

        //        //DisConnect | Dispose to UnManaged Resource(File, DB)


        //    }


        //}
        #endregion

        #region F2
        //static void DoSomeProtectiveCode()
        //{
        //    try
        //    {
        //        int X, Y, Z;
        //        bool Flag;

        //        do
        //        {
        //            Console.Write("Enter First Number:");
        //            Flag = int.TryParse(Console.ReadLine(), out X);
        //        } while (Flag == false);
        //        do
        //        {
        //            Console.Write("Enter Second Number:");
        //            Flag = int.TryParse(Console.ReadLine(), out Y);
        //        } while (Flag == false || Y == 0);


        //        int index;
        //        Z = X / Y; //Divide by zero exception



        //        int[] arr = { 1, 2, 3 };

        //        //arr[99] = 100;
        //    }catch(Exception E)
        //    {
        //        Console.WriteLine(E.Message);
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {

            #region Boxing and unboxing
            ////Boxing and unboxing

            ////boxing : casting from datatype [value type] to datatype [ reference type]
            ////unboxing : casting from datatype [reference type] to datatype [ data type]

            ////boxing

            ////object O1;
            ////1 : can refer to instance from 'object' or any instance from any datatype

            ////O1 =(object) 1; //casting from integer [ value type ] to object [ reference type]
            ////O1 = (object)1.5; // casting from double [value type ] to object [ refernce ]
            ////O1 = 'A';


            ////int X = 12;

            ////object O1 =(object) X;
            //////implicit casting
            //////safe casting
            //////parent => child
            //////Animal => Dog : Dog is animal
            /////

            ////unboxing

            //object O1 = 1;
            //int X = (int) O1;

            ////Explicit Casting
            ////Unsafe Casting : May throw exception
            ////child => parent
            //// Dog => animal : animal is dog?
            //Console.WriteLine(X);
            #endregion


            #region Nullable value types
            //Nullable types
            //value types


            //int X = 12;

            //Console.WriteLine(X);

            //int Age = 30;
            //Age = null; //invalid : int don't allow null as a valid value


            //Console.WriteLine(Age);

            //nullable value types : allow null as valid value
            //int? Age = 30;
            //Age = null;
            //Console.WriteLine(Age);

            //Nullable<double> : allow double values + null as valid values

            //double? salary = 32000;
            //salary = null;
            //Console.WriteLine(salary);

            //int X = 12; //Nullable<int> allow integers valus + null as valid value

            //int?Y = X;
            //Console.WriteLine(Y);


            //protective code
            //int? X = 12;
            //X = null;

            //int Y;

            //if(X != null)
            //{
            //    Y = (int)X;
            //}
            //else
            //{
            //    Y = 0;
            //}
            //Console.WriteLine(Y);

            //======================================
            //if (X.HasValue)
            //{
            //    Y = X.Value;
            //    Console.WriteLine(Y);
            //}
            //else
            //{
            //    Y = 0;
            //}

            //Null coalescing operator
            //?

            //Y = X ?? 0;

            //Console.WriteLine(Y);



            //reference types
            #endregion


            #region Nullable refernece Types


            //Nullable reference type : allow null as valid (C# 10.0 Dotnet 6.0)
            string mes2 = null; //required
            string? mes1 = null; // optional

            Console.WriteLine(mes1);
            Console.WriteLine(mes2);


            #endregion


            #region Null propagation operator
            //Null propagation operator
            // ?

            //Boolean X = default;
            //Console.WriteLine(X);

            int[] Arr = { 1 , 2 ,3}; // Null
                                     //Console.WriteLine(Arr);

            //Null reference exception

            //for(int i = 0;(Arr is not null) && i < Arr.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}


            //for (int i = 0;  i < Arr?.Length; i++)
            //{
            //    Console.WriteLine(Arr[i]);
            //}

            //if(Arr is not null)
            //{
            //    for (int i = 0; i < Arr.Length; i++)
            //    {
            //        Console.WriteLine(Arr[i]);
            //    }

            //}

            //int len = Arr is not null ? Arr.Length :0;
            //int len = Arr?.Length;
            //int len = Arr?.Length is not null ? Arr.Length : 0;
            //int len = Arr?.Length ?? 0; //sytax sugar

            //Console.WriteLine(len);






            #endregion


            #region Exception handling and protective code
            //Exception hangling and protective code
            // Execption : Runtime errors

            //Console.WriteLine("Hello");
            //throw new Exception();
            //Console.WriteLine("Hello after exception");



            //Exception handling
            //1.system exception
            //1.1. Null reference exception
            //1.1.1 Format exception
            //1.1.1.1 indexOutOfRange Exception
            //1.1.1.1.1.Arithmatic Exception
            //DivideByZero Exception
            //Overflow Exception

            //2. application exception

            //DoSomeCode();

            //DoSomeProtectiveCode();

            #endregion

            #region
            // Class Library

            //TypeA typeA = new TypeA();


            #endregion
           


        }
    }
}
