using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class BigCAr: MedumCar
    {
        int puopleSty;
        int maxHevi = new Random().Next(9, 22);
        public BigCAr(string model): base(model)
        {
            maxSeats = 50;
        }
        public override bool IsCanDrive(Dreiver dri)
        {
            return dri.lisesType >= 3 && maxHevi < dri.max;
        }
        public override string ToString()
        {
            return base.ToString() + " " + maxHevi;
            
        }

    }
}
