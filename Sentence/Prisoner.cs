using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sentence
{
    class Prisoner
    {
        public int nameNum;
        private int imprisonmentYears;
        private int startYear;
        public bool guilty;
        public static int releaseds = 0;

        public int  StartYear

        {
            get { return startYear; }
            set { startYear = value; }
        }

        public int ImprisonmentwsYear
        {
            get { return imprisonmentYears; }
            set { imprisonmentYears = value; }
        }

        public string getYearInPrison(int year)
        {
            if (year < startYear)
            {
                return string.Format("not prisoner");
            }
            else
            {
               // releaseds = year - startYear > imprisonmentYears ? releaseds += 1 : releaseds +=0;
                return (year - startYear) < imprisonmentYears ? string.Format("{0}", year - startYear) : "releseds";
            }
        }

        public int getReleaseds(int year)
        {
            releaseds = year - startYear > imprisonmentYears ? releaseds += 1 : releaseds += 0;
            return releaseds;
        }
            
        public Prisoner() 
        {
            guilty = PleadsGuilty();
        }

        public Prisoner(int nameNum) :this()
        {
            this.nameNum = nameNum;
        }

        public static bool PleadsGuilty()
        {
            return new Random().Next(2) == 1;
        }

        public override string ToString()
        {
            return string.Format("prisoner num {0}, incoming year {1}, imprisonmentw's Year {2}, guilty {3}"
                , nameNum, startYear, imprisonmentYears, guilty);
        }

        public string ToString(int yaer)
        {
            return string.Format("prisoner num {0},\n incoming year {1},\n imprisonmentw's Year {2}, \n running: {3}, \n guilty {4}"
                , nameNum , startYear, imprisonmentYears, getYearInPrison(yaer), guilty);
        }

    }
}
