using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    class Line
    {
        private string Lines;

        public Line(string line)
        {
            Lines = string.Format(line);
        }

        public string GetLine()
        {
            return (Lines);
        }
    }
}
