using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using ShapesApp;
using ShapeLib;

namespace Shapes1
{
    class Program
    {
        class ManuesAndMore 
        {
            public void MainManue() 
            {
                Console.WriteLine("Hello,");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("To add shape:\t\t\t Please press 1");
                Console.WriteLine("To display a specific shape:\t Please press 2");
                Console.WriteLine("To display all shapes:\t\t Please press 3");
                Console.WriteLine("\n To Exit please press any other choice");
            }

            public void ShapeManue() 
            {
                Console.WriteLine("\nAdd Shape Manue\n");
                Console.WriteLine("Please choose the shape you would like to add:");
                Console.WriteLine("To add Rectangle:\t Please choose R");
                Console.WriteLine("To add Ellipse:\t\t Please choose E");
                Console.WriteLine("To add Circle:\t\t Please choose C");
                Console.WriteLine("\n To Exit please press any other choice");
            }


            public Boolean validity(string UserInput) 
            {
                Boolean valid = false;

                return valid;
            
            }
        }
        
        static void Main(string[] args)
        {
            // 9. In the Main method:
            // a. Create an instance of ShapeManager.

            ShapeManager ShapesCollection = new ShapeManager();

            // b. Add several different shapes to the ShapeManager you just created.
            string Choice ;
            string ChoiceShape;
            int d1 =0, d2=0;
            int ShapeCounter;
            int ColorCounter = 0;
            ManuesAndMore Disp = new ManuesAndMore();

            // Screen 1: Start Menue
            Boolean flag = true;


            while (flag == true)
            {
                ColorCounter++;
                Disp.MainManue();
                Choice = Convert.ToString(Console.ReadLine());
                flag = ((Choice == "1") || (Choice == "2") || (Choice == "3")) ? true : false;

                switch (Choice)
                {
                    case "1":
                        // Screen 1.1: Choosing a shape to add
                        Disp.ShapeManue();
                        ChoiceShape = Convert.ToString(Console.ReadLine());
                        switch (ChoiceShape)
                        {
                            // Screen 1.1.1: Getting dimension for the shape
                            case "R":
                            case "r":
                                Rectangle rectangle = new Rectangle();
                                Console.WriteLine("Please enter the width of the rectangle");
                                d1 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Please enter the height of the rectangle");
                                d2 = Convert.ToInt16(Console.ReadLine());
                                rectangle.GetDinmentions(d1, d2);
                                ShapesCollection.AddShape(rectangle);

                                Console.Clear();
                                Console.WriteLine("You just added a new shape");
                                ShapesCollection.DisplayOne(rectangle);
                                Console.WriteLine("\n\n\n");
                                break;

                            case "E":
                            case "e":
                                Ellipse ellipse = new Ellipse();
                                Console.WriteLine("Please enter the 1st radius of the ellipse");
                                d1 = Convert.ToInt16(Console.ReadLine());
                                Console.WriteLine("Please enter the 2nd radius of the ellipse");
                                d2 = Convert.ToInt16(Console.ReadLine());
                                ellipse.GetDinmentions(d1, d2);
                                ShapesCollection.AddShape(ellipse);

                                Console.Clear();
                                Console.WriteLine("You just added a new shape");
                                ShapesCollection.DisplayOne(ellipse);
                                Console.WriteLine("\n\n\n");
                                break;

                            case "C":
                            case "c":
                                Circle circle = new Circle();
                                Console.WriteLine("Please enter the radius of the circle");
                                d1 = Convert.ToInt16(Console.ReadLine());
                                circle.GetDinmentions(d1);
                                ShapesCollection.AddShape(circle);

                                Console.Clear();
                                Console.WriteLine("You just added a new shape");
                                ShapesCollection.DisplayOne(circle);
                                Console.WriteLine("\n\n\n");
                                break;

                            default:
                                Console.WriteLine("Not valid shape");
                                break;
                        }
                        break;

                    case "2":
                        // Screen 1.2: Choosing specific shape from the arry and displaying
                        Console.Clear();
                        ShapeCounter = ShapesCollection.Count;
                        if (ShapeCounter == 0)
                        {
                            Console.WriteLine("There are no shapes");
                            Console.WriteLine("Please add shapes first\n\n");
                        }
                        else
                        {
                            if (ShapeCounter == 1) { Console.WriteLine("There is {0} Shape:", ShapeCounter); }
                            else { Console.WriteLine("There are {0} Shapes:", ShapeCounter); }

                            Console.WriteLine("Please enter the shape number");
                            int choose = Convert.ToInt16(Console.ReadLine());
                            if (choose <= ShapeCounter) { ShapesCollection.DisplayOne(ShapesCollection[choose - 1]); }
                            else { Console.WriteLine("not a valid number"); }
                            
                        }
                        break;

                    case "3":
                        // Screen 1.3: Displaying all shapes
                        Console.Clear();
                        ShapesCollection.DisplayAll();
                        break;

                    default:
                        Console.WriteLine("\nYou didn't choose any valid choice");
                        Console.WriteLine("\nPress Y to continue or any key to end");
                        string stay = Convert.ToString(Console.ReadLine());
                        flag = ((stay == "Y") || (stay == "y")) ? true : false;
                        break;
                }
            }

            Console.WriteLine("Thanks and good bye");

            // c. Call DisplayAll and make sure you get the expected result.
            Console.ReadLine();

        }
    }
}
