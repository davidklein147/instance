using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = CatchException("enter oe number");
            double b = CatchException("enter two number");
            Print(a,b);
        }

        public static double CatchException(string massage)
        {
            Console.WriteLine(massage);
            double a = 0;
            try
            {
                 a = double.Parse(Console.ReadLine());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                CatchException("try again " + massage);
            }
            return a; 
        }

        
        public static void Print(double a, double b)
        {
            Console.WriteLine("enter operator what you want to + - * /");
            char c = char.Parse(Console.ReadLine());
            switch (c)
            {
                case '+':
                    Console.WriteLine(a + b) ;
                    break;
                case '-':
                    Console.WriteLine(a - b);
                    break;
                case '*':
                    Console.WriteLine(a * b);
                    break;
                case '/':
                    if (b == 0)
                    {
                        throw new Exception("incorrect to divided at zero");
                    }
                    else
                    {
                        Console.WriteLine(a / b);
                    }
                    break;
                    
                default:
                    Print(a, b);
                    break;
                    
            }
            
        }
    }
}
