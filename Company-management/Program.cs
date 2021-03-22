using System;
using System.Collections.Generic;

namespace Company_management
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> i = new List<int> { 5, 6, 9, 2 };
            i.Sort();
            foreach (var item in i)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(i);
            Type y = i.GetType();
            Console.WriteLine(y);

        }
    }
}
