using CRM_BL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_UI
{
    public partial class AddSeller : Form
    {
        public Seller Seller { get; set; }
        public AddSeller()
        {
            InitializeComponent();
        }

        private void SellerAdd_Click(object sender, EventArgs e)
        {
            Seller = new Seller
            {
                Name = SellerName.Text
            };
            Close();
        }
    }
}
