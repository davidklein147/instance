using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person
{
    class Person
    {
        public string firstName;
        public string lastName;
        public Date dob;

        public Person(string firstName, string lastName)
            :this(firstName, lastName, 1,1,2010)
        {

        }
        
        public Person(string firstName, string lastName, int year, int month, int day)
            :this(firstName, lastName, new Date (year, month,day))
        {

        }
        public Person(string firstName, string lastName, string date)
            : this(firstName, lastName, new Date(date))
        {

        }

        public Person(string firstName, string lastName, Date date)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            dob = date;
        }

        public Person(Person p) 
            :this(p.firstName, p.lastName, p.dob)
        {

        }
        public override string ToString()
        {
            return string.Format("first name : {0}, last name: {1}, birth's date: {2}",firstName, lastName, dob);
        }

        public bool isOld (Person p)
        {
            if (this == p) return false;
            if (this.dob.Year != p.dob.Year) return this.dob.Year < p.dob.Year;
            if (this.dob.Month != p.dob.Month) return this.dob.Month < p.dob.Month;
            if (this.dob.Day != p.dob.Day) return this.dob.Day < p.dob.Day;
            return false;
        }
    }
}
