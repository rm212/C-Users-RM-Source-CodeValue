using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeLib
{
    public abstract class Shape
    {
        // 2. Create an abstract class named Shape.
        // The class should have the following members: 
        // a. A Color property of type ConsoleColor.
        // b. A constructor accepting a color and setting the color.
        // c. A default constructor that uses a white color.
        private ConsoleColor ShapeColor;
        public ConsoleColor ColorSetting
        {
            get { return ShapeColor; }
        }

        public Shape(ConsoleColor color) { ShapeColor = color; }
        public Shape() { ShapeColor = ConsoleColor.White; }


        // d. A virtual Display method that changes the current console
        //    color to the Color property value.
        public virtual void Display() { Console.ForegroundColor = ShapeColor; }
        public virtual void Display(ConsoleColor ShapeCol) { Console.ForegroundColor = ShapeCol; }



        // e. An abstract read only property named Area.

        public abstract double Area
        { get; }

    }
}
