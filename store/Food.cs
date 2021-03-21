using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class Food : Product ,ILastDate
    {
        string lastDate;
        public bool isFredge, isGoodTemp;

        public string LastDate { set => lastDate = value; }

        public Food()
        {
            LastDate = Date();
                   
        }
        public string Date()
        {
            Random i = new Random();
            return "" + i.Next(0, 31) + "/" + i.Next(0, 12) + "/" + i.Next(2020, 2021); 
        }

        public override string ToString()
        {
            return base.ToString()+ "last date: " + lastDate + "\n";
        }
    }
}
