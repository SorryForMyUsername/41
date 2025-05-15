using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _41_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            while (true)
            {
                Console.WriteLine("Выберите действие:\n" +
                    "1. Добавить книгу\n" +
                    "2. Сортировать книги по названию\n" +
                    "3. Сортировать книги по автору\n" +
                    "4. Сортировать книги по издательству\n" +
                    "5. Вывести книги\n" +
                    "6. Выход\n");

                int choice = Console.ReadKey(true).KeyChar - '0';
                switch (choice)
                {
                    case 1: library.AddBook(Book.InputBook()); break;
                    case 2: library.SortBooks(SortByTitle); break;
                    case 3: library.SortBooks(SortByAuthor); break;
                    case 4: library.SortBooks(SortByPublisher); break;
                    case 5: library.OutputBooks(); break;
                    case 6: return;
                }
                Console.WriteLine();
            }
        }

        public static int SortByTitle(Book book1, Book book2)
        {
            return book1.Title.CompareTo(book2.Title);
        }

        public static int SortByAuthor(Book book1, Book book2)
        {
            return book1.Author.CompareTo(book2.Author);
        }

        public static int SortByPublisher(Book book1, Book book2)
        {
            return book1.Publisher.CompareTo(book2.Publisher);
        }
    }
}
