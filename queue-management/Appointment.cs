using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 

namespace queue_management
{
    class Appointment
    {
        public string namePatient;
        public string plase;
        string date;
        int onlyMinits;
        int duration;
        int endTime;

        private int hour;

        public int Hour
        {
            get { return hour; }
            set { hour = value < 24 && value > -1 ? value :-1;}
        }
        private int minits;

        public int Minits
        {
            get { return minits; }
            set { minits = value < 60 && value > -1? value: -1; }
        }
        
        
        public Appointment(int hour, int minits, int duration, string date) 
        {
            Hour = hour;
            Minits = minits;
            onlyMinits = hour * 60 + minits;
            this.duration = duration;
            endTime = onlyMinits + duration;
            this.date = date;

            namePatient = rondomString();
            plase = rondomString();

        }

        public string time(int time)
        {
            string str = (time / 60).ToString();
            str += ":";
            str += time % 60 < 10? "0" + time % 60: time % 60;

            return str;
        }
        

        public static string rondomString()
        {
            string str = "";
            for (int i = 0; i < 9; i++)
            {
                str += (char)new Random().Next('a', 'z');
            }
            return str;
        }

        public override string ToString()
        {
            return string.Format(
                "name: {6} \n" +
                "appointment date: {5} \n" +
                "time: {0} \n" +
                "duration: {2} \n" +
                "end time: {3} \n" +
                "place: {7} "
                ,time(onlyMinits),duration, duration, time(endTime), endTime % 60, date, namePatient, plase);
        }




    }
}
