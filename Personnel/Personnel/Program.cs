using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Personnel
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Write a method that reads all data from the file (you can use a StreamReader) and places it in a List of strings. 
            // 4. Display the list. 

            string line;
            var linesList = new List<Line>();

            // File's path:
            string curFile = "C:/Users/RM/Source/Repos/C-Users-RM-Source-CodeValue/Personnel/CartoonsList.txt";

            try
            {
                // Read data from file
                using (StreamReader source = new StreamReader(curFile))
                {
                    while ((line = source.ReadLine()) != null)
                    {
                        // Generate the list:
                        Line LineToAdd = new Line(line);
                        linesList.Add(LineToAdd);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

            // Display the list
            if (File.Exists(curFile))
            {
                if (linesList.Any())
                {
                    Console.WriteLine("Printing the list of names in the file:\n");

                    foreach (Line lineInList in linesList)
                    {
                        Console.WriteLine(lineInList.Lines);
                    }
                }
                else
                {
                    Console.WriteLine("There are no records in the file");
                }
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
            
            Console.ReadLine();
        }
    }
}
