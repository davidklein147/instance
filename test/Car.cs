using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    abstract class Car
    {
        protected string color, numId, model;

        public Car(string model)
        {
            this.model = model;
        }
        /*public override string ToString()
        {
            return model;
        }*/
    }
     
    
}
