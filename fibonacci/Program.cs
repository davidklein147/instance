using System;
using System.IO;
using System.Text;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {             
            int n = 26;
            PrintFibonacci(n);
            int i  = FibonacciSeries(n);
            Console.WriteLine(i);
        }
        public static int FibonacciSeries(int index)
        {
            if (index <= 0) return 0;
            if (index == 1) return 1;
            return FibonacciSeries(index - 2) + FibonacciSeries(index - 1);
        }
        public static void PrintFibonacci(int index)
        {
            if (index == 0) return;
            PrintFibonacci(index - 1);
            Console.WriteLine(FibonacciSeries(index));
        }
    }
   
}
