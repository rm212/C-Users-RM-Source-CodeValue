using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personnel
{
    class Line
    {
        public string Lines { get; private set; }

        public Line(string line)
        {
            Lines = string.Format(line);
        }
    }
}
