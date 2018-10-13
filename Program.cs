using System;

namespace SampleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Books obj = new Books();
            do
            {
                Console.WriteLine("\n1. Add Book  2. List of Books     3. Find a Book By Author    4. Find a Book by Genre    5. Exit");
                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Book Name , Author , Genre , Publishing Year");
                        BookModel book = new BookModel();
                        book.BookName = Console.ReadLine();
                        book.Author = Console.ReadLine();
                        book.Genre = Console.ReadLine();
                        book.PublishingYear = Convert.ToInt32(Console.ReadLine());
                        obj.AddBook(book);
                        break;
                    case 2:
                        obj.GetListofBooks();
                        break;
                    case 3:
                        Console.WriteLine("Enter Author Name to Search");
                        string author = Console.ReadLine();
                        obj.SearchBookByAuthor(author);
                        break;
                    case 4:
                        Console.WriteLine("Enter Genre to Search");
                        string genre = Console.ReadLine();
                        obj.SearchBookByGenre(genre);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
            while (true);
        }
    }
}
