using System.Collections;

namespace C__Linq2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            // LINQ : 40+ Extension Method
            // LINE : 13 Category

            #region Filteration Operators - Where / ofType
            // 1. Filteration Operators - Where / ofType

            // All Products out of stock

            //Fluent Syntax

            //var result =  ListGenerator.ProductList.Where(P => P.UnitsInStock == 0);


            //Query Syntx

            //Indexed where valid only in fluent syntx
            // can't be written using query syntx [Query Expression]

            //var result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock == 0
            //             select P;

            //var result =  ListGenerator.ProductList.Where(P => P.Category == "Meat/Poultry");

            //var result = from P in ListGenerator.ProductList
            //             where P.Category == "Meat/Poultry"
            //             select P;

            //ListGenerator.ProductList.Where(p => p.UnitsInStock > 0).Where(P => P.Category == "Meat/Poultry");


            //var result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Meat/Poultry"
            //             select P;

            //var result =  ListGenerator.ProductList.Where((P, Index) => Index < 10 && P.UnitsInStock == 0);



            //---------------------------------------------------

            //OfType

            //ArrayList arraylist = new ArrayList() { 1, 4, "Nada", "Ahmed", 1.5, 1.2, 1.3f, 1.7f, 1.8f, 2.5m, 4.5m, ListGenerator.ProductList[0] };

            //var result = arraylist.OfType<int>();
            ////var result = ListGenerator.ProductList.Where(p => p.UnitsInStock > 0).Where((P, I) => I < 5);
            //foreach(var unit in result)
            //{
            //    Console.WriteLine(unit);
            //}

            #endregion


            #region Transformation Operators - Select / SelectMany
            // 2. Transformation Operators - Select / SelectMany

            //var result=     ListGenerator.ProductList.Select(P => P.ProductName);


            //var result = from P in ListGenerator.ProductList
            //             select P.ProductName;


            //var result = ListGenerator.ProductList.Where(P => P.UnitsInStock > 0 && P.Category == "Seafood")
            //                   .Select(P => new { Name = P.ProductName , Category = P.Category
            //                   ,OldPrice = P.UnitPrice 
            //                   , NewPrice = P.UnitPrice - P.UnitPrice *0.1M});


            //Query Sytax



            //var result = from P in ListGenerator.ProductList
            //             where P.UnitsInStock > 0 && P.Category == "Seafood"
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.Category,
            //                 OldPrice = P.UnitPrice,
            //                 NewPrice = P.UnitPrice - P.UnitPrice * 0.1M
            //             };

            //var result = ListGenerator.CustomerList.Select(C => C.CustomerName); //If one of the property is sequence

            //var result = ListGenerator.CustomerList.SelectMany(C => C.Orders);

            //var result = from C in ListGenerator.CustomerList
            //             from O in C.Orders
            //             select O;

            //Indexed select Valid only in Flunet Syntax
            //Can't Be Written Using Query Suntax 
            //var result = ListGenerator.ProductList.Select((P, I) => new { I, P.ProductName })
            //        .Where(P => P.I < 5);

            #endregion


            #region  Ordering Operators


            // 3. Ordering Operators

            // Sorting

            //var result = ListGenerator.ProductList.OrderBy(P => P.UnitPrice).Select(P => new { P.ProductName, P.UnitPrice });

            //var result = ListGenerator.ProductList.OrderByDescending(P => P.UnitsInStock)
            //    .ThenBy(P=> P.UnitsInStock)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock

            //    });

            //var result = ListGenerator.ProductList
            //    .Where(P => P.Category == "Meat/Poutry")
            //    .OrderBy(P => P.UnitsInStock)
            //    .ThenByDescending(P => P.UnitPrice)
            //    .Select(P => new
            //    {
            //        P.ProductName,
            //        P.UnitPrice,
            //        P.UnitsInStock
            //    });

            //var result = from P in ListGenerator.ProductList
            //             where P.Category == "Meat/Poultry" && P.UnitsInStock > 0
            //             orderby P.UnitPrice , P.UnitsInStock descending
            //             select P;


            //var result = ListGenerator.ProductList.Reverse<Product>();

            #endregion


            #region Elements Operator - Immediate Execution 
            // 4. Elements Operator - Immediate Execution 

            //ListGenerator.ProductList = new List<Product>() { new Product() { ProductName = "Only one product" } };

            //var result = ListGenerator.ProductList.First(); // May throw exception

            //var result = ListGenerator.ProductList.Last();

            //var result = ListGenerator.ProductList.First(P => P.UnitsInStock == 0);


            //var result = ListGenerator.ProductList.FirstOrDefault(new Product() { ProductName = "Default Product" });

            //var result = ListGenerator.ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product() { ProductName = "Default Value" });
            //var result = ListGenerator.ProductList.LastOrDefault();



            //-------------------------------------------

            //var result = ListGenerator.ProductList.ElementAt(1);  //May Throw Exception

            //var result = ListGenerator.ProductList.ElementAtOrDefault(1);

            //var result = ListGenerator.ProductList.Single(); //May throw exception

            //var result = ListGenerator.ProductList.SingleOrDefault(); // May throw exception


            //Console.WriteLine(result?.ProductName ?? "NA");

            //var result =    ListGenerator.ProductList.SingleOrDefault(P => P.UnitsInStock == 1000);


            //var result = ListGenerator.ProductList.SingleOrDefault(P => P.UnitsInStock == 0 , new Product() { ProductName = "Default" });
            //Console.WriteLine(result);

            //Console.WriteLine(result?.ProductName ?? "NA");



            //ListGenerator.ProductList.DefaultIfEmpty();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region  Aggregate Operators - Immediate Exectuion
            // 5. Aggregate Operators - Immediate Exectuion

            // Count - Sum - Max - Min - Avg

            //var result = ListGenerator.ProductList.Count();

            //var result =  ListGenerator.ProductList.Count(P => P.UnitsInStock == 0);

            // Sum

            //var result = ListGenerator.ProductList.Sum(P => P.UnitPrice);

            //var result = ListGenerator.ProductList.Max();


            //var result = ListGenerator.ProductList.MinBy(P => P.UnitPrice);

            //List<string> Names = new List<string>() { "Nada", "Ahmed", "Mohamed" };
            //var result = Names.Aggregate((S01, S02) => $"{S01} , {S02}");


            //Console.WriteLine(result);
            #endregion


            #region Casting Operators - Immediate Execution

            // 6. Casting Operators - Immediate Execution

            //List<Product> list = (List<Product>) ListGenerator.ProductList.Where(P => P.UnitsInStock == 0); //Invlaid

            //List<Product> list = ListGenerator.ProductList.Where(P => P.UnitsInStock == 0).ToList();

            //foreach(var item in list)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Generation Operators
            // 7. Generation Operators

            //the only way to call this method as -> class member method through "Enumerable " Class

            // Range , Empty , Repeat

            //var result = Enumerable.Range(1, 100);

            //var result = Enumerable.Empty<Product>().ToList();

            //var result = Enumerable.Repeat(1, 30);

            #endregion


            #region Set Operators - Union Family

            // 8. Set Operators - Union Family
            //Union - Union All - intersect , except

            //var Seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100);

            ////var result = Seq01.Union(seq02); //without Duplication

            ////var result = Seq01.Concat(seq02); //With Duplication

            ////result = result.Distinct();
            //var result =   Seq01.Intersect(seq02);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item}");
            //}

            #endregion


            #region Quantifiers Operators - Return Boolean

            // 9. Quantifiers Operators - Return Boolean

            // Any - All - SequenceEqual - Contains

            //var Seq01 = Enumerable.Range(1, 100);

            //var Seq02 = Enumerable.Range(50, 100);

            //// Any() --> return true if there are at least one element [in sequence or match the conditions]

            ////var result = Seq01.Any(N => N %2 ==0);
            //ListGenerator.ProductList = new List<Product>();

            ////var result = ListGenerator.ProductList.Any();
            ////All() --> return true if all elements in the sequence match the conditions or sequence in empty

            ////var result = ListGenerator.ProductList.All(P => P.UnitsInStock == 0);

            //// SequenceEqual()

            //var result = Seq01.SequenceEqual(Seq02);

            //Console.WriteLine(result);

            #endregion


            #region Zipping Operators
            // 10.Zipping Operators
            //Zip
            #endregion




        }

    }
}
