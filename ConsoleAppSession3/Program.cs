using System.Collections.Specialized;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleAppSession3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region StringFormatting
            //1 string Concatentaion
            //2 String Format
            //int X = 4, Y = 3;
            //String Message = String.Format("Equation : {0} + {1} = {2}", X, Y, X + Y);
            //Console.WriteLine(Message);
            #endregion

            #region
            //Control Statements



            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");
            //Console.WriteLine("Hello World");

            //Control Statements : 1 . Conditional Control Statements(If statement, Swich Case)

            //Console.Write("Enter month number in the first Quarter : ");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //Console.WriteLine("Jan");
            //Console.WriteLine("Feb");
            //Console.WriteLine("Mar");
            #endregion
            #region EX1
            // 1. Using If

            //if/*(Expression)*/
            //{
            //    /Body
            //    //code : the code will be executed when the expression is true

            //}

            //if (true)
            //{
            //    Console.WriteLine("Hello World");
            //}

            // if (MonthNumber == 1)
            // {
            //     Console.WriteLine("Jan");
            // }

            //else if (MonthNumber == 2)
            // {
            //     Console.WriteLine("Feb");
            // }
            //else if (MonthNumber == 3)
            // {
            //     Console.WriteLine("Mar");
            // }
            // else
            // {
            //     Console.WriteLine("InvalidInput");
            // }

            #endregion

            #region Ex2

            //2. Using Switch

            //switch (/*expression*/)
            //{

            //    case:
            //        //Code
            //        //console.writeLine("")
            //        break;
            //}

            //Jump Table

            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month ");
            //        break;

            //}



            //Console.Write("Enter Your Name :");
            //string Name = Console.ReadLine();

            //Ahmed -> Hi Ahmed
            //Ahmed -> Hi Ai
            //Ahmed -> Hi Omar
            //Ahmed -> Hi Mariam
            //Invalid Input

            //if(Name== "Ahmed" ||  Name=="ahmed" )
            //{
            //    Console.WriteLine("Hi Ahmed");
            //}
            //else if (Name == "Mariam" || Name == "mariam")
            //{
            //    Console.WriteLine("Hi Mariam");
            //}
            //else if (Name == "Omar" || Name == "omar")
            //{
            //    Console.WriteLine("Hi Omar");
            //}
            //else if (Name == "Ali" || Name == "ali")
            //{
            //    Console.WriteLine("Hi ali");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}

            //Jump table

            //switch (Name)
            //{
            //    case "Ahmed":
            //    case "ahmed":
            //        Console.WriteLine("Hi Ahmed");
            //        break;
            //    case "Ali":
            //    case "ali":
            //        Console.WriteLine("Hi Ali");
            //        break;
            //    case "Mariam":
            //    case "mariam":
            //        Console.WriteLine("Hi Mariam");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;

            //}
            #endregion


            #region EX3


            //Using Switch:
            //int Age = int.Parse(Console.ReadLine());
            //switch (Age > 18)
            //{
            //    case true:
            //        Console.WriteLine("Welcome :)");
            //        break;
            //    case false:
            //        if (Age < 18)
            //        {
            //            Console.WriteLine("Bye Bye");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Bye Bye");
            //        }
            //        break;


            //}

            //switch (Age)
            //    {
            //    case > 18:
            //        Console.WriteLine("Welcome ;)");
            //        break;
            //    case < 18:
            //        Console.WriteLine("Bye bye");
            //        break;
            //    default:
            //        Console.WriteLine("Inter valid input");
            //        break;


            //    }


            //object Input = new object();
            //Input = 1;
            //Input = "Ahmed";

            //switch (Input) 
            //{

            //    case int X when X > 12 :
            //        Console.WriteLine("INT STRING");
            //        break;
            //    case int X when X < 12:
            //        Console.WriteLine("INT STRING");
            //        break;
            //    case string S when S.Length > 12 :
            //        Console.WriteLine("INPUT STRING");
            //        break;



            //}

            #endregion

            #region C#0.7

            //string Input = Console.ReadLine();

            //switch (Input) {
            //    case "1":
            //        Console.WriteLine("OPTION 01");
            //        break;
            //    case "2":
            //        Console.WriteLine("OPTION 02");
            //        break;
            //    case "3":
            //        Console.WriteLine("OPTION 03");
            //        break;
            //    default:
            //        Console.WriteLine("XX");
            //        break;
            //}
            #endregion

            #region C#0.8


            //string Input = Console.ReadLine();

            //Console.WriteLine(Input switch
            //{
            //    "1" => "OP 1",
            //    "2" => "OP 2",
            //    "3" => "OP 3",
            //    _ => "Invalid Input"

            //});

            //string Output = Input switch
            //{
            //    "1" => "OP 1",
            //    "2" => "OP 2",
            //    "3" => "OP 3",
            //    _ => "Invalid Input"

            //};


            #endregion

            #region ForLoop

            //Control Statements : 2 . Loop Control Statement (For Loop , ForEach , while , )

            // 1. forloop

            //for (statement; expression;statement )
            //{
            //    //body
            //    //code
            //}

            //for (Console.WriteLine("Hello 01"); true; Console.WriteLine("Hello 02"))
            //{
            //    Console.WriteLine("Hello Workd");
            //}

            //for(int X = 1; X <= 10; X++)
            //{
            //    Console.WriteLine("Hello World");
            //}
            //int X = 1;

            //for (Console.WriteLine("Hello 01"); X <= 10; Console.WriteLine("Hello World"))
            //{
            //    X++;
            //}

            //for(int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine(i)
            //}



            // 2. foreach
            //int[] Numbers = { 1, 2, 3, 4, 5, 6 , 7 , 8 , 9 };
            //Console.WriteLine(Numbers[0]);
            //Console.WriteLine(Numbers[1]);

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}


            //foreach (int N in Numbers)
            //{
            //    Console.WriteLine(N);
            //}



            // 3. white

            //while (expression)
            //{
            //    code
            //}
            //int i = 1;
            //while (i<=10)

            //{
            //    Console.WriteLine("Hello World");
            //    i++;

            //}

            // Do While

            //do
            //{

            //} while (expression);

            //int i = 11;
            //do
            //{
            //    Console.WriteLine("Hello world");
            //    i++;

            //} while (i <= 10);
            #endregion

            #region forloopEX
            //int EvenNumber ;

            //do
            //{
            //    Console.Write("Even Number : ");
            //     //EvenNumber = int.Parse(Console.ReadLine());


            //} while(!int.TryParse(Console.ReadLine(), out EvenNumber) || EvenNumber % 2 !=0);
            //Console.WriteLine(EvenNumber);


            #endregion

            #region Strings

            // String : Datetype (reference Type) :Heap
            //Immutable DateType : can't change it's value after the creation

            //string s01;
            //declare for reference from string
            // s01 : can refere to object from type string
            //s01 refer to null
            //8 bytes will be alloacted at stack for the reference "s01"
            //0 bytes will be allocated HEAP

            //s01 = new string("Ahmed");
            //s01 = "Ahmed";
            //new
            //1. allocate the number of required bytes for the object at heap
            //2. initialized the allocated bytes with the default value of the datetype
            //3. call user_defined constructor if exists
            //4. assign the object to the reference 's01'

            //string Name01 = "Ahmed";
            //string Name02 = "yasmin";
            //Console.WriteLine($"Name01 :  { Name01 }");
            //Console.WriteLine($"Name02 :  {Name02}");
            //Console.WriteLine("------------------------------");

            //Name02 = Name01;
            //Console.WriteLine($"Name01 :  {Name01}");
            //Console.WriteLine($"Name02 :  {Name02}");
            //Console.WriteLine("------------------------------");


            //Name02 = "Ali";
            //Console.WriteLine($"Name01 :  {Name01}");
            //Console.WriteLine($"Name02 :  {Name02}");
            // this line will create new object 

            //string message = "Hello";
            //Console.WriteLine($"messsage : {message}");
            //Console.WriteLine($"messageHashCode : {message.GetHashCode()}");

            //message += " Ahmed";
            //Console.WriteLine($"messsage : {message}");
            //Console.WriteLine($"messageHashCode : {message.GetHashCode()}");




            // string builder: Reference type : Heap
            //Mutable datatype : can change its value after creation

            //StringBuilder message = new StringBuilder("Hello");
            //Console.WriteLine($"message : {message}");
            //Console.WriteLine($"message : {message.GetHashCode()}");
            //Console.WriteLine("------------------------------");

            //message.Append(" Nada");
            //Console.WriteLine($"message : {message}");
            //Console.WriteLine($"message : {message.GetHashCode()}");
            #endregion








        }

    }
}