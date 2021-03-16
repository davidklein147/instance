using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_data
{
    class AirCar : Car
    {
        public double maxPoint;
        public AirCar(string color, int seats, double maxHight):base(color, seats)
        {
            maxPoint = maxHight; 
        }
        public override string ToString()
        {
            return maxPoint + "";
        }
    }
}
