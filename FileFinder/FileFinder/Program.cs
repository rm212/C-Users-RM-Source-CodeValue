using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2.   Use the first parameter from the command line as a directory path, and search
            //      for all files that contain a string passed as the second parameter to the command line.

            //          First parameter, directory path: "C:\Users\RM\Source\Repos\C-Users-RM-Source-CodeValue\FileFinder\TestZone" 
            //          Second parameter: "*a*"

            // 3.   Display a list of all those files and their length. 

            Finder finder = new Finder();
            string directoryPath = null;    // args[0]: Directory path
            string passedString = null;     // args[1]: String passed

            var listOfFilteredFiles = new List<Finder>();   // Using for the list of the filtered files (according to args[1])

            // Validity of args:
            if (finder.ValidArgs(args))
            {
                directoryPath = args[0];
                passedString =  args[1];
            }

            // Look for passed string:
            if (!string.IsNullOrEmpty(directoryPath) && !string.IsNullOrEmpty(passedString))
            {
                DirectoryInfo directory = new DirectoryInfo(directoryPath);

                if (directory.Exists)
                {
                    // Generate list of files: File name contain the letter 'a':
                    foreach (var fileName in directory.GetFiles(passedString))
                    {
                        Finder LineToAdd = new Finder(fileName.Name);
                        listOfFilteredFiles.Add(LineToAdd);
                    }

                    // Display
                    if (listOfFilteredFiles.Any())
                    {
                        Console.WriteLine("List of files: File name contain the letter 'a':\n");
                        foreach (Finder fileName in listOfFilteredFiles)
                        {
                            Console.WriteLine(fileName.FileName);
                        }
                    }
                    else
                    {
                        //For empty folder please put in args:  "C:\Users\RM\Source\Repos\C-Users-RM-Source-CodeValue\FileFinder\TestZone\a"
                        //For folder with no matched file please put in args:  "C:\Users\RM\Source\Repos\C-Users-RM-Source-CodeValue\FileFinder\TestZone\b"
                        Console.WriteLine("{0}", (directory.GetFileSystemInfos().Length == 0) ? ("There are no files in the given directory") : ("No matched files were found in the directory"));
                    }
                }
                else
                {
                    Console.WriteLine("The given directory is not exist \nPlease try with an exist directory");
                }
            }
                Console.ReadLine();
        }
    }
}
