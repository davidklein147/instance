using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class ShipStudent: Student
    {
        int sumShip;
        public ShipStudent(string name, long ID, int sumShip):base(name,ID)
        {
            this.sumShip = sumShip;
            tuition = CalculetToition();
        }

        public ShipStudent(ShipStudent sh): this(sh.name, sh.ID, sh.sumShip)
        {

        }
        public override int CalculetToition()
        {
            return base.CalculetToition()-sumShip;
        }
    }
}
