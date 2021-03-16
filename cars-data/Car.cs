using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_data
{
    class Car
    {
        public string color;
        public int seats;
        public int point;

        public Car( string color, int seats)
        {
            this.color = color;
            this.seats = seats;
        }
    }
}
