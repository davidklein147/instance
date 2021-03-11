using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color
{
    class Color
    {
        public byte red;
        public byte blue;
        public byte green;

        public Color()
        {

        }

        public Color(string red, string blue, string green)
        {

        }

        public Color(byte red, byte blue, byte green)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
        }

        public override string ToString()
        {
            return "(" + red + "," + blue + "," + green + ")";
        }
    }
}
