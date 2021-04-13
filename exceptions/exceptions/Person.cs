using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Person
    {
        string name, ID;
        public Person(string name, string ID)
        {
            this.name = name;
            this.ID = ID;
        }
        public override string ToString()
        {
            return $"name: {name} ID: {ID}";
        }
    }
}
