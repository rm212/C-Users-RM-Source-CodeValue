using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeLib
{
    // 4. Create an Ellipse class inheriting from Shape and implement as appropriate.
    public class Ellipse : Shape
    {
        private int R1;
        private int R2;

        public Ellipse() { }
        public Ellipse(int Wi, int He)
        {
            R1 = Wi;
            R2 = He;
        }

        public void GetDinmentions(int Wi, int He)
        {
            R1 = Wi;
            R2 = He;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("The ellipse's first radius is:\t{0}", R1);
            Console.WriteLine("The ellipse's second radius is:\t{0}", R2);
        }

        public override void Display(ConsoleColor col)
        {
            base.Display(col);
            Console.WriteLine("The ellipse's first radius is:\t{0}", R1);
            Console.WriteLine("The ellipse's second radius is:\t{0}", R2);
        }

        public override double Area
        {
            get { return (R1 * R2 * Math.PI); }
        }
    }

}
