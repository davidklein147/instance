using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    abstract class Cleaners : Product , ILastDate
    {
        bool dangerous;
        string lastDate;

        public string LastDate { set => lastDate = Date(value); }

        public string Date(string date)
        {
            return date;
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
