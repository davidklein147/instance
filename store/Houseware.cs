using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class Houseware : Product
    {
        public bool breakable , responsibility;
        int timeRes;
        public Houseware()
        {
            breakable = new Random().Next(0,2) == 1;
            responsibility = new Random().Next(0, 2) == 1;
            if (responsibility) timeRes = new Random().Next(6, 18);
        }
        public override string ToString()
        {
            string str = "";
            if (breakable)
            {
                str = "Caution: BREAKABLE \n";
            }
                
            return base.ToString() + str;
        }
    }
}
