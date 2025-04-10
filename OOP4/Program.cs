using OOP4.Abstraction;
using OOP4.Mapping;
using OOP4.Static;
using System.Numerics;

namespace OOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Abstraction
            //4.Abstraction
            // abstract :C# keyword [class - method - proporties]

            //2D shape

            ///Note :  Can't create object from Abstract Class

            //Rectangle rectangle = new Rectangle() { Dim01 = 12 , Dim02 = 3};

            //Console.WriteLine(rectangle.perimeter);
            //Console.WriteLine(rectangle.GetArea());
            #endregion

            #region Interface VS Abstract Class
            //Interface VS Abstract Class
            // .Net 3.1 Core 
            #endregion

            #region  Operator overloading
            // Operator overloading

            // + * / -  > < != || && ..

            // *

            //int x = 2 + 5;
            //string Y = "Hello" + "World";

            // Complex Number : Real + Imaginary

            //4 + 3i



            //Complex C01 = new Complex(){ Real = 2, Imag = 8 };
            //Complex C02 = new Complex() { Real = 4, Imag = 7 };

            //Console.WriteLine(C01);
            //Console.WriteLine(C02);

            //Complex C03 = C01 + C02;
            //Complex C03 = C01 - C02;

            // ++ --
            //Unary operator

            //int X = 12;
            //X++;
            //Console.WriteLine(X);

            //Console.WriteLine(C01);
            //C01++;
            //Console.WriteLine(C01);

            //if (C01 > C02)
            //{
            //    Console.WriteLine("C01 is Greater");
            //}
            //else
            //{
            //    Console.WriteLine("C02 is Greater");
            //}
            #endregion

            #region User-Defined Casting Opertor & Mapping
            //double X = 12;
            //int Y =(int) X;

            ////(int) Casting Operator

            //Complex C01 = new Complex(Real = 4, Imag = 8);

            //string S =(string) C01;

            //(string) : convert complex number to string

            //operator overloading
            //user-defined casting operator

            //Mapping : convert from data type to data type

            //Code First
            ////DB First
            ///
            //User [Id , Name ,Email , Password , PhoneNumber ..]

            //UserViewModel
            //USerDto
            //[Name , Email , PhoneNumber ]

            User user = new User();
     
            //Manual Mapping
            UserDto userDto = new UserDto()
            {
                Email = user.Email,
                Name = user.Name,
                PhoneNumber= user.PhoneNumber

            };

            //Casting OP

            //AutoMapper : Automatic Mapping 

            #endregion

            #region Static : C# keyword
            //Static : C# keyword => class  , method , property , constructor , attribute

            //Utititlies U01 = new Utititlies();
            //Utititlies U02 = new Utititlies();
            //Utititlies U03 = new Utititlies();

            //Console.WriteLine(U01.CmToInch(1523)); 
            //Console.WriteLine(U02.CmToInch(1523));
            //Console.WriteLine(U03.CmToInch(1523));




            //Console.WriteLine(Utititlies.CmToInch(1523));
            //Console.WriteLine(Utititlies.CmToInch(1523));
            //Console.WriteLine(Utititlies.CmToInch(1523));

            //Console.WriteLine(U01.PI);  //xx

            //Console.WriteLine(U02.PI);  //xx

            //Console.WriteLine(Utititlies.PI);
            #endregion

            #region Sealed
            //Sealed : C# Keyword => Classes , Methods , property
            #endregion
        }
    }
}
