using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store;

namespace Company_management
{
    class Worker 
        {
        protected string name, ID;
        protected int salary;
      
        public Worker(string name)
        {
            this.name = name;
            ID = new Random().Next(10000000, 99999999).ToString();
            salary = SetSalary();
            
        }
        public virtual int SetSalary()
        {
            return new Random().Next(4999,8000);
        }
        public virtual void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"{name}  salary is: {salary} ");
        }
        
    }
}
