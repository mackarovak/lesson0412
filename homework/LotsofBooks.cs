using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public delegate void DelegatSorted(int temp);
    class LotsofBooks
    {
        public Book[] books = new Book[] { new Book {Name="Idiot", Author="Dotoyevsky", Publisher="Kniga" },
            new Book {Name="Voina i mir", Author="Tolstoi", Publisher="Klassika"},
            new Book { Name = "Nyanya", Author = "Pushkin", Publisher = "Detskaya Literatura" }};
        public void SortingBooks(DelegatSorted deleg, int i)
        {
            deleg.Invoke(i);
        }
        public void Sort(int temp)
        {
            if (temp == 1)
            {
                Console.Write("По названию ");
                books = books.OrderBy(e => e.Name).ToArray();
            }
            else if (temp == 2)
            {
                Console.Write("По автору ");
                books = books.OrderBy(e => e.Author).ToArray();
            }
            else
            {
                Console.Write("По издательству ");
                books = books.OrderBy(e => e.Publisher).ToArray();
            }
            Console.WriteLine("отсортированныи массив");
            foreach (var item in books)
            {
                Console.WriteLine("Название - {0}, автор - {1}, издательство - {2}", item.Name, item.Author, item.Publisher);
            }
        }
    }
}
