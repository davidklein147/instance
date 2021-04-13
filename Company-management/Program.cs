using System;
using System.Collections.Generic;

namespace Company_management
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager[] man = new Manager[4];
            
            man[0] =  new Manager("A",new Worker[3]);
            man[1] =  new Manager("B",new Worker[2]);
            man[2] =  new Manager("C",new Worker[1]);
            man[3] =  new Manager("D",new Worker[2]);
            man[0].workers[0] = new Worker("A = a");
            man[0].workers[1] = new Worker("A = b");
            man[0].workers[2] = new Worker("A = c");
            man[1].workers[0] = new Worker("B = a");
            man[1].workers[1] = new Worker("B = b");
            man[2].workers[0] = new Worker("C = a");
            man[3].workers[0] = new Worker("D = a");
            man[3].workers[1] = new Worker("D = b");

            CEO ce = new CEO("ABC", man);
            //ce.Print();
            //ce.PrintManagers();
            Console.WriteLine(ce);







        }
    }
}
