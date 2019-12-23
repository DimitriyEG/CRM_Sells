using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }
        public int SellerID { get; set; }
        public virtual Seller Seller { get; set; }
        public DateTime SalleDate { get; set; }
        public virtual ICollection<Sell> Sells { get; set; }

        public override string ToString()
        {
            return $"№{OrderID} от {SalleDate.ToString("dd.MM.yy hh:mm:ss")}";
        }

    }
}
