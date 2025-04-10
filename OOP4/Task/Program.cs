namespace Task
{
    internal class Program
    {

        #region 3DPoint
        //static Point3D ReadPointFromUser()
        //{
        //    try
        //    {
        //        string[] input = Console.ReadLine().Split(' ');
        //        int x = int.Parse(input[0]);
        //        int y = int.Parse(input[1]);
        //        int z = int.Parse(input[2]);
        //        return new Point3D(x, y, z);
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Invalid input. Using default (0, 0, 0).");
        //        return new Point3D();
        //    }


        //}
        #endregion


        static void Main(string[] args)
        {

            #region 3D Point
            //Console.WriteLine("Enter coordinates for point 1(X, Y , Z)");
            //Point3D p1 = ReadPointFromUser();

            //Console.WriteLine("Enter coordinates for Point 2 (X Y Z):");
            //Point3D p2 = ReadPointFromUser();

            //Console.WriteLine($"Point 1: {p1}");
            //Console.WriteLine($"Point 2: {p2}");

            //if (p1 == p2)
            //    Console.WriteLine("Points are equal.");
            //else
            //    Console.WriteLine("Points are not equal.");

            //Point3D[] points =
            //{
            //    new Point3D(5 , 2 , 1),
            //    new Point3D(2, 8, 3),
            //    new Point3D(3, 1, 4),
            //    new Point3D(1, 2, 3)


            //};

            //Array.Sort(points);

            //Console.WriteLine("Sorted Points");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //Point3D ClonedPoint = (Point3D)p1.Clone();
            //Console.WriteLine($"Cloned Point : {ClonedPoint}");
            #endregion

            #region Math
            //try
            //{
            //    int num1 = 20, num2 = 10;
            //    Console.WriteLine($"Addition :{Math.Add(num1, num2)}");
            //    Console.WriteLine($"Subtraction: {Math.Subtract(num1, num2)}");
            //    Console.WriteLine($"Multiplication: {Math.Multiply(num1, num2)}");
            //    Console.WriteLine($"Division: {Math.Divide(num1, num2)}");

           

            //}
            //catch(DivideByZeroException ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}
            #endregion

            #region Duration

            Duration d1 = new Duration(1, 10, 15);
            Console.WriteLine(d1); 

            Duration d2 = new Duration(3600);
            Console.WriteLine(d2); 

            Duration d3 = new Duration(7800);
            Console.WriteLine(d3); 

            Duration d4 = new Duration(666);
            Console.WriteLine(d4); 




            Duration d5 = d1 + d3;
            Console.WriteLine($"D1 + D3: {d5}");

            d5 = d1 + 7800;
            Console.WriteLine($"D1 + 7800 seconds: {d5}");

            d5 = 666 + d4;
            Console.WriteLine($"666 seconds + D4: {d5}");

      
            d5 = ++d1;
            Console.WriteLine($"++D1: {d5}");

            d5 = --d3;
            Console.WriteLine($"--D3: {d5}");

         
            d5 = d1 - d2;
            Console.WriteLine($"D1 - D2: {d5}");

            
            Console.WriteLine(d1 > d2 ? "D1 is greater than D2" : "D1 is not greater than D2");
            Console.WriteLine(d1 <= d2 ? "D1 is less than or equal to D2" : "D1 is not less than or equal to D2");

           
            Console.WriteLine(d1 ? "D1 is valid (non-zero)" : "D1 is zero");

         
            DateTime dateTime = (DateTime)d1;
            Console.WriteLine($"D1 as DateTime: {dateTime}");
        
        #endregion



    }
    }
}