using System;

namespace cars_data
{
    class Program
    {
        static void Main(string[] args)
        {

            Car[] carAry = new Car[]
            {
                new MarineCar("blue",225,true),
                new AirCar("white",345, 12),
                new GroundCar("red",7,4),
                new Car("green",5)
            };
            foreach (var item in carAry)
            {
                Console.WriteLine(item.color + " " + item.seats + " " + item.point);
            }
            
            Console.WriteLine(carAry[1].ToString());
            AirCar air = (AirCar)carAry[1];
            Console.WriteLine(air.maxPoint);


        }
    }
}
