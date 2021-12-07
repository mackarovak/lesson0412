using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson0412
{
    class RationalNumbers
    {
        public int Numerator { get; set; }
        public int Denominator { get; set; }

        public override string ToString()
        {
            return $"{Numerator}/{Denominator}";
        } 
        public RationalNumbers()
        {
            Numerator = 0;
            Denominator = 1;
        }
        public RationalNumbers(int Numerator,int Denominator)
        {
            if (Denominator == 0)
            {
                throw new Exception("Такой дроби не существует");

            }
            else
            {
                this.Denominator = Denominator;
                this.Numerator = Numerator;
            }
        }
        public static bool operator ==(RationalNumbers rationalNumbers1,RationalNumbers rationalNumbers2)
        {
            return rationalNumbers1.Numerator == rationalNumbers2.Numerator && rationalNumbers1.Denominator == rationalNumbers2.Denominator;
        }
        public static bool operator !=(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2)
        {
            return !(rationalNumbers1.Numerator == rationalNumbers2.Numerator && rationalNumbers1.Denominator == rationalNumbers2.Denominator);
        }
        public override bool Equals(object obj)
        {
            decimal number;
            if (decimal.TryParse(obj.ToString(),out number))
            {
                return Convert.ToDecimal(Numerator) / Denominator == number;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static RationalNumbers operator+(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2) =>
            new RationalNumbers(rationalNumbers1.Numerator*rationalNumbers2.Denominator+rationalNumbers2.Numerator*rationalNumbers1.Denominator,rationalNumbers1.Denominator*rationalNumbers2.Denominator);
        public static RationalNumbers operator -(RationalNumbers rationalNumbers2) => new RationalNumbers(-rationalNumbers2.Numerator, rationalNumbers2.Denominator);
        public static RationalNumbers operator-(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2)
        {
            return rationalNumbers1+ (-rationalNumbers2);
        }
        public static bool operator <(RationalNumbers rationalNumbers1,RationalNumbers rationalNumbers2)
        {
            return rationalNumbers1.Numerator*rationalNumbers2.Denominator<rationalNumbers1.Denominator*rationalNumbers2.Numerator;
        }
        public static bool operator >(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2)
        {
            return rationalNumbers1.Numerator * rationalNumbers2.Denominator > rationalNumbers1.Denominator * rationalNumbers2.Numerator; ;
        }
        public static bool operator <=(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2)
        {
            return rationalNumbers1.Numerator * rationalNumbers2.Denominator <= rationalNumbers1.Denominator * rationalNumbers2.Numerator; ;
        }
        public static bool operator >=(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2)
        {
            return rationalNumbers1.Numerator * rationalNumbers2.Denominator >= rationalNumbers1.Denominator * rationalNumbers2.Numerator; ;
        }
        public static RationalNumbers operator ++(RationalNumbers rationalNumbers)
        {
            return new RationalNumbers(rationalNumbers.Numerator + rationalNumbers.Denominator, rationalNumbers.Denominator);
        }
        public static RationalNumbers operator --(RationalNumbers rationalNumbers)
        {
            return new RationalNumbers(rationalNumbers.Numerator - rationalNumbers.Denominator, rationalNumbers.Denominator);
        }
        public static RationalNumbers operator *(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2)
        => new RationalNumbers(rationalNumbers1.Numerator*rationalNumbers2.Numerator, rationalNumbers2.Denominator*rationalNumbers2.Denominator);
        public static RationalNumbers operator /(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2)
        {
            if (rationalNumbers2.Denominator== 0)
            {
                throw new DivideByZeroException();
            }
            return new RationalNumbers(rationalNumbers1.Numerator * rationalNumbers2.Denominator, rationalNumbers1.Denominator * rationalNumbers2.Numerator);
        }
        public static RationalNumbers operator %(RationalNumbers rationalNumbers1, RationalNumbers rationalNumbers2)
       => rationalNumbers1 - (RationalNumbers)(rationalNumbers1 / rationalNumbers2) * rationalNumbers2;
        public static explicit operator int (RationalNumbers rationalNumbers)
        {
            return rationalNumbers.Numerator / rationalNumbers.Denominator;
        }
        public static explicit operator float(RationalNumbers rationalNumbers)
        {
            return Convert.ToSingle(rationalNumbers.Numerator)/ rationalNumbers.Denominator;
        }
        public static explicit operator RationalNumbers(int rationalNumbers)
        {
            return new RationalNumbers(rationalNumbers, 1);
        }

    }
}
