using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class Milk : Food, IFridge
    {
        int min, max;

        public Milk(int temp)
        {
            isFredge = true;
            minMaxTemp(out min, out max);
            isGoodTemp = chackTemp(temp);
        }
        

        public bool chackTemp(int temp)
        {
            return temp > min && temp < max;
        }

        public void minMaxTemp(out int min, out int max)
        {
            max = 10;
            min = 2;
        }
    }
}
