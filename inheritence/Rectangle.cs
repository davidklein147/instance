using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Rectangle :Square
    {
        public override double Lengte { set { if (value > width) lengte = value; } }
        public override double areaScope()
        {
            return 2*Lengte + 2* width;
        }
    }
}
