using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    interface IFridge
    {
        public void minMaxTemp(out int min, out int max);
        public bool chackTemp(int temp);
    }
}
