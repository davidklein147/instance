using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Trailer : ICheckDriver
    {
        int maxTon= new Random().Next(9,19);

        public bool IsCanDrive(Dreiver dri)
        {
            return maxTon < dri.max;
        }
        public override string ToString()
        {
            return base.ToString() + " " + maxTon;
        }
    }
}
