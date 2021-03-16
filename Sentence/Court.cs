using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence
{
    class Court
    {
        public static int year = 1990;
        public static int seatNum = 0;
        public Prisoner[] prisArr = new Prisoner[300];
        public Court()
        {
           
        }

        public void generatePris()
        {
            for (int i = 0; i < 2; i++)
            {
                prisArr[seatNum] = new Prisoner(seatNum);
                prisArr[seatNum].StartYear = year;
                seatNum++;
            }
            new Judge(prisArr[seatNum - 1], prisArr[seatNum - 2]);   
        }

    }
   
}
