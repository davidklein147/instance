using System;

namespace person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("david", "klein");
            Person p2 = new Person(p1);
            p1.firstName = "chiam";
            //p2.dob.Year = 99;
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p1.isOld(p2));

            /*
            Person a = new Person("david", "klein");
            Console.WriteLine("first name: " + a.firstName);
            Console.WriteLine("last name: " + a.lastName);
            Console.WriteLine("birth's date: " + a.dob);

            Person b = new Person("mirum", "klein", new Date(28,2,28));
            Person c = new Person("chaim", "klein", new Date("27/03/28")); 
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(b.isOld(c));

            Person[] perArr = new Person[1];
            for (int i = 0; i < perArr.Length; i++)
            {
                Console.WriteLine("enter a name for the {0} person", i + 1);
                perArr[i] = new Person(Console.ReadLine(), Console.ReadLine());
                Console.WriteLine("enter the person's birth date");
                perArr[i].dob = new Date(Console.ReadLine());
            }

            foreach (var item in perArr)
            {
                Console.WriteLine(item);
            }*/

            Person pp1 = new Person("da", "kl", 1, 5, 99);
            Person pp2 = new Person("da", "kl", 2, 4, 99);
            Console.WriteLine(pp1);
            Console.WriteLine(pp2);
            
            Console.WriteLine(pp1.isOld(pp2));
        }
    }
}
