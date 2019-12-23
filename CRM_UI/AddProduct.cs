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
    public partial class AddProduct : Form
    {
        public Product Product { get; set; }
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProductAccept_Click(object sender, EventArgs e)
        {
            Product = new Product
            {
                Name = AddNameBox.Text,
                Price = AddPriceBox.Value,
                Count = Convert.ToInt32(AddCountBox.Value)
            };
            Close();
        }
    }
}
