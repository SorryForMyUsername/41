using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41_2
{
    class Library
    {
        List<Book> books = new List<Book>();

        public void SortBooks(Comparison<Book> comparison)
        {
            books.Sort(comparison);
        }

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void OutputBooks()
        {
            Console.WriteLine("Вывод книг:");
            foreach (Book book in books)
            {
                Console.WriteLine($"{book}\n");
            }
        }
    }
}
