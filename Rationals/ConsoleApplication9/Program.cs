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

            Rational Ratio1 = new Rational(); // 1st manual rational
            Rational Ratio2 = new Rational(); // 2nd manual rational
            Rational Ratio3 = new Rational(); // 1st rational + 2nd rational
            Rational Ratio4 = new Rational(); // 1st rational * 2nd rational 
            Rational Ratio5 = new Rational(); // Simplification of Ration3
            Rational Ratio6 = new Rational(); // Simplification of Ration4

            Rational Ratio1Simp = new Rational(); // for the simplifyied 1st manual rational
            Rational Ratio2Simp = new Rational(); // for the simplifyied 2st manual rational

            // Using the basic SetValue
            Ratio1.SetValue(8, 22);
            Ratio2.SetValue(9, 16);
            // Using the Add method
            Ratio3.Add(Ratio1, Ratio2);
            // Using the Mul method
            Ratio4.Mul(Ratio1, Ratio2);
            // Simplifying
            Ratio1Simp.Simplify(Ratio1);
            Ratio2Simp.Simplify(Ratio2);
            Ratio5.Simplify(Ratio3);
            Ratio6.Simplify(Ratio4);
            
            // Display the results for the methods
            Console.WriteLine("c. Return the numerator and denominator:\n");
            // 1st manual rational 
            Console.WriteLine("First Rational Number:\n\tAS Rational:\t\t{0} / {1}", Ratio1.GetNumerator(), Ratio1.GetDenominator());
            Console.WriteLine("\tAs Double: \t\t{0}", ((Ratio1.ToString())));
            if (Ratio1.Equals(Ratio1Simp))
            { Console.WriteLine("This rational is already the simplified rational\n"); }
            else
            { Console.WriteLine("\tSimplifyied Ratio:\t{0} / {1}\n", Ratio1Simp.GetNumerator(), Ratio1Simp.GetDenominator()); }
            
            // 2nd manual rational
            Console.WriteLine("Second Rational Number:\t\t{0} / {1}", Ratio2.GetNumerator(), Ratio2.GetDenominator());
            Console.WriteLine("\tAs Double: \t\t{0}", ((Ratio2.ToString())));
            if (Ratio2.Equals(Ratio2Simp))
            { Console.WriteLine("This rational is already the simplified rational\n"); }
            else
            { Console.WriteLine("\tSimplifyied Ratio:\t{0} / {1}\n", Ratio2Simp.GetNumerator(), Ratio2Simp.GetDenominator()); }

            Console.WriteLine();
            Console.WriteLine("d. Returns the value as a double. :\n");
            
            Console.WriteLine("\t Return First Rational As Double :\t {0}",Ratio1.ConvertToDouble());
            Console.WriteLine("\t Return Second Rational As Double :\t {0}", Ratio2.ConvertToDouble());


            // 1st rational + 2nd rational
            Console.WriteLine();
            Console.WriteLine("e. Using the Add method:\n");
            Console.Write("Third rational number:\t{0} / {1}", Ratio3.GetNumerator(), Ratio3.GetDenominator());
            Console.WriteLine("\t (As double: {0})", (Ratio3.ToString()));

            if (Ratio3.Equals(Ratio5))
            { Console.WriteLine("This rational is already the simplified rational\n"); }
            else
            { Console.WriteLine("Simplifyied Ratio:\t{0} / {1}\n", Ratio5.GetNumerator(), Ratio5.GetDenominator()); }

            // 1st rational * 2nd rational 
            Console.WriteLine();
            Console.WriteLine("f. Using the Mul method :");
            Console.Write("Fourth rational number:\t{0} / {1}", Ratio4.GetNumerator(), Ratio4.GetDenominator());
            Console.WriteLine("\t (As double: {0})", ((Ratio4.ToString())));
            if (Ratio4.Equals(Ratio6))
            { Console.WriteLine("This rational is already the simplified rational\n"); }
            else
            { Console.WriteLine("Simplifyied Ratio:\t{0} / {1}\n", Ratio6.GetNumerator(), Ratio6.GetDenominator()); }

            // Implementation for b: Create another constructor that accepts a single integer. The denominator should be set to 1. 
            Rational WholeNumber = new Rational();
            WholeNumber.SetValue(16);
            Console.WriteLine("b. Whole Number Number (GetDenumer = 1):\n\tAS Rational:\t\t{0} / {1}", WholeNumber.GetNumerator(), WholeNumber.GetDenominator());
            Console.WriteLine("\tAs Double: \t\t{0}", ((WholeNumber.ToString())));


            Console.WriteLine("______________________________________________________________________________________________");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine("Appendix: Operator Overloading \n");

            Console.Write("Rational 1:\t{0} / {1}\t", Ratio1.GetNumerator(), Ratio1.GetDenominator());
            Console.WriteLine("\t;\t Rational 2:\t{0} / {1}\n", Ratio2.GetNumerator(), Ratio2.GetDenominator());

            Console.WriteLine("2. Override Operators  + , - , * , / \n");
            Rational RatioAppendix1 = Ratio1 + Ratio2;
            Rational RatioAppendix2 = Ratio1 - Ratio2;
            Rational RatioAppendix3 = Ratio1 * Ratio2;
            Rational RatioAppendix4 = Ratio1 / Ratio2;


            // Dispaly For the Implementation of Operator "+"
            Console.Write("Operator \"+\":\t{0} / {1}", RatioAppendix1.GetNumerator(), RatioAppendix1.GetDenominator());
            RatioAppendix1.Simplify(RatioAppendix1);
            Console.Write("\tSimplified:\t{0} / {1}", RatioAppendix1.GetNumerator(), RatioAppendix1.GetDenominator());
            Console.WriteLine("\t (As double: {0})", (RatioAppendix1.ToString()));
            
            // Dispaly For the Implementation of Operator "-"
            Console.Write("Operator \"-\":\t{0}", RatioAppendix2.Display());
            RatioAppendix2.Simplify(RatioAppendix2);
            Console.Write("\tSimplified:\t{0}", RatioAppendix2.Display());
            Console.WriteLine("\t (As double: {0})", (RatioAppendix2.ToString()));

            // Dispaly For the Implementation of Operator "*"
            Console.Write("Operator \"*\":\t{0}", RatioAppendix3.Display());
            RatioAppendix3.Simplify(RatioAppendix3);
            Console.Write("\tSimplified:\t{0}  ", RatioAppendix3.Display());
            Console.WriteLine("\t (As double: {0})", (RatioAppendix3.ToString()));

            // Dispaly For the Implementation of Operator "/"
            Console.Write("Operator \"/\":\t{0}", RatioAppendix4.Display());
            RatioAppendix4.Simplify(RatioAppendix4);
            Console.Write("\tSimplified:\t{0}  ", RatioAppendix4.Display());
            Console.WriteLine("\t (As double: {0})", (RatioAppendix4.ToString()));


            Console.WriteLine("\n3. Add casting operator to double and from an integer:");
            Console.WriteLine("Casting the rational number:\t{0}\t to double: {1}", Ratio2.Display(), (double)Ratio2);

            int ParameterForCusting = 9;
            Console.WriteLine("Casting the integer 9 to Rational number: \t{0}\t", ((Rational)ParameterForCusting).Display());


            Console.WriteLine("\n\nError Checking: Set Denominator of '0'");
            Rational WrongDenominator = new Rational();
             WrongDenominator.SetValue(4,0);
 

            Console.WriteLine("\n\nError Checking: avoid dividing by '0'");
            Rational WrongValue = new Rational();
            WrongValue.SetValue(0,15);
            Console.WriteLine("\tA:  First Number:\t{0}", Ratio1.Display());
            Console.WriteLine("\tB:  WrongValue:\t{0}", WrongValue.Display());

            Console.WriteLine("Check result for A / B:");
            WrongValue = Ratio1 / WrongValue;


            Console.ReadLine();
        }
    }
}