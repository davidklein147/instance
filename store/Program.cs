using System;
using System.Collections.Generic;

namespace Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] productNames = new string[]
            { "milk", "fruit", "meat", "pastry", "Electrical", "UtensilBakKoo",
                "cleaningTool",  "cleaningFloor", "cleaningCluding" };
            SetShlfs setShlfs = new SetShlfs();
            for (int i = 0; i < 100; i++)
            {
                string str = productNames[new Random().Next(0, productNames.Length)];
                int type = new Random().Next(0, 9);
                
                switch (str)
                {
                    case "milk":
                        setShlfs.SetProtuct(new Milk(new Random().Next(0,14)));
                        break;
                    case "fruit":
                        setShlfs.SetProtuct(new Fruit());
                        break;
                    case "meat":
                        setShlfs.SetProtuct(new Meat());
                        break;
                    case "pastry":
                        setShlfs.SetProtuct(new Pastry());
                        break;
                    case "Electrical":
                        setShlfs.SetProtuct(new Electrical());
                        break;
                    case "UtensilBakKoo":
                        setShlfs.SetProtuct(new UtensilBakKoo());
                        break;
                    case "cleaningTool":
                        setShlfs.SetProtuct(new cleaningTool());
                        break;
                    case "cleaningFloor":
                        setShlfs.SetProtuct(new cleaningFloor());
                        break;
                    case "cleaningCluding":
                        setShlfs.SetProtuct(new cleaningCluding());
                        break;
                }
            }

            Console.WriteLine(
                "there are in store:\n"+
                "{5} products: \n" +
                "fridge's products: {0} \n" +
                "other fridge's products: {6} \n" + 
                "dounger's products: {1} \n" +
                "electric's products: {2} \n" +
                "products that they have last date: {3}\n" +
                "dther products: {4}\n", 
                setShlfs.shelf.countFridge(),
                setShlfs.shelf.countdounger(),
                setShlfs.shelf.ConuntElctri(),
                setShlfs.shelf.countlast(),
                setShlfs.shelf.ConuntOther(),
                Product.num,
                setShlfs.shelf.countFridge1()
                );
            /*foreach (var item in setShlfs.shelf.electri)
            {
                Console.WriteLine(item);
            }*/
            
        }
    }
}
