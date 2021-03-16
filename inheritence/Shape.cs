using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritence
{
    class Shape
    {
        public double width;
        public string shapeName;

        protected double lengte;

        public virtual double Lengte
        {
            get { return lengte; }
            set { lengte = value; }
        }


        public Shape(string shapeName)
        {
            this.shapeName = shapeName;
        }

        public virtual double getErea()
        {
            return 0;
        }

        public virtual double areaScope()
        {
            return 0;
        }
    }
}
