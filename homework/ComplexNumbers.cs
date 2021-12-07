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
            else return $"{r}- {i}i";
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static bool operator ==(ComplexNumbers complexNumbers1, ComplexNumbers complexNumbers2)
        {
            return complexNumbers1.r==complexNumbers2.r && complexNumbers2.i==complexNumbers1.i;
        }
        public static bool operator !=(ComplexNumbers complexNumbers1, ComplexNumbers complexNumbers2)
        {
            return !(complexNumbers1.r == complexNumbers2.r && complexNumbers2.i == complexNumbers1.i);
        }
        public static ComplexNumbers operator+(ComplexNumbers complexNumbers1,ComplexNumbers complexNumbers2)
        {
            return new ComplexNumbers(complexNumbers1.r + complexNumbers2.r, complexNumbers2.i + complexNumbers1.i);
        }
        public static ComplexNumbers operator -(ComplexNumbers complexNumbers1, ComplexNumbers complexNumbers2)
        {
            return new ComplexNumbers(complexNumbers1.r - complexNumbers2.r, complexNumbers1.i - complexNumbers2.i);
        }
        public static ComplexNumbers operator *(ComplexNumbers complexNumbers1, ComplexNumbers complexNumbers2)
        {
            return new ComplexNumbers(complexNumbers1.r*complexNumbers2.r - complexNumbers1.i*complexNumbers2.i, complexNumbers1.r*complexNumbers2.i + complexNumbers2.r*complexNumbers1.i);
        }
        public override bool Equals(object obj)
        {
            double number;
            if (obj is ComplexNumbers)
            {
                return r == (obj as ComplexNumbers).r && i == (obj as ComplexNumbers).i;
            }
            else if (i == 0 && double.TryParse(obj.ToString(), out number))
            {
                return r == number;
            }
            else
            {
                return false;
            }
        }
    }
}
