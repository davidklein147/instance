using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_data
{
    class GroundCar : Car
    {

        int wheels;
        public GroundCar(string color, int seats, int wheels) : base(color, seats)
        {
            this.wheels = wheels;
        }
    }
}
