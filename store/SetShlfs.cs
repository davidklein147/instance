using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class SetShlfs
    {
        public void SetProtuct(Product pro)
        {
            Type ty = pro.GetType().BaseType;

            
            if (typeof(Food) == ty)
            {
               Food pro1 = (Food)pro;
               if(pro1.isFredge) StoreShelfs.sortFredge(pro1);

            }
        }
    }
}
