using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Triangular : Shape
    {
        public Triangular(double hight, double width) : base("triangular")
        {
            Lengte = hight;
            this.width = width;
        }

        public override double getErea()
        {
            return Lengte * width / 2;
        }

        public override double areaScope()
        {
            return width * 3;
        }
    }
}
