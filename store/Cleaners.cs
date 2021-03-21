using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class Cleaners : Product , ILastDate
    {
        public bool dangerous;
        string lastDate;

        public string LastDate { set => lastDate = value; }
        public Cleaners()
        {
            dangerous = new Random().Next(0, 2) == 1;
            LastDate = Date();
        }

        public string Date()
        {
            Random i = new Random();
            return "" + i.Next(0, 31) + "/" + i.Next(0, 12) + "/" + i.Next(2020, 2021);
        }
        public override string ToString()
        {
            return base.ToString()+ "is dunger: " + dangerous + "\n" ;
        }
    }

    class cleaningTool: Cleaners
    {

    }
    class cleaningCluding : Cleaners
    {

    }
    class cleaningFloor : Cleaners
    {

    }
}
