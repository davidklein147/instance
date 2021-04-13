using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company_management
{
    class CEO: Manager

    {
        
        public CEO (string name, Manager[] managers): base(name ,managers)
	    {
            
	    }

        public void PrintManagers()
        {
            Console.WriteLine(base.ToString()); 
            foreach (var item in workers)
	        {
                Console.WriteLine(item);
	        }
        }
    }
}
