using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            ICheckDriver[] cars = new ICheckDriver[10];
            cars[0] = new MedumCar("a");
            cars[1] = new MedumCar("b");
            cars[2] = new NormaCar("c");
            cars[3] = new NormaCar("d");
            cars[4] = new BigCAr("e");
            cars[5] = new BigCAr("f");
            cars[6] = new Trailer();
            cars[7] = new Trailer();
            cars[8] = new Trailer();
            cars[9] = new MedumCar("u");
            

            for (int i = 0; i < 5; i++)
            {
                NewDriver(cars);
            }
        }
        public static void NewDriver(ICheckDriver[] check)
        {
            Console.WriteLine();
            Dreiver dri = new Dreiver();
            Console.WriteLine("enter driver name");
            dri.name = Console.ReadLine();
            Console.WriteLine("enter type lises bithwin 1 to 3");
            dri.lisesType = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the nax Ton");
            dri.max = int.Parse(Console.ReadLine());

            foreach (var item in check)
            {
                Console.WriteLine(item.ToString()+ " " + item.IsCanDrive(dri));
            }
        }
    }
}
