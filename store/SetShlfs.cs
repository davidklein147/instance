using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    class SetShlfs
    {
        public StoreShelfs shelf = new StoreShelfs();
        public void SetProtuct(Product pro)
        {
            Console.WriteLine(pro);
            if (pro is Food)
            {
               Food pro1 = (Food)pro;
                if (pro1.isFredge)
                {
                    shelf.sortFridge(pro1);
                }
                else if (pro is ILastDate)

                    shelf.SortLestDate(pro);
                else
                {
                    shelf.other.Add(pro1);
                }

            } 
            else if (pro is Houseware)
            {
                Houseware home = (Houseware)pro;
                if (home.breakable)
                {
                    shelf.dounger.Add(home);
                }
                else if (pro is Electrical)
                {
                    Electrical electri = (Electrical)pro;
                    shelf.electri.Add(electri);
                }
                else
                {
                    shelf.other.Add(home);
                }
            }
            else if(pro is Cleaners)
            {
                Cleaners clean = (Cleaners)pro;
                if (clean.dangerous)
                {
                    shelf.dounger.Add(clean);
                }
                else if (pro is ILastDate)
                {
                    shelf.SortLestDate(pro);
                }
                else
                {
                    shelf.other.Add(clean);
                }
            }          
            else
            {
                shelf.other.Add(pro);
            }


        }
    }
}
