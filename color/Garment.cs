using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color
{
    class Garment
    {
        public int size;
        public string compeny;
        public Color color;

        public Garment(int size, string compeny, Color color)
        {
            this.size = size;
            this.compeny = compeny;
            this.color = color;
        }

        public override string ToString()
        {
            return "order is in color " + color + " from compeny " + compeny + " at size " + size;
        }
    }
}
