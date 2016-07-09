using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeLib
{

    // 3. Create a class named Rectangle that inherits from Shape:
    public class Rectangle : Shape
    {
        // a. Create an appropriate constructor that accepts a width and
        //    height of the rectangle.
        private int width;
        private int height;

        public Rectangle() { }
        public Rectangle(int Wi, int He)
        {
            base.Display();
            width = Wi;
            height = He;
        }
        public Rectangle(int Wi, int He, ConsoleColor col)
        {
            base.Display(col);
            width = Wi;
            height = He;
        }

        public void GetDinmentions(int Wi, int He)
        {
            width = Wi;
            height = He;
        }

        public void GetDinmentions(int Wi, int He, ConsoleColor col)
        {
            base.Display(col);
            width = Wi;
            height = He;
        }
        // b. Add relevant properties.
        // c. Implement the abstract property inherited from Shape.
        // d. Override the Display method and implement by displaying the
        //    rectangle width and height. 

        public override void Display()
        {
            base.Display();
            Console.WriteLine("The rectangle's width is:\t{0}", width);
            Console.WriteLine("The rectangle's height is:\t{0}", height);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override void Display(ConsoleColor col)
        {
            base.Display(col);
            Console.WriteLine("The rectangle's width is:\t{0}", width);
            Console.WriteLine("The rectangle's height is:\t{0}", height);
            Console.ForegroundColor = ConsoleColor.White;
        }


        public override double Area
        {
            get { return (width * height); }
        }



    }

}
