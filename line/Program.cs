using System;

namespace line
{
    class Program
    {
        static void Main(string[] args)
        {
            Line li1 = new Line(new Point(), new Point(), .5);
            li1.startLine.x = 12;
            li1.startLine.y = 13;
            li1.endLine.x = 15;
            li1.endLine.y = 16;
            Line li2 = new Line(new Point(27, 28), new Point(20, 22), 1);
            Line li3 = new Line();
            li3.startLine = new Point(31, 32);
            li3.endLine = new Point();
            li3.endLine.x = 34;
            li3.endLine.y = 39;



            Console.WriteLine(li1);
            Console.WriteLine(li2);
            Console.WriteLine(li3);

        }
    }
}
