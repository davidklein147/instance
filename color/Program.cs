using System;

namespace color
{
    class Program
    {
        static void Main(string[] args)
        {
            Car lecses = new Car("lecses", 230000, new Color(123, 236, 245));
            Console.WriteLine(lecses);

            Garment scirt = new Garment(34, "dfdf", new Color());
            Console.WriteLine("scirt " + scirt);
            scirt.color.red = 142;
            scirt.color.blue = 223;
            Console.WriteLine("scirt " + scirt);

            Garment shirt = new Garment(45, "tyu", new Color(23, 44, 55));
            Console.WriteLine(shirt);
        }
    }
}
