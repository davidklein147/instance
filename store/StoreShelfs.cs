using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class StoreShelfs
    {
        
        private List<ILastDate> last = new List<ILastDate>();
        private List<IFridge> fridges = new List<IFridge>();
        
        public static void sortFredge(Food foo)
        {
            Type ty = foo.GetType();
            
        }
    }
}
