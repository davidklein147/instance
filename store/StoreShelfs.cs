using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class StoreShelfs
    {
        
        private List<Product> last = new List<Product>();
        private List<IFridge> fridges = new List<IFridge>();
        private List<IFridge> fridges1 = new List<IFridge>();
        public List<Product> dounger = new List<Product>();
        public List<Electrical> electri = new List<Electrical>();
        public List<Product> other = new List<Product>();

        public void sortFridge(Food foo)
        { 
            Milk mi = (Milk)foo;
            if (mi.isGoodTemp)
            {
                fridges.Add(mi);
            }
            else
            {
                fridges1.Add(mi);
            }           
        }
        public void SortLestDate(Product pro)
        {
            last.Add(pro);
        }
        
        public int countFridge()
        {
            return fridges.Count();
        }
        public int countFridge1()
        {
            return fridges1.Count();
        }
        public int countlast()
        {
            return last.Count();
        }
        public int countdounger()
        {
            return dounger.Count();
        }
        public int ConuntElctri()
        {
            return electri.Count();
        }
        public int ConuntOther()
        {
            return other.Count();
        }
    }
}
