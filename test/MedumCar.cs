using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class MedumCar : NormaCar
    {
        bool forChild;
        public MedumCar(string model): base(model)
        {
            maxSeats = 20;
        }

        public override bool IsCanDrive(Dreiver dri)
        {
            return dri.lisesType >= 2; 
        }
    }
    
}
