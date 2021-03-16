using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Circle : Shape
    {

        public Circle(double diameter) :base("circle")
        {
            Lengte = diameter;
        }

        public override double getErea()
        {

            return Math.PI * Math.Pow(Lengte/2, 2);
        }
        public override double areaScope()
        {
            return Math.PI* Lengte;
        }
    }
}
