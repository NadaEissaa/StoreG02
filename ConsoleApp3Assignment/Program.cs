using System;
using System.ComponentModel.DataAnnotations;
using System.Net.Http.Headers;

namespace Assigment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1

            //try
            //{
            //    Console.Write("Input:  ");
            //    int number = int.Parse(Console.ReadLine());
            //    if ((number % 3 == 0) && (number % 4 == 0))
            //        Console.WriteLine("output: Yes");
            //    else
            //        Console.WriteLine("output: No");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("The input is invalid");
            //}

            #endregion



            #region 2
            //Console.Write("Input:  ");
            //int number;
            //number = int.Parse(Console.ReadLine());
            //if (number < 0)
            //    Console.WriteLine("output: Negative");
            //else
            //    Console.WriteLine("output: Positive");
            #endregion


            #region 3
            //Console.Write("input : ");
            //int number1 = Convert.ToInt32(Console.ReadLine());
            //int number2 = Convert.ToInt32(Console.ReadLine());
            //int number3 = Convert.ToInt32(Console.ReadLine());
            //if (number1 > number2 && number1 > number3)
            //{
            //    Console.WriteLine("maximum is  = " + number1);

            //}
            //else if (number2 > number1 && number2 > number3)
            //{
            //    Console.WriteLine("maximum is  = " + number2);
            //}
            //else
            //    Console.WriteLine("maximum is  = " + number3);
            //if (number1 < number2 && number1 < number3)
            //{
            //    Console.WriteLine("minimum is  = " + number1);
            //}
            //else if (number2 < number1 && number2 < number3)
            //{
            //    Console.WriteLine("minimum is  = " + number2);
            //}
            //else
            //    Console.WriteLine("minimum is  = " + number3);

            #endregion


            #region 4
            //int number = Convert.ToInt32(Console.ReadLine());
            //if (number % 2 == 0)
            //    Console.WriteLine("This number is even");
            //else
            //    Console.WriteLine("This number is even");
            #endregion


            #region 5
            //Console.Write("Input: ");

            //char message = Convert.ToChar(Console.Read());
            //if (message == 'o' || message == 'O' || message == 'a' || message == 'A'
            //    || message == 'e' || message == 'E' || message == 'I' 
            //    || message == 'U'
            //    || message == 'i' || message == 'u')
            //    Console.WriteLine("output: Vowel");
            //else
            //    Console.WriteLine("output: Constant");
            #endregion


            #region 6
            //Console.Write("Input: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Output: ");
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i +",");
            //}
            #endregion

            #region 7
            //    int product = 0;
            //    Console.Write("Input: ");
            //    int number = int.Parse(Console.ReadLine());
            //    Console.Write("Output: ");
            //for(int i=1;i<=12; i++)
            //    {
            //        product = i * number;
            //        Console.Write(product + " ");
            //    }
            #endregion

            #region 8
            //Console.Write("Input: ");
            //int number = int.Parse(Console.ReadLine());
            //Console.Write("Output: ");
            //for(int i = 1; i < number; i++)
            //{
            //    if(i%2 == 0)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion

            #region 9
            // int power = 1;
            // Console.Write("Input: ");
            // int number1 = Convert.ToInt32(Console.ReadLine());
            // int number2 = Convert.ToInt32(Console.ReadLine());

            // for(int i = 0;i < number2; i++) 
            // {
            //     power *= number1;

            // }
            // Console.Write("Output: ");
            //Console.Write(power);
            #endregion


            #region 10
            //int total = 0;
            //int avg = 0;
            //int percentage = 0;
            //Console.Write("Input: ");
            //Console.WriteLine("Enter Marks for five Subject");
            //for (int i = 0; i < 5; i++)
            //{
            //    int grade = int.Parse(Console.ReadLine());
            //    total += grade;
            //    avg = total / 5;
            //    percentage = (int)(total / 500.0 * 100);

            //}
            //Console.Write("Output: ");
            //Console.WriteLine("Total Marks = " + total);
            //Console.WriteLine("Average Marks = " + avg);
            //Console.WriteLine("Percentage = " + percentage);
            #endregion


            #region 11

            //Console.Write("Input: Month Number:");
            //int month = int.Parse(Console.ReadLine());
            //if (month == 1 || month == 3 || month == 5 || month == 7 ||
            //    month == 8 || month == 10 || month == 12) 
            //{
            //    Console.WriteLine("Output: Days in Month: 31");
            //}
            //else
            //    Console.WriteLine("Output: Days in Month: 30");
            #endregion


            #region 12
            //Console.Write("Enter number 1 : ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter number 2 : ");
            //int number2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operator: ");
            //char symbol = char.Parse(Console.ReadLine());
            //int result = 0;
            //switch (symbol)
            //{
            //    case '+':
            //        result = number1+ number2;
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        break;
            //    case '%':
            //        result = number1 % number2;
            //        break;
            //    default:
            //        Console.WriteLine("this operator not valid");
            //        break;
            //}
            //Console.Write("The result  is  =  " + result);
            #endregion

            #region 13
            //string name = Console.ReadLine();
            //int length = name.Length;
            //char reverse;
            //for (int i = length; i > 0; i--) 
            //{
            //    reverse = name[i - 1];
            //    Console.Write(reverse);
            //}

            #endregion

            #region 14
            // Console.Write("Enter the number to reverse: ");
            // int number = int.Parse(Console.ReadLine());
            // // 123
            // int digit;
            // int reverse = 0;
            //while(number != 0)
            // {

            //     digit = number % 10;
            //     reverse = reverse * 10 + digit;
            //     number /= 10;
            // }

            //Console.Write("the reverse of number is: " + reverse);



            #endregion

            #region 15
            //int count;
            //int startrange = int.Parse(Console.ReadLine());
            //int endrange = int.Parse(Console.ReadLine());

            //for (int i = startrange; i <= endrange; i++) 
            //{
            //    count = 0;
            //    for( int j = 2; j <= i/2; j++)
            //    {
            //        if(i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //    if(count == 0 && i != 1)
            //    {
            //        Console.Write(i + " "); 
            //    }
            //}
            #endregion

            #region 17
            //int area;
            //Console.Write("Enter first point: ");
            //int x1 = int.Parse(Console.ReadLine());
            //int y1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter secound point: ");
            //int x2 = int.Parse(Console.ReadLine());
            //int y2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter third point: ");
            //int x3 = int.Parse(Console.ReadLine());
            //int y3 = int.Parse(Console.ReadLine());
            //area = 1 / 2*Math.Abs((x1*(y2 - y3) + x2*(y3 - y1) + x3*(y1 - y3)));

            //if (area == 0)
            //    Console.WriteLine("The points lies on same straight line");
            #endregion


            #region 16
            // Console.Write("Enter number to Convert : ");
            // int number = int.Parse(Console.ReadLine());
            // string binary = Convert.ToString(number,2);
            //Console.WriteLine("the binary of " + number + " is " + binary);
            #endregion


            #region 18
            //Console.Write("Enter the hours needed to end the task: ");
            //double time = int.Parse(Console.ReadLine());
            //if (time >= 2 && time < 3)
            //    Console.Write("highly efficient");
            //else if (time >= 3 && time < 4)
            //    Console.Write("instructed to increase their speed");
            //else if (time >= 4 && time <= 5)
            //    Console.Write("provided with training to enhance their speed.");
            //else if (time > 5)
            //    Console.Write("they are required to leave the company");
            //else
            //    Console.Write("the number of hours at least 2 hours");
            #endregion
        }
    }
}
