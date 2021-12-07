using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Домашнее задание 12.1");

            Console.WriteLine("Домашнее задание 12.2");
            LotsofBooks lostofBooks = new LotsofBooks();
            lostofBooks.SortingBooks(new DelegatSorted(lostofBooks.Sort), 1);
            lostofBooks.SortingBooks(new DelegatSorted(lostofBooks.Sort), 2);
            lostofBooks.SortingBooks(new DelegatSorted(lostofBooks.Sort), 3);
            Console.ReadKey();
        }
    }
}
