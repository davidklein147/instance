using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Milk(5);
            Type p1 = p.GetType();
            
            Console.WriteLine(p1);
            if (p is IFridge)
            {
                Console.WriteLine("dsds");
            }

            Milk p3 = new Milk(2);
            List < IFridge >  mm = new List<IFridge>();
            mm.Add((Milk)p3);
            Type ty = p3.GetType().BaseType;
            Console.WriteLine(ty);
        }
    }
}
