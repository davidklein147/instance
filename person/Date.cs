using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Date
    {
        
        private int year;
        private int month;
        private int day;

        public int Year
        {
            get { return year; }
            set 
            {
                if (value < 2030 && value > 1930)
                {
                    year = value;
                } 
                else if (value < 31)
                {
                    year = 2000 + value;
                }
                else if (value < 100)
                {
                    year = 1900 + value;
                }
            }
        }

        public int Month
        {
            get { return month; }
            set
            {
                if(value < 13 && value > 0)
                {
                    month = value;
                }
            }
        }

        public int Day
        {
            get { return day; }
            set
            {
                switch (month)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if(value <= 31)
                        {
                            day = value;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (value <= 30)
                        {
                            day = value;
                        }
                        break;
                    case 2:
                        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        {
                            if (value <= 29)
                            {
                                day = value;
                            }
                        }
                        else
                        {
                            if (value <= 28)
                            {
                                day = value;
                            }
                        }
                        break;
                }
                
            }
        }


        public Date()
        {

        }
        public Date(string date)
            :this(int.Parse(date.Split('/', '-', ',')[0]), 
                  int.Parse(date.Split('/', '-', ',')[1]), 
                  int.Parse(date.Split('/', '-', ',')[2])
                 )
        {

        }

        public Date(int day, int month, int year)
        {
            Year = year;
            Month = month;
            Day = day;

        }

        

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}",day,month,year);
        }



    }
}
