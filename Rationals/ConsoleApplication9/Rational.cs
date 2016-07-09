using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    public struct Rational
    {

        // a. Create a constructor that accepts two integers being the numerator and denominator.             
        private int Numerator;
        private int Denominator;

        public void SetValue(int numberNumerator, int numberDenominator)
        {
            try
            {
                int checkForDenominatorOfZero = (numberNumerator / numberDenominator) ;
                Numerator = numberNumerator;
                Denominator = numberDenominator;
            }
            catch
            {
                Console.WriteLine("Can not set Denominator of '0'");
            }
        }

        // b. Create another constructor that accepts a single integer. The denominator should be set to 1.
        public void SetValue(int integerNumber)  // Using for setting of a whole number
        {
            Numerator = integerNumber;
            Denominator = 1;
        }

        // c. Add properties that return the numerator and denominator.
        public int GetNumerator() { return Numerator; }
        public int GetDenominator() { return Denominator; }

        // d. Add a property that returns the value as a double.
        public double ConvertToDouble()
        {
            return Convert.ToDouble(Convert.ToDouble(Numerator) / Convert.ToDouble(Denominator));
        }

        // e. Add an Add method that adds two Rational objects. Make this method return a new Rational instance.
        public void Add(Rational ratio1, Rational ratio2)
        {
            Numerator = ratio1.GetNumerator() * ratio2.GetDenominator() + ratio2.GetNumerator() * ratio1.GetDenominator();
            Denominator = ratio1.GetDenominator() * ratio2.GetDenominator();
        }


        // f. Add a Mul method that multiplies Rational objects. Make this method return a new Rational instance.
        public void Mul(Rational ratio1, Rational ratio2)
        {
            Numerator = ratio1.GetNumerator() * ratio2.GetNumerator();
            Denominator = ratio1.GetDenominator() * ratio2.GetDenominator();
        }

        // g. (*) Add a Reduce method to simplify the Rational object. This method should return void.

        public void Simplify(Rational ratioA)
        {
            // Setting the numerator and the denominator
            Numerator = ratioA.GetNumerator();
            Denominator = ratioA.GetDenominator();

            // Get the minimal run time for simplify
            int small = Math.Min(ratioA.Numerator, ratioA.Denominator);

            for (int i = small; i >= 1; i--)
            {
                if ((Numerator % i == 0) && (Denominator % i == 0))
                {
                    Numerator = Numerator / i;
                    Denominator = Denominator / i;
                }
            }
        }
        // h. (*) Override ToString and Equals and provide appropriate implementations.

        // Override Equals (Compare the numerator and the denominator of both classes)
        public bool Equals(Rational ratio2)
        {
            // If parameter is null return false:
            if ((object)ratio2 == null)
            {
                return false;
            }
            // Return true if the fields match:
            return (Numerator == ratio2.Numerator) && (Denominator == ratio2.Denominator);
        }

        // Override ToString (To Define the display of the "Double" with 4 digits after the decimale point)
        public override string ToString()
        {
            int whole = (Convert.ToInt32((ConvertToDouble() * 10)) / 10);
            int decimale4Digits = Convert.ToInt32(((ConvertToDouble()) * 10000) % 10000);
            string RationString = "" + whole + "." + decimale4Digits;

            return RationString;
        }

        public string Display()
        {
            return (string.Format("{0} / {1}", Convert.ToInt32(this.Numerator), Convert.ToInt32(this.Denominator)));
        }



        /* -------------------------- Appendix: Operator Overloading -------------------------- */

        // 2. Add operators for +,-,*,/ for the Rational type. 
        // Override operator +:
        public static Rational operator+ (Rational ratio1, Rational ratio2)
        {
            Rational newRational = new Rational();
            // (a / b)+(c / d) -> (a * d + b * c)/(b * d)
            newRational.Numerator = ratio1.GetNumerator() * ratio2.GetDenominator() + ratio2.GetNumerator() * ratio1.GetDenominator();
            newRational.Denominator = ratio1.GetDenominator() * ratio2.GetDenominator();

            return (newRational);
        }

        // Override operator -:
        public static Rational operator -(Rational ratio1, Rational ratio2)
        {
            Rational newRational = new Rational();
            // (a / b)-(c / d) -> (a * d - b * c)/(b * d)
            newRational.Numerator = ratio1.GetNumerator() * ratio2.GetDenominator() - ratio2.GetNumerator() * ratio1.GetDenominator();
            newRational.Denominator = ratio1.GetDenominator() * ratio2.GetDenominator();

            return (newRational);
        }

        // Override operator *:
        public static Rational operator *(Rational ratio1, Rational ratio2)
        {
            Rational newRational = new Rational();
            // (a / b)*(c / d) -> (a * c)/(b * d)
            newRational.Numerator = ratio1.GetNumerator() * ratio2.GetNumerator();
            newRational.Denominator = ratio1.GetDenominator() * ratio2.GetDenominator();

            return (newRational);
        }

        // Override operator /:
        public static Rational operator /(Rational ratio1, Rational ratio2)
        {
            Rational newRational = new Rational();
            // (a / b)/(c / d) -> (a * d)/(b * c)
            // There is a need to check that 'c' is not equal to 0.

            try
            {
                int checkForDenominatorOfZero = ratio1.GetNumerator() / ratio2.GetNumerator();
                newRational.Numerator = ratio1.GetNumerator() * ratio2.GetDenominator();
                newRational.Denominator = ratio1.GetDenominator() * ratio2.GetNumerator();
            }
            catch
            {
                Console.WriteLine("Can not divide by '0'");
            }
            return (newRational);
        }

        // 3. Add casting operator to double and from an integer. 

        public static explicit operator double(Rational rationalNumber)
        {
            return rationalNumber.ConvertToDouble();
        }

        public static implicit operator Rational(int number)
        {
            Rational rational = new Rational();
            rational.SetValue(number);
            return rational;
        }

    }


}
