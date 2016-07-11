using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileFinder
{
    class Finder
    {
        public string FileName { get; private set; }

        public Finder()
        {
            FileName = null;
        }

        public Finder(string fileName)
        {
            FileName = string.Format(fileName);
        }


        public bool ValidArgs(string[] args)  // Valid: Not null + at list 2 parameters + both 2 first parameters are not null.
        {
            return ((args != null) && (args.Length >= 2) && ((!string.IsNullOrEmpty(args[0])) && (!string.IsNullOrEmpty(args[1]))));
        }
    }
}
