using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class Food : Product ,ILastDate
    {
        string lastDate, storagesType;

        public string LastDate { set => lastDate = Date(value); }

        public string Date(string date)
        {
            return date;
        }
    }
}
