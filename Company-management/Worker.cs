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
        string name, ID;
        int salary;
        public Worker()
        {
            name = Product.RondomString(8);
            ID = new Random().Next(100000000, 99999999).ToString();
            
        }
    }
}
