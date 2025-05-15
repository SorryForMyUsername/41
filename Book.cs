using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _41_2
{
    class Book
    {
        string title;
        string author;
        string publisher;

        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public string Publisher { get => publisher; set => publisher = value; }

        public Book(string title, string author, string publisher)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
        }

        public static Book InputBook()
        {
            Console.Write("Название: ");
            string title = Console.ReadLine();
            Console.Write("Автор: ");
            string author = Console.ReadLine();
            Console.Write("Издательство: ");
            string publisher = Console.ReadLine();
            return new Book(title, author, publisher);
        }

        public override string ToString()
        {
            return $"Название: {Title}\n" +
                $"Автор: {Author}\n" +
                $"Издательство: {Publisher}";
        }
    }
}
