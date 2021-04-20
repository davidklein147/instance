using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class  Student
    {
        public string name;
        public long ID;
        public int tuition;
        public Student(string name, long ID)
        {
            this.name = name;
            this.ID = ID;
            tuition = CalculetToition();
        }
        public virtual int CalculetToition()
        {
            return 10000;
        }
        public override string ToString()
        {
            return $"student {name} ID: {ID}\n" +
                $"sum tuition {CalculetToition()}";
        }
    }
}
