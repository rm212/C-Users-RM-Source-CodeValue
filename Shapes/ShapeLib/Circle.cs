using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeLib
{
    // 5. Create a Circle class inheriting from Ellipse and implement as appropriate.
    public class Circle : Ellipse
    {
        private int R1;
        public void GetDinmentions(int Rad)
        { R1 = Rad; }

        public override void Display()
        {
            //Console.ForegroundColor = col;
            Console.WriteLine("The circle's first radius is:\t{0}", R1);
        }

        public override double Area
        {
            get { return (R1 * R1 * Math.PI); }
        }
    }
}
