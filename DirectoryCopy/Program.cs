using System;
using System.IO;

namespace DirectoryCopy
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo sourse = new DirectoryInfo(@"C:\Users\stu\Desktop\images");
            DirectoryInfo targate = new DirectoryInfo(@"C:\Users\stu\Desktop\test");
            
            CopyFolder(sourse,targate.FullName);
        }
        public static void CopyFolder(DirectoryInfo sourse, string targate)
        {
            DirectoryInfo targatet = new DirectoryInfo(targate);
            targatet.Create();
            Array.ForEach(sourse.GetDirectories(),item => CopyFolder(item,@$"{targatet}\{item.Name}"));
            Array.ForEach(sourse.GetFiles(), item => File.Copy(item.FullName, @"C:\Users\stu\Desktop\images"));
        }
    }
}
