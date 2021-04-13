using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_management
{
    class Manager: Worker
    {
       public Worker[] workers;
        public Manager (string name, Worker[] workers): base(name)
	    {
            this.workers = workers;
            

	    }
        public override int SetSalary()
        {
            return new Random().Next(14999,25000);
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"I have {workers.Length} workers");
            foreach (var item in workers)
	        {
                item.Print();
	        }
        }
        public override string ToString()
        {
            return $"{name}  salary is: {salary} ";
        }
    }
}
