using System;
using System.Threading;
using System.IO;
using System.Text;
using System.Text.Encodings;


namespace streams
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(Copy);
            //t.Start();
            Thread();
            Action ac = Copy;
            Directory 
            
        }
        public static void Copy()
        {
            FileInfo source = new FileInfo(@"C:\Users\stu\Desktop\שיעורים\אלגרסי\lessens.txt");
            FileInfo targate = new FileInfo(@"C:\Users\stu\Desktop\Exercises\c#\text\lessens.txt");
            FileStream sSource = new FileStream(source.FullName, FileMode.Open, FileAccess.Read);
            FileStream sTargate = new FileStream(targate.FullName, FileMode.OpenOrCreate, FileAccess.Write);
            byte[] buffer = new byte[1024] ;
            StringBuilder sb = new StringBuilder();
            int counter = 0;
            int counter1 = 0;
            Console.WriteLine(source.Length);
            Console.WriteLine(targate.Length);
            while ((counter = sSource.Read(buffer)) != 0)
            {
                sTargate.Write(buffer, 0, counter);
                Console.WriteLine($"{(((float)sTargate.Length * 100) / (float)source.Length):f}");
                targate.Refresh();
                counter1 += counter;
            }
            sTargate.Close();
            Console.WriteLine(targate.Length);
            Console.WriteLine(counter1);
        }
        public static void Thread()
        {
            FileInfo source = new FileInfo(@"C:\Users\stu\Desktop\שיעורים\אלגרסי\lessens.txt");
            FileInfo targate = new FileInfo(@"C:\Users\stu\Desktop\שיעורים\אלגרסי\lessens.txt");
            File.Copy(@"C:\Users\stu\Desktop\שיעורים\אלגרסי\lessens.txt", @"C:\Users\stu\Desktop\Exercises\c#\text\lessens.txt", true);
        }

    }
}
