using static AssignmentLinq2.ListGenerator;
namespace AssignmentLinq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Restriction [Filteration] Operators



            #region Q1
            //var OutOfStock = ProductList.Where(P => P.UnitsInStock == 0);
            //foreach (var item in OutOfStock)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q2
            //var Products = ProductList.Where(P => P.UnitsInStock == 0).Where(P => P.UnitPrice > 3.00m);

            //foreach (var item in Products)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q3
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((name, index) => name.Length < index);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            //ELement Operators

            #region Q1

            //var OutOfStock = ProductList.First(P => P.UnitsInStock == 0);
            //Console.WriteLine(OutOfStock?.ProductName ?? "NA"); 
            #endregion


            #region Q2
            //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
            //Console.WriteLine(result?.ProductName ?? "NA"); 
            #endregion


            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result=Arr.Where(n => n > 5)
            //              .Skip(1)            
            //              .First();
            //Console.WriteLine(result); 
            #endregion



            //Aggregate Operators


            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var OddNumbersCount = Arr.Count(N => N % 2 == 1);
            //Console.WriteLine($"There is {OddNumbersCount} odd Numbers "); 
            #endregion

            #region Q2

            //var result =from C in CustomerList
            //            select new 
            //            {
            //               CustomerName=C.CustomerName,
            //               CustomerOrders=C.Orders.Count()
            //            }; 


            //foreach (var item in result)
            //{
            //    Console.WriteLine( item);
            //}
            #endregion




            #region Q3
            //var result = from P in ProductList
            //             select new
            //             {
            //                 CategoryName = P.Category,
            //                 ProductCount= P.Category.Count(),
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q4

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result =Arr.Count();
            //Console.WriteLine(result); 


            //string filePath = @"C:\Users\owner\source\repos\C#_Linq2\dictionary_english.txt"; 

            //try
            //{
            //string[] words = File.ReadAllLines(filePath);
            #endregion

            #region Q5

            //int totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine($"Total number of characters in all words: {totalCharacters}"); 
            #endregion

            #region Q6

            //int ShortestWord = words.Min(word => word.Length);
            //Console.WriteLine($"Length of the shortest word : {ShortestWord}"); 
            #endregion

            #region Q7

            //int LongestWord = words.Max(word => word.Length);
            //Console.WriteLine($"Length of the longest word : {LongestWord}"); 
            #endregion

            #region Q8

            //double AvgLength = words.Average(word => word.Length);
            //Console.WriteLine($"Average Length of words : {AvgLength}"); 

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");

            //}
            #endregion


            #region Q9

            //var result = from P in ProductList
            //             group P by P.Category into Group
            //               select  new
            //               {
            //                 CategoryName = Group.Key,
            //                 UnitsInStock = Group.Sum(P=>P.UnitsInStock)                      
            //               };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion
            #region Q10


            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 CheapestPriceInThisCategory = Group.Min(P=>P.UnitPrice)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q11

            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             let CheapestPriceInThisCategory = Group.Min(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 CheapestProduct = CheapestPriceInThisCategory
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q12

            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 MostExpensivePrice = Group.Max(P => P.UnitPrice)
            //             };
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q13

            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             let maxPrice = Group.Max(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 MostExpensiveProducts = Group.Where(P => P.UnitPrice == maxPrice).ToList()
            //             };
            //foreach (var Category in result)
            //{
            //    Console.WriteLine(Category.CategoryName);
            //    foreach (var item in Category.MostExpensiveProducts)
            //    {
            //        Console.WriteLine($"{item.ProductName} : {item.UnitPrice}");
            //    }
            //} 
            #endregion


            #region Q14
            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             let AvgPrice = Group.Average(P => P.UnitPrice)
            //             select new
            //             {
            //                 CategoryName = Group.Key,
            //                 AveragePrice = AvgPrice,
            //             };
            //foreach (var Category in result)
            //{
            //    Console.WriteLine($"Category Name : {Category.CategoryName} --> Average Price = {Category.AveragePrice:C}");
            //} 
            #endregion



            //Ordering Operators

            #region Q1

            //var result = ProductList.OrderBy(P => P.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr.OrderBy(w => w, new ComparerListCaseInsenstive()).ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q3
            //var result = from P in ProductList
            //             orderby P.UnitsInStock descending
            //             select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion



            #region Q4
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};


            //var result = Arr.OrderBy(A => A.Length)
            //                .ThenBy(A=>A)
            //                .ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion




            #region Q5

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(A => A.Length) 
            //                .ThenBy(A => A, StringComparer.OrdinalIgnoreCase) 
            //                .ToArray();

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Q6

            //var result  = from P in ProductList
            //              orderby P.Category , P.UnitPrice descending
            //              select P;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var result = Arr
            //    .OrderBy(A => A.Length)
            //    .ThenByDescending(A => A, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr
            //    .Where(A => A.Length > 1 && A[1] == 'i') 
            //    .Reverse() 
            //    .ToList(); 

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            // Transformation Operators


            #region Q1
            //var result = ProductList.Select(P => P.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(w => new
            //{
            //    Uppercase = w.ToUpper(),
            //    Lowercase = w.ToLower()
            //});


            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Uppercase: {item.Uppercase}, Lowercase: {item.Lowercase}");
            //}

            #endregion


            #region Q3
            //var result = from P in ProductList
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.ProductID,
            //                 P.Category,
            //                 Price = P.UnitPrice,
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((N,I)=> new { Number = N, Index = I, IsMatch = N == I });
            //Console.WriteLine("Number : In-Place?");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Number}: {item.IsMatch}");
            //} 
            #endregion


            #region Q5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a, B = b }; 


            //Console.WriteLine("Pairs where a < b :");

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}
            #endregion

            #region Q6

            //var result = from C in CustomerList
            //             from O in C.Orders
            //             where O.Total > 500
            //             select O;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item}");
            //} 
            #endregion

            #region Q7

            //var result = from C in CustomerList
            //             from O in C.Orders
            //             where O.OrderDate >= new DateTime(1998, 1, 1)
            //             select O;
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item}");
            //} 
            #endregion



            //Set Operators


            #region Q1
            //var result = ProductList.Select(P=>P.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Q2

            //var ProductUnique = ProductList.Select(P => P.ProductName[0]);
            //var CustomerUnique = CustomerList.Select(C => C.CustomerName[0]);

            //var BothUnique = ProductUnique.Union(CustomerUnique).Distinct();
            //foreach (var item in BothUnique)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q3
            //var ProductFirst = ProductList.Select(P => P.ProductName[0]);
            //var CustomerFirst = CustomerList.Select(C => C.CustomerName[0]);

            //var Intersection = ProductFirst.Intersect(CustomerFirst)=;
            //foreach (var item in Intersection)
            //{
            //    Console.WriteLine(item);

            #endregion


            #region Q4
            //var ProductFirst = ProductList.Select(P => P.ProductName[0]);
            //var CustomerFirst = CustomerList.Select(C => C.CustomerName[0]);

            //var Except = ProductFirst.Except(CustomerFirst);
            //foreach (var item in Except)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion



            #region Q5
            //var productLastThreeChars = ProductList .Select(P => new string(P.ProductName.TakeLast(3).ToArray()));
            //var customerLastThreeChars = CustomerList .Select(C => new string(C.CustomerName.TakeLast(3).ToArray()));

            //var Concat = productLastThreeChars.Concat(customerLastThreeChars);
            //foreach (var item in Concat)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion



            //Partitioning Operators


            #region Q1
            //var result = (from C in CustomerList
            //              where C.Address == "Washington"
            //              from O in C.Orders
            //              select O).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion


            #region Q2
            //var result = (from C in CustomerList
            //              where C.Address == "Washington"
            //              from O in C.Orders
            //              select O).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((number, index) => number >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion


            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(N => N % 3 == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Q5
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((number, index) => number >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion



            //Quantifiers Operators


            #region Q1
            //string filePath = @"C:\Users\owner\source\repos\C#_Linq2\dictionary_english.txt";

            //try
            //{
            //    string[] words = File.ReadAllLines(filePath);

            //    var contains = words.Contains("ei");
            //    Console.WriteLine($"Contains substring [ei] ? : {contains}");

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine($"An error occurred: {ex.Message}");

            //}
            #endregion

            #region Q2

            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             where Group.Any(P => P.UnitsInStock == 0)
            //             select new
            //             {
            //                 Category = Group.Key,
            //                 Products = Group
            //             };


            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);
            //    foreach (var item in group.Products)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            #endregion


            #region Q3

            //var result = from P in ProductList
            //             group P by P.Category into Group
            //             where Group.All(P => P.UnitsInStock > 0)
            //             select new
            //             {
            //                 Category = Group.Key,
            //                 Products = Group
            //             };

            //foreach (var group in result)
            //{
            //    Console.WriteLine(group.Category);
            //    foreach (var item in group.Products)
            //    {
            //        Console.WriteLine(item);
            //    }
            //} 
            #endregion


            //Grouping Operators

            #region Q1

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(n => n % 5);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {item.Key} when divided by 5:");
            //    foreach (var number in item)
            //    {
            //        Console.WriteLine($"{number} ");
            //    }
            //} 
            #endregion


            #region Q2
            //string filePath = @"C:\Users\owner\source\repos\C#_Linq2\dictionary_english.txt";
            //string[] words = File.ReadAllLines(filePath);

            //var result = words.Where(word => !string.IsNullOrWhiteSpace(word)) 
            //                  .GroupBy(word => char.ToUpper(word[0])) 
            //                  .OrderBy(group => group.Key);
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Words that start with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.Write($"{word} ");
            //    }
            //} 
            #endregion


            #region Q3
            //string[] Arr = { "from", "salt", "earn", " last", "near", "form" };
            //var result = Arr.Select(word => word.Trim()) 
            //                .GroupBy(word => new string(word.OrderBy(c => c).ToArray())) 
            //                .ToList();
            //foreach (var group in result)
            //{

            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"{word} ");
            //    }

            //} 
            #endregion

        }
    }
}
