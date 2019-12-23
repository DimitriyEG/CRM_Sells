using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM_BL.Model
{
    public class Seller
    {
        public int SellerID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Order> Orders { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
