using Assignment;
using System;
using System.Collections.Generic;

public delegate string BookFunctionDelegate(Book B);

public class LibraryEngine
{


    public static void ProcessBooks(List<Book> blist, Func<Book, string> fPtr)
    {
        foreach (Book B in blist)
        {
            Console.WriteLine(fPtr(B));
        }
    }

  
    public static void ProcessBooksWithAnonymousMethod(List<Book> blist)
    {
        Func<Book, string> getISBN = delegate (Book B) { return B.ISBN; };
        ProcessBooks(blist, getISBN);
    }


    public static void ProcessBooksWithLambda(List<Book> blist)
    {
        Func<Book, string> getPublicationDate = B => B.PublicationDate.ToShortDateString();
        ProcessBooks(blist, getPublicationDate);
    }

}