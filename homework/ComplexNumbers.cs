using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class ComplexNumbers
    {
        public double r, i;
        public ComplexNumbers(double r,double i)
        {
            this.r = r;
            this.i = i;
        }
        public static ComplexNumbers Complex(double r, double i)
        {
            return new ComplexNumbers(r, i);
        }
        public override string ToString()
        {
            if (i == 0) return $"{r}";
            else if (i > 0) return $"{ r} +{ i}i";
            else if (i < 0) return $"{r}- {i}i";
            else return $"{i}i"; 
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static ComplexNumbers operator+(ComplexNumbers complexNumbers1,ComplexNumbers complexNumbers2)
        {
            return new ComplexNumbers(complexNumbers1.r + complexNumbers2.r, complexNumbers2.i + complexNumbers1.i);
        }
    }
}
