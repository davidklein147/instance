using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence
{
    class Judge
    {

        public Judge(Prisoner p1, Prisoner p2 )
        {
            Judgment(p1, p2);
        }

        public void Judgment(Prisoner p1, Prisoner p2)
        {
            if(p1.guilty == p2.guilty)
            {
                if(p2.guilty == true)
                {
                    p1.ImprisonmentwsYear = 3;
                    p2.ImprisonmentwsYear = 3;
                }
                else
                {
                    p1.ImprisonmentwsYear = 7;
                    p2.ImprisonmentwsYear = 7;
                }
            }
            else
            {
                p1.ImprisonmentwsYear = p1.guilty?  1 : 10;
                p2.ImprisonmentwsYear = p2.guilty?  1 : 10;
            }

        }
    }
}
