using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication9
{
    abstract class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Lab 3.2: Creating Value Types:");

            // Create some Rational objects, initialize with some values,
            // and test the code you created to make sure all methods work as expected.

            Rational ratio1 = new Rational(); // 1st manual rational
            Rational ratio2 = new Rational(); // 2nd manual rational
            Rational ratio3 = new Rational(); // 1st rational + 2nd rational
            Rational ratio4 = new Rational(); // 1st rational * 2nd rational 
            Rational ratio5 = new Rational(); // Simplification of Ration3
            Rational ratio6 = new Rational(); // Simplification of Ration4

            Rational ratio1Simp = new Rational(); // for the simplifyied 1st manual rational
            Rational ratio2Simp = new Rational(); // for the simplifyied 2st manual rational

            // Using the basic SetValue
            ratio1.SetValue(8, 22);
            ratio2.SetValue(9, 16);
            // Using the Add method
            ratio3.Add(ratio1, ratio2);
            // Using the Mul method
            ratio4.Mul(ratio1, ratio2);
            // Simplifying
            ratio1Simp.Simplify(ratio1);
            ratio2Simp.Simplify(ratio2);
            ratio5.Simplify(ratio3);
            ratio6.Simplify(ratio4);
            
            // Display the results for the methods
            Console.WriteLine("c. Return the numerator and denominator:\n");
            // 1st manual rational 
            Console.WriteLine("First Rational Number:\n\tAS Rational:\t\t{0} / {1}", ratio1.GetNumerator(), ratio1.GetDenominator());
            Console.WriteLine("\tAs Double: \t\t{0}", ((ratio1.ToString())));
            if (ratio1.Equals(ratio1Simp))
            { Console.WriteLine("This rational is already the simplified rational\n"); }
            else
            { Console.WriteLine("\tSimplifyied Ratio:\t{0} / {1}\n", ratio1Simp.GetNumerator(), ratio1Simp.GetDenominator()); }
            
            // 2nd manual rational
            Console.WriteLine("Second Rational Number:\t\t{0} / {1}", ratio2.GetNumerator(), ratio2.GetDenominator());
            Console.WriteLine("\tAs Double: \t\t{0}", ((ratio2.ToString())));
            if (ratio2.Equals(ratio2Simp))
            { Console.WriteLine("This rational is already the simplified rational\n"); }
            else
            { Console.WriteLine("\tSimplifyied Ratio:\t{0} / {1}\n", ratio2Simp.GetNumerator(), ratio2Simp.GetDenominator()); }

            Console.WriteLine();
            Console.WriteLine("d. Returns the value as a double. :\n");
            
            Console.WriteLine("\t Return First Rational As Double :\t {0}",ratio1.ConvertToDouble());
            Console.WriteLine("\t Return Second Rational As Double :\t {0}", ratio2.ConvertToDouble());


            // 1st rational + 2nd rational
            Console.WriteLine();
            Console.WriteLine("e. Using the Add method:\n");
            Console.Write("Third rational number:\t{0} / {1}", ratio3.GetNumerator(), ratio3.GetDenominator());
            Console.WriteLine("\t (As double: {0})", (ratio3.ToString()));

            if (ratio3.Equals(ratio5))
            { Console.WriteLine("This rational is already the simplified rational\n"); }
            else
            { Console.WriteLine("Simplifyied Ratio:\t{0} / {1}\n", ratio5.GetNumerator(), ratio5.GetDenominator()); }

            // 1st rational * 2nd rational 
            Console.WriteLine();
            Console.WriteLine("f. Using the Mul method :");
            Console.Write("Fourth rational number:\t{0} / {1}", ratio4.GetNumerator(), ratio4.GetDenominator());
            Console.WriteLine("\t (As double: {0})", ((ratio4.ToString())));
            if (ratio4.Equals(ratio6))
            { Console.WriteLine("This rational is already the simplified rational\n"); }
            else
            { Console.WriteLine("Simplifyied Ratio:\t{0} / {1}\n", ratio6.GetNumerator(), ratio6.GetDenominator()); }

            // Implementation for b: Create another constructor that accepts a single integer. The denominator should be set to 1. 
            Rational WholeNumber = new Rational();
            WholeNumber.SetValue(16);
            Console.WriteLine("b. Whole Number Number (GetDenumer = 1):\n\tAS Rational:\t\t{0} / {1}", WholeNumber.GetNumerator(), WholeNumber.GetDenominator());
            Console.WriteLine("\tAs Double: \t\t{0}", ((WholeNumber.ToString())));


            Console.WriteLine("______________________________________________________________________________________________");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Appendix: Operator Overloading \n");

            Console.Write("Rational 1:\t{0} / {1}\t", ratio1.GetNumerator(), ratio1.GetDenominator());
            Console.WriteLine("\t;\t Rational 2:\t{0} / {1}\n", ratio2.GetNumerator(), ratio2.GetDenominator());

            Console.WriteLine("2. Override Operators  + , - , * , / \n");
            Rational ratioAppendix1 = ratio1 + ratio2;
            Rational ratioAppendix2 = ratio1 - ratio2;
            Rational ratioAppendix3 = ratio1 * ratio2;
            Rational ratioAppendix4 = ratio1 / ratio2;


            // Dispaly For the Implementation of Operator "+"
            Console.Write("Operator \"+\":\t{0} / {1}", ratioAppendix1.GetNumerator(), ratioAppendix1.GetDenominator());
            ratioAppendix1.Simplify(ratioAppendix1);
            Console.Write("\tSimplified:\t{0} / {1}", ratioAppendix1.GetNumerator(), ratioAppendix1.GetDenominator());
            Console.WriteLine("\t (As double: {0})", (ratioAppendix1.ToString()));
            
            // Dispaly For the Implementation of Operator "-"
            Console.Write("Operator \"-\":\t{0}", ratioAppendix2.Display());
            ratioAppendix2.Simplify(ratioAppendix2);
            Console.Write("\tSimplified:\t{0}", ratioAppendix2.Display());
            Console.WriteLine("\t (As double: {0})", (ratioAppendix2.ToString()));

            // Dispaly For the Implementation of Operator "*"
            Console.Write("Operator \"*\":\t{0}", ratioAppendix3.Display());
            ratioAppendix3.Simplify(ratioAppendix3);
            Console.Write("\tSimplified:\t{0}  ", ratioAppendix3.Display());
            Console.WriteLine("\t (As double: {0})", (ratioAppendix3.ToString()));

            // Dispaly For the Implementation of Operator "/"
            Console.Write("Operator \"/\":\t{0}", ratioAppendix4.Display());
            ratioAppendix4.Simplify(ratioAppendix4);
            Console.Write("\tSimplified:\t{0}  ", ratioAppendix4.Display());
            Console.WriteLine("\t (As double: {0})", (ratioAppendix4.ToString()));


            Console.WriteLine("\n3. Add casting operator to double and from an integer:");
            Console.WriteLine("Casting the rational number:\t{0}\t to double: {1}", ratio2.Display(), (double)ratio2);

            Console.WriteLine("Casting the integer 16 to Rational number: \t{0}\t", ((Rational)16).Display());


            Console.WriteLine("\n\nError Checking: Set Denominator of '0'");
            Rational wrongDenominator = new Rational();
             wrongDenominator.SetValue(4,0);
 

            Console.WriteLine("\n\nError Checking: avoid dividing by '0'");
            Rational wrongValue = new Rational();
            wrongValue.SetValue(0,15);
            Console.WriteLine("\tA:  First Number:\t{0}", ratio1.Display());
            Console.WriteLine("\tB:  WrongValue:\t{0}", wrongValue.Display());

            Console.WriteLine("Check result for A / B:");
            wrongValue = ratio1 / wrongValue;


            Console.ReadLine();
        }
    }
}