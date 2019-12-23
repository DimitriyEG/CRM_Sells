using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRM_BL.Model;

namespace CRM_UI
{
    public partial class Main : Form
    {
        CrmContext db;
        
        public Main()
        {
            InitializeComponent();
            db = new CrmContext();
        }

        private void AddProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new AddProduct();
            if(form.ShowDialog() == DialogResult.OK)
            {
                db.Products.Add(form.Product);
                db.SaveChanges(); 
            }
        }

        private void ShowProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var productHandbook = new Handbook<Product>(db.Products);
            productHandbook.Show();
        }

        private void AddSellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var form = new AddSeller();
            if (form.ShowDialog() == DialogResult.OK)
            {
                db.Sellers.Add(form.Seller);
                db.SaveChanges();
            }
        }

        private void ShowSellerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sellerHandbook = new Handbook<Seller>(db.Sellers);
            sellerHandbook.Show();
        }

        private void AddCustomerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var form = new AddCustomer();
            if(form.ShowDialog() == DialogResult.OK)
            {
                db.Customers.Add(form.Customer);
                db.SaveChanges();
            }
        }

        private void ShowCustomerToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var customerHandbook = new Handbook<Customer>(db.Customers);
            customerHandbook.Show();
        }

        private void ShowOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var orderHandbook = new Handbook<Order>(db.Orders);
            orderHandbook.Show();
        }
    }
}
