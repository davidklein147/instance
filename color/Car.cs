using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace color
{
    class Car
    {
        public string model;
        public int price;
        public Color color;

        public Car()
        {

        }

        public Car(string model, int price, Color color)
        {
            this.model = model;
            this.price = price;
            this.color = color;
        }
        public override string ToString()
        {
            return "the price of " + model + "car at color" + color + " is :" + price;
        }
    }
}
