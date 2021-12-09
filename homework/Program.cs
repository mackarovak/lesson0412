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
            ComplexNumbers complexNumbers1 = new ComplexNumbers(2, 3);
            ComplexNumbers complexNumbers2 = new ComplexNumbers(3, 5);
            Console.WriteLine(complexNumbers1 + complexNumbers2);
            Console.WriteLine(complexNumbers1 - complexNumbers2);

            Console.WriteLine("Домашнее задание 12.2");
            LotsofBooks lostofBooks = new LotsofBooks();
            lostofBooks.SortingBooks(new DelegatSorted(lostofBooks.Sort), 1);
            lostofBooks.SortingBooks(new DelegatSorted(lostofBooks.Sort), 2);
            lostofBooks.SortingBooks(new DelegatSorted(lostofBooks.Sort), 3);
            Console.ReadKey();
        }
    }
}
