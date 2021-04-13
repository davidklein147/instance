using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace university
{
    class FamilyStudent : Student
    {
        int level;
        public FamilyStudent(string name, long ID, int level):base(name, ID)
        {
            this.level = level;
        }

        public FamilyStudent(FamilyStudent fam):this(fam.name, fam.ID, fam.level)
        {

        }
        public override int CalculetToition()
        {
            switch (level)
            {
                case 1:
                    return base.CalculetToition() / 2;
                case 2:
                    return base.CalculetToition() / 4;
                case 3:
                    return 0;
                
            }
            return base.CalculetToition();
        }
    }
}
