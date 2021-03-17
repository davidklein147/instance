using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
    interface ILastDate
    {
        public string LastDate { set; }
        public string Date(string date);
        
    }
}
