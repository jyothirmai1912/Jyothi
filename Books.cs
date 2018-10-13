using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    class Books
    {
        List<BookModel> bList = new List<BookModel>();

        public void AddBook(BookModel bModel)
        {

            bList.Add(bModel);
        }
        public void SearchBookByAuthor(string BookAuthor)
        {
            List<BookModel> books = bList.Where(s => s.Author == BookAuthor).ToList();
            if (books.Count == 0)
            {
                Console.WriteLine("Sorry No book found with this author name");
            }
            else
            {
                Console.WriteLine("List of Books with Author");
                foreach (var item in books)
                {
                    Console.WriteLine("\n {0} \t {1} \t {2} \t {3}", item.BookName, item.Author, item.Genre, item.PublishingYear);
                }
            }
        }
        public void SearchBookByGenre(string BookGenre)
        {
            List<BookModel> books = bList.Where(s => s.Genre == BookGenre).ToList();
            if (books.Count == 0)
            {
                Console.WriteLine("Sorry No book found with this Genre");
            }
            else
            {
                Console.WriteLine("List of Books with Genre");
                foreach (var item in books)
                {
                    Console.WriteLine("\n {0} \t {1} \t {2} \t {3}", item.BookName, item.Author, item.Genre, item.PublishingYear);
                }

            }
        }
        public void GetListofBooks()
        {
            if (bList.Count==0)
            {
                Console.WriteLine("No Books are available");
            }
            else
            {
                Console.WriteLine("List of Books");
                foreach (var item in bList)
                {
                    Console.WriteLine("\n {0} \t {1} \t {2} \t {3}", item.BookName, item.Author, item.Genre, item.PublishingYear);
                }
            }
        }
    }
}
