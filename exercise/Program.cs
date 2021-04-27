using System;
using System.Collections.Generic;

namespace exercise
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr =  DeleteMth(new int[] { 3, 3, 6, 2, 2, 6, 6, 8, 5 ,3}, 2);
            Array.ForEach(arr, Console.WriteLine);
            int[] a = { 1, 2 };
            //Array.Clear(a, 1, 1);
           // Array.ForEach(a, Console.WriteLine);
        }
        public static int[] DeleteMth(int[] arr, int n)
        { 
            List<int> mylist = new List<int>();
            foreach (var item in arr)
            {
                mylist.Add(item);
            }
           //mylist.ForEach(Console.WriteLine);

            for (int i = 0; i < mylist.Count; i++)
            {
                int value = mylist[i];
                int n2 = 1;
                for (int j = i+1; j < mylist.Count; j++)
                {
                    if (mylist[j] == value)
                    {
                        n2++;
                        if (n2 > n)
                        {
                            mylist.RemoveAt(j);
                            j--;
                        }
                    }
                }
            }
            return mylist.ToArray();
        }
        
    }
}
