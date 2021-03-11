using System;

namespace beginnig
{
    class Program
    {
        static void Main(string[] args)
        {
            //daysOfMonths();
            //charOfNum();
            //pairNum();
            //today();
            //checkSum();
            //name();
            //isOdd();
            //printTow();
            //arrAverenge();
            //printNine();
            //isFirstt();
            //cellInFibonacci();
            //MultiplicationTable();
            //chars();
            //towArrays();
            //names();
            areas();
        }

        static void daysOfMonths()
        {
            Console.WriteLine("enter a date of month");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a date of year");
            int year = int.Parse(Console.ReadLine());
            int days = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    days = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;
                case 2:
                    if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                    {
                        days = 29;
                    }
                    else
                    {
                        days = 28;
                    }
                    break;
            }


            Console.WriteLine(days);
        }
        static void charOfNum()
        {


            String a = Console.ReadLine();
            int[] arr = new int[a.Length];
            int c = int.Parse(a);
            int d = 0;
            for (int b = 0; b < arr.Length; b++)
            {
                arr[b] = c % 10;
                c = c / 10;
                d += arr[b];
            }
            Console.WriteLine(a.Length);
            Console.WriteLine(d);



        }
        static void pairNum()
        {
            int counter = int.Parse(Console.ReadLine()) % 2;
            counter += int.Parse(Console.ReadLine()) % 2;
            counter += int.Parse(Console.ReadLine()) % 2;
            counter += int.Parse(Console.ReadLine()) % 2;
            
            Console.WriteLine(counter);

        }
        static void today()
        {
            string[] days = new string[] { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            Console.WriteLine("enter a number of a day");
            int day = int.Parse(Console.ReadLine());
            if(day <= 0 || day > 7)
            {
                Console.WriteLine("the number tath you choosed iz incorrect");
            }
            else
            {
                Console.WriteLine(days[day-1]);
            }
            today();
        }
        static void checkSum()
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            Console.WriteLine(x + y == sum);
        }
        static void name()
        {
            string name = "david";
            string password = "70147";
            Console.WriteLine("to logain enter your name");
            string name1 = Console.ReadLine();
            while(name != name1)
            {
                Console.WriteLine("your name is incorrect try again, to esc enter 0000");
                name1 = Console.ReadLine();
                if (name1 == "0000")
                {
                    Console.WriteLine("good bay");
                    break;
                }
            }
            if (name == name1)
            {
                Console.WriteLine("enter your password");
                string password1 = Console.ReadLine();
                while (password != password1)
                {
                    Console.WriteLine("your password is incorrect try again, to esc enter 0000");
                    password1 = Console.ReadLine();
                    if (password1 == "0000")
                    {
                        Console.WriteLine("good bay");
                        break;
                    }
                }
                Console.WriteLine("logain succeful");
            }
        }
        static void isOdd()
        {
            Console.WriteLine("enter a integer less then century");
            int num = int.Parse(Console.ReadLine());
            int pair = 1;
            int add = 0;
            while (num > 0)
            {
                if (num % 2 == 0)
                {
                    pair = pair * (num % 10);
                }
                else
                {
                    add += num % 10;
                }
                num = num / 10;
            }

            if (pair == 1)
            {
                Console.WriteLine("The number includes only digits odd " + add);
            } else if(add == 0)
            {
                Console.WriteLine("the number includes only digits even " + pair);
            }
            else
            {
                Console.WriteLine("number Mixed");
            }
            //isOdd();
        }
        static void printTow()
        {
            for(int i = 2; i <= 20; i = i + 2)
            {
                Console.WriteLine(i);
            }
        }
        static void arrAverenge()
        {
            int everenge = 0;
            for (int i = 0; i < 5;  i++)
            {
               everenge += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(everenge + " " + (double)everenge/5);
        }
        static void printNine()
        {
            for (int i = 9; i >= 0; i--)
            {
                for (int y = 0; y <= i; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();
            }
        }
        static void isFirstt()
        {
            Console.WriteLine("enrter a number");
            int num = int.Parse(Console.ReadLine());
            bool isFirst = true;
            if (num != 2 && num % 2 == 0 )
            {
                isFirst = false;
            }
            else
            {
                if (num != 1 )
                {
                    for (int i = 3; i <= Math.Sqrt(num); i += 2)
                    {
                        if (num % i == 0)
                        {
                            isFirst = false;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(isFirst);
            isFirstt();
        }
        static void cellInFibonacci()
        {
            int[] arr = new int[20];
            arr[0] = 1;
            arr[1] = 1;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2]; 
            }
            foreach (var item in arr)
            {
                Console.Write(item + ",");
            }
            Console.WriteLine();
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                if(num >= arr[i] && num < arr[i + 1])
                {
                    Console.Write(i);
                    break;
                }
            }    
        }
        static void MultiplicationTable()
        {
            int[,] table = new int[10, 10]; 
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int t = 0; t < table.GetLength(1); t++)
                {
                    table[i, t] = (i+1) * (t+1);
                    Console.Write(table[i,t] + "\t");
                }
                Console.WriteLine();
            }
            while (true)
            {
                Console.WriteLine("enter first number");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("enter second number");
                int b = int.Parse(Console.ReadLine());
                Console.WriteLine(table[a - 1, b - 1]);
            }
            
        }
        static void chars()
        {
            Char[] charecters = new char[5];
            for (int i = 0; i < charecters.Length; i++)
            {
                charecters[i] = char.Parse(Console.ReadLine());
            }
            foreach (var item in charecters)
            {
                Console.Write(item + " " );
            }

        }
        static void towArrays()
        {
            Console.WriteLine("enter a number for the size of the arrays");
            int size = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            Console.WriteLine("put numbers in the array");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());               
            }
           
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            for (int i = 0 ; i < arr1.Length; i++)
            {
                Console.WriteLine("aar1[" + i + "]" + arr1[i]+ " = aar2[" + i + "]" + arr2[i]);
            }

            Console.WriteLine("put numbers in the array");
            for (int i = 0; i < arr1.Length; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("aar1[" + i + "]" + arr1[i] + " = aar2[" + i + "]" + arr2[i]);
            }

            arr2 = arr1;
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine("aar1[" + i + "]" + arr1[i] + " = aar2[" + i + "]" + arr2[i]);
            }


        }
        static void names()
        {
            string name = Console.ReadLine();
            string lestName = Console.ReadLine();
            PrintFullName(name+ " " + lestName);
            PrintFullName(name, lestName);
            PrintFullName(name ,lestName, false);
            PrintFullName(name, lestName, true);
        }
        static void PrintFullName(string name)
        {
            Console.WriteLine(name);
        }
        static void PrintFullName(string name, string lestName)
        {
            Console.Write(name + " "  + lestName);
            Console.WriteLine();
        }
        static void PrintFullName(string name, string lestName, bool onLine)
        {
            if (onLine)
            {
                Console.Write(name + " " + lestName);
            }
            else
            {
                Console.WriteLine("{0} {1}",name , lestName);
            }       
        }
        static void areas()
        {
            
            Console.WriteLine("enter the value of the length and the width");
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());

            area(length,width);
            Console.WriteLine("enter the value of the circle diameter");
            int circle = int.Parse(Console.ReadLine());
            area(circle);

        }
        static void area(int length, int width)
        {
            Console.WriteLine(length * width);
        }
        static void area(int circle)
        {
            Console.WriteLine((double)circle * Math.PI);
        }


    }
}
