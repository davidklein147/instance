using System;
using System.Collections.Generic;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person("david", "12554796"));
            persons.Add(new Person("cheim", "15748978"));
            persons.Add(new Person("yechiel", "25898514"));
            GetPerson(persons);

        }

        public static void GetPerson(List<Person> persons)
        {
            Console.WriteLine("ebter a number of thearray's index to get person's details");
            int index = int.Parse(Console.ReadLine());
            try
            {

                Console.WriteLine(persons[index]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                GetPerson(persons);
            }

            //Console.WriteLine(persons[index]);
        }
    }
    class invalidIndex : Exception
    {
        
        public invalidIndex(int index): base( index + " is invalid index in the array !")
        {
            
        }
    }
}
