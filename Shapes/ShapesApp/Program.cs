using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ShapeLib;

namespace ShapesApp
{
    // 6. Add a new console application project to the solution, named ShapesApp.
    // 7. Add a reference to the ShapesLib project you just created.
    // 8. Create a class named ShapeManager that has the following members:
    public class ShapeManager
    {
        // a. An ArrayList field holding shapes.
        // b. A public Add method that accepts a Shape and adds it to the collection.

        private ArrayList ShapesCollection = new ArrayList();
        public void AddShape(ShapeLib.Shape Shape1)
        {
            if (Shape1 != null) { ShapesCollection.Add(Shape1); }
        }
        // c. A public DisplayAll method that calls Display and Area for all shapes in the collection.

        public void DisplayAll()
        {
            int ShapeCounter = this.Count;
            if (ShapeCounter == 0) { Console.WriteLine("There are no shapes"); }
            else
            {
                if (ShapeCounter == 1) { Console.WriteLine("There is {0} Shape:", ShapeCounter); }
                else { Console.WriteLine("There are {0} Shapes:", ShapeCounter); }
            }

            
            for (int i = 0; i < ShapeCounter; i++)
            {
                Console.WriteLine("Shape #{0}:", (i+1));
                this.DisplayOne(this[i]);
            }

        }

        public void DisplayOne(Shape shape1)
        {
            switch (Convert.ToString(shape1.GetType()))
            {
                case "ShapeLib.Rectangle":
                    Console.WriteLine("This shape is a rectangle");
                    ((Rectangle)shape1).Display(ConsoleColor.Cyan);
                    Console.WriteLine("Area:\t {0}\n", ((Rectangle)shape1).Area);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;

                case "ShapeLib.Ellipse":
                    Console.WriteLine("This shape is an ellipse");
                    ((Ellipse)shape1).Display(ConsoleColor.Yellow);
                    Console.WriteLine("Area:\t {0}\n", ((Ellipse)shape1).Area);
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "ShapeLib.Circle":
                    Console.WriteLine("This shape is a circle");
                    ((Circle)shape1).Display();
                    Console.WriteLine("Area:\t {0}\n", ((Circle)shape1).Area);
                    break;
                default:
                    Console.WriteLine("Not a valid shape");
                    break;
            }
        }

        // d. A public read only indexer that returns a shape in a specified index.
        public Shape this[int i]
        {
            get
            {
                return (Shape)(ShapesCollection[i]);
            }
        }

        // e. A read only property named Count returning the total number of managed shapes.
        public int Count
        {
            get
            {
                int i;
                i = ShapesCollection.Count;
                return i;

            }
        }

    }

}
