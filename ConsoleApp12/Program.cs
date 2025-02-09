using System;
using System.Collections.Generic;
#region Q2

//public class Book
//{
//    public string Title { get; set; }
//    public string Author { get; set; }
//    public string ISBN { get; set; }
//    public DateTime PublicationDate { get; set; }
//    public Book(string title, string author, string isbn, DateTime publicationDate)
//    {
//        Title = title;
//        Author = author;
//        ISBN = isbn;
//        PublicationDate = publicationDate;
//    }
//}
//public class BookFunctions
//{
//    public static string GetTitle(Book book) => book.Title;
//    public static string GetAuthor(Book book) => book.Author;
//    public static string GetISBN(Book book) => book.ISBN;
//    public static DateTime GetPublicationDate(Book book) => book.PublicationDate;
//}
//public class LibraryEngine
//{
//    public delegate string BookDelegate(Book book);

//    public static void ProcessBooks(List<Book> blist, BookDelegate fPtr)
//    {
//        foreach (Book B in blist)
//        {
//            Console.WriteLine(fPtr(B));
//        }
//    }
//    public static void ProcessBooks(List<Book> blist, Func<Book, string> fPtr)
//    {
//        foreach (Book B in blist)
//        {
//            Console.WriteLine(fPtr(B));
//        }
//    }
//    public static void Main()
//    {
//        List<Book> books = new List<Book>
//        {
//            new Book("gorggg", "georgeee", "01280807713", new DateTime(2003, 12, 16)),
//            new Book("zamalek", "George ", "1911", new DateTime(1911, 6, 8))
//        };

//        LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunctions.GetTitle));

//        LibraryEngine.ProcessBooks(books, new Func<Book, string>(BookFunctions.GetAuthor));

//        ProcessBooks(books, new Func<Book, string>(delegate (Book book) { return book.ISBN; }));

//        ProcessBooks(books, new Func<Book, string>(book => book.PublicationDate.ToString()));
//    }
//}

#endregion
#region Q3

class mylist<T>
{   public List<T> list = new List<T>();
    public bool Exists(Predicate<T> match)
    {
        foreach (T item in list)
        {
            if (match(item))
                return true;
        }
        return false;
    }
    public void Add (T item)
        { list.Add(item); }
    public T Find(Predicate<T> match)
    {
        foreach (T item in list)
        {
            if (match(item))
                return item;
        }
        return default(T); }
    public List<T> FindAll(Predicate<T> match)
    {
        List<T> result = new List<T>();
        foreach (T item in list)
        {
            if (match(item))
                result.Add(item);
        }
        return result;
    }
    public int FindIndex(Predicate<T> match)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (match(list[i]))
                return i;
        }
        return -1;
    }
    public T FindLast(Predicate<T> match)
    {
        for (int i = list.Count - 1; i >= 0; i--)
        {
            if (match(list[i]))
                return list[i];
        }
        return default(T);
    }
}

public class Program
{
    public static void Main()
    {
        mylist<int> list = new mylist<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
    

        Console.WriteLine(list.Exists(x => x > 3)); 
        Console.WriteLine(list.Find(x=>x>3));
        List<int> foundItems = list.FindAll(x => x > 3);
        foreach (var item in foundItems)
        {
            Console.WriteLine(item); 
        }
        Console.WriteLine(list.FindIndex(x => x > 3));
        Console.WriteLine(list.FindLast(x=>x>1));
    }
}
#endregion









