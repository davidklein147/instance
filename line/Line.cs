using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace line
{
    class Line
    {
        public Point startLine;
        public Point endLine;
        double width;

        public Line()
        {

        }

        public Line(Point startLine, Point endLine, double width)
        {
            this.startLine = startLine;
            this.endLine = endLine;
            this.width = width;
        }

        public override string ToString()
        {
            return "start line: " + startLine + ",  end line: " + endLine + " " + width;
        }
    }
}
