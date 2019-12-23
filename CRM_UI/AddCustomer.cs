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
    public partial class AddCustomer : Form
    {
        public Customer Customer { get; set; }
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Customer = new Customer
            {
                Name = CustomerName.Text
            };
            Close();

        }
    }
}
