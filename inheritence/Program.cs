using System;

namespace inheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Shape s = new Shape("g");
            Console.WriteLine(s.getErea());
            Square c = new Square();
            c.Lengte = 20;
            c.width = 89;
            Console.WriteLine(c.getErea());
            Console.WriteLine(c.areaScope());

            Circle cc = new Circle(13);
            Console.WriteLine(cc.getErea());
            Console.WriteLine(cc.areaScope());

            Shape[] cirArr = new Shape[] {new Shape("rty"), new Circle(3), new Triangular(33,3), new Square(), new Rectangle()};
            cirArr[3].Lengte = 23;
            cirArr[3].width = 13;
            cirArr[4].Lengte = 53;
            cirArr[4].width = 33;
            foreach (var item in cirArr)
            {
                Console.WriteLine(item.getErea());
            }*/

            Rectangle re = new Rectangle();
            re.width = 2;
            re.Lengte = 3;
            Console.WriteLine(re.Lengte);
            Square sq = new Square();
            sq.width = 2;
            sq.Lengte = 2;
            Console.WriteLine(sq.Lengte);
        }
    }
}
