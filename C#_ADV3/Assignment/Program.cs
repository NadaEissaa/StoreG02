namespace Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Q1

            List<Book> books = new List<Book>
        {
            new Book("123-456", "C# Programming", new string[] { "Nada Eissa", "Ganna Ehab" }, new DateTime(2020, 1, 1), 29.99m),
            new Book("654-321", "Advanced C#", new string[] { "Mariam Ellithy" }, new DateTime(2021, 5, 15), 49.99m)
        };

           
            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

          
            LibraryEngine.ProcessBooks(books, BookFunctions.GetAuthors);

            
            LibraryEngine.ProcessBooksWithAnonymousMethod(books);

            LibraryEngine.ProcessBooksWithLambda(books);
            #endregion

            #region Q2
          
            MyList<int> myList = new MyList<int>();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(2); 

      
            Console.WriteLine("Exists(x => x == 2): " + myList.Exists(x => x == 2)); 
            Console.WriteLine("Exists(x => x == 10): " + myList.Exists(x => x == 10)); 

   
            Console.WriteLine("Find(x => x == 3): " + myList.Find(x => x == 3)); 
            Console.WriteLine("Find(x => x == 10): " + myList.Find(x => x == 10)); 

            List<int> allTwos = myList.FindAll(x => x == 2);
            Console.WriteLine("FindAll(x => x == 2): " + string.Join(", ", allTwos)); 

          
            int index = myList.FindIndex(x => x == 4);
            Console.WriteLine("FindIndex(x => x == 4): " + index); 

        
            int lastTwo = myList.FindLast(x => x == 2);
            Console.WriteLine("FindLast(x => x == 2): " + lastTwo); 

          
            int lastIndex = myList.FindLastIndex(x => x == 2);
            Console.WriteLine("FindLastIndex(x => x == 2): " + lastIndex); 

            
            Console.Write("ForEach (Printing all elements): ");
            myList.ForEach(x => Console.Write(x + " ")); 
            Console.WriteLine();

           
            Console.WriteLine("TrueForAll(x => x > 0): " + myList.TrueForAll(x => x > 0)); 
            Console.WriteLine("TrueForAll(x => x > 3): " + myList.TrueForAll(x => x > 3)); 
            #endregion
        }
    }
}
