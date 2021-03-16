using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cars_data
{
    class MarineCar : Car
    {
        bool diving;   
        public MarineCar(string color, int seats, bool diving ) : base(color,seats)
        {
            this.diving = diving; 
        }
    }
}
