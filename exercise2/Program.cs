using System;
using System.Text;

namespace exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 6;
            StringBuilder bui = new StringBuilder(sum *sum);
            for (int i = 0; i < sum; i++)
            {
                for (int j = 0; j < sum; j++)
                {
                    bui.Append('.');
                }
                bui.AppendLine();
                
            }

            for (int i = 0; i < sum * 2; i++)
            {
               
                bui.Replace('.', 'w', new Random().Next(1,bui.Length), 1);
            }
            Console.WriteLine(bui[sum-1] + "    oio  "+bui[sum+2]);
            
            Console.WriteLine(bui);
            /*string a = new string('.', i * i);
            int j = new Random().Next(0, i);
            for (int e = 0; e < j; e++)
            {
                int d = new Random().Next(0, a.Length);
                a.  (Substring(d, 1) = 'w';
            }
            Console.WriteLine(a);*/
        }
        public static bool PathFinder(string maze)
        {
            // Your code here!!
            return false;
        }
    }
}
