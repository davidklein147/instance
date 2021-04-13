using System;

namespace university
{
    class Program
    {
        static void Main(string[] args)
        {
            Student a = new Student("a", 123456789);
            ShipStudent b = new ShipStudent("b", 987654321, 2500);
            FamilyStudent c = new FamilyStudent("c", 963852741, 1);
            FamilyStudent d = new FamilyStudent("d", 741852963, 2);
            FamilyStudent e = new FamilyStudent("e", 321654987, 3);
            FamilyStudent f = new FamilyStudent("e", 321654987, 3);

            City.Add(a);
            City.Add(b);
            City.Add(c);
            City.Add(d);
            City.Add(e);
            City.Add(f);

            long lo = City.TuitionSum();
            Console.WriteLine("TuitionSum: " + lo);
            City.PrintDetails();
        }
    }
}
