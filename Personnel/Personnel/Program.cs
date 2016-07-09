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
            var LinesList = new List<Line>();

            try
            {
                using (StreamReader source = new StreamReader("C:/Users/RM/Source/Repos/C-Users-RM-Source-CodeValue/Personnel/CartoonsList.txt"))
                {
                    while ((line = source.ReadLine()) != null)
                    {
                        Line LineToAdd = new Line(line);
                        LinesList.Add(LineToAdd);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Printing the list of names in the file:\n");

            if (LinesList == null)
            {
                Console.WriteLine("There are no records in the file");
            }
            else
            {
                foreach (Line lineInList in LinesList)
                {
                    Console.WriteLine(lineInList.GetLine());
                }
            }

            Console.ReadLine();


        }
    }
}
