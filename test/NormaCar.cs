using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class NormaCar : Car, ICheckDriver
    {
        protected int maxSeats = 4;
        public NormaCar(string model):base(model)
        {
            
        }

        public virtual bool IsCanDrive(Dreiver dri)
        {
           return dri.lisesType >= 1;
        }
    }

}
