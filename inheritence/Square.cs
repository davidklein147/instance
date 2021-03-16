using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Square : Shape
    {
        public Square() :base("square")
        {

        }

        public override double Lengte { set {if(value == width) base.Lengte = value;} }

        public override double getErea()
        {
            return Lengte * width;
        }
        public override double areaScope()
        {
            return 4 * Lengte;
        }
    }
}
