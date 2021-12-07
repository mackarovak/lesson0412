using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson0412
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 12.2");
            var rationalNumbers1 = new RationalNumbers(5, 4);
            var rationalNumbers2 = new RationalNumbers(1, 2);
            Console.WriteLine(-rationalNumbers2);  
            Console.WriteLine(rationalNumbers1+rationalNumbers2); 
            Console.WriteLine(rationalNumbers1-rationalNumbers2);  
            Console.WriteLine(rationalNumbers1*rationalNumbers2); 
            Console.WriteLine(rationalNumbers1/rationalNumbers2);
            Console.ReadKey();
        }
    }
}
