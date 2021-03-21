using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Store
{
    abstract class Product
    {
        string name, description, barcode;
        double price;
        public static int num;

        public Product()
        {
            num++;
            name = RondomString(8);
            description = RondomString(14);
            barcode = "92700000" + new Random().Next(10000, 99999);
            price = new Random().Next(0,100);
        }
        public static string RondomString(int num)
        {
            string str = "";
            for (int i = 0; i < new Random().Next(4,num); i++)
            {
                if (str.Length == 8)
                {
                    str += " ";
                   
                }

                str += (char)new Random().Next('a', 'z');
            }
            return str;
        }

        public override string ToString()
        {
            return string.Format(
                "num: {4} \n" +
                "type: {5} \n" +
                "name: {0} \n" +
                "description: {1} \n" +
                "barcode: {2} \n" +
                "price: {3}\n" 
                ,name, description, barcode, price, num, this.GetType());
        }
    }
    

    

}
