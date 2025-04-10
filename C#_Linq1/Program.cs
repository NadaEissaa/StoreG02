namespace C__Linq1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicity-Type local variable

            //Implicity-Type local variable [var - dynamic]
            //var

            //var Data01 = "Ahned";
            //compiler can detect the datatype of the local variable based on initial value , At compilation time
            //must be initialized
            //can't initialized the local variable with null
            //can't change the local variable after initialization

            //Data01 = 12; //Invalid

            //dynamic : like var in JS
            //Be careful when useing the dynamic
            // like var in JS or object in C#

            //
            //dynamic Data02 = null;
            //Console.WriteLine(Data02.GetType().Name);

            //CLR detect the datatype of the local variable based on the last value, At Runtime
            //Don't Need to be initialized
            //can be initialized the local variable with null 
            //Can change datatype of the local variable after initialization
            //can use dynamic keyword as parameter or return type

            //Data02 = 1.4;
            //Data02 = true;

            //var  X = () => Console.WriteLine("HW");


            #endregion


            #region Anonymous Type 
            //Anonymous Type 

            //Employee E01 = new Employee() { Id = 1, Name = "Nada Eissa", Salary = 25000 };

            //var E01 = new  { Id = 1, Name = "Nada Eissa", Salary = 25000 };


            //Console.WriteLine(E01.Salary );


            //E01.Id = 12; // invalid : immutable can't change it's value after creation

            //the same anonymous type as long as :
            // 1. the same property name [case sensitive]

            //compiler will overrrice on to string


            #endregion


            #region EXTENTION Methods
            // EXTENTION Methods

            //int Number = 1134;

            ////var result = IntExtention.Reverse(Number); //Class member method

            //var result =   Number.Reverse(); //Extension method

            //Console.WriteLine(result);
            #endregion


            #region What is LINQ
            //LINQ : Lanquage Integrated Query
            //     : 40 + Extension Method (LINQ Operator) Aganist any data [ data in sequence]
            //     : Regardless Data Store
            //     : 13 Category
            //     :LINQ operatore exists in built-in class "enumerable"

            //Sequence : Object From Class Implement Interface "IEnumberable"
            // Local Sequence  : L20 , L2XML
            // Remote Sequence : L2EF 

            //Input sequence -> LINQ operator -> output operator
            // INput sequence -> Linq operator -> one value
            //Linq operator -> output value

            //List<int> Numbers = new List<int>() { 1, 4, 5, 11, 20 };
            //var result = Enumerable.Where(Numbers, N => N % 2 == 0);



            //Console.WriteLine(result);

            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}


            #endregion


            #region LINQ Syntax
            //LINQ Syntax

            // 1. Fluent Syntax
            //Use LINQ Methods

            //1.1. LINQ operator as=> class member method throught class "Enumerable"

            //List<int> Numbers = new List<int>() { 1, 2, 5, 10 };
            //var result = Enumerable.Where(Numbers, X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}



            //1.2. LINQ Operator as => Extension Method throught sequence [ Recommended]


            //List<int> Numbers = new List<int>() { 1, 2, 5, 10 };
            //var result = Numbers.Where( X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}




            // 2. Query Syntax [Query Expression]



            //List<int> Numbers = new List<int>() { 1, 2, 5, 10 , 4 , 7 , 30 };

            //var result = from N in Numbers
            //             where N % 2 == 0
            //             select N;

            //// Start From 
            //// end select, group by
            ////Query syntax easier than Fluent (Join , Group By , Let , Into)


            ////var result = Enumerable.Where(Numbers, X => X % 2 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion


            #region LINQ Excecution ways

            //LINQ Excecution ways

            //// 1. Differed execution way   : 10 Categories 
            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = Numbers.Where(X => X % 2 == 0); //Differed

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}


            // 2. Immediate excecution way : 3 Categories [ Elements Operator , Casting Operator , Aggregate Operator ]

            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result =   Numbers.Where(X => X % 2 == 0).ToList(); //Immediate32333333

            //Numbers.AddRange(new int[] { 11, 12, 13, 14, 15 });


            //foreach(var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}
            #endregion







        }
    }
}
