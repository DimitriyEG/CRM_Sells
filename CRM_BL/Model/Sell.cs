using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class Sell
    {
        public int SellID { get; set; }
        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
