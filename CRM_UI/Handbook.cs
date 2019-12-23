using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM_UI
{
    public partial class Handbook<T> : Form where T: class
    {
        public Handbook(DbSet<T> set)
        {
            InitializeComponent();
            dataGridView1.DataSource = set.Local.ToBindingList();
            
        }
        //private void Handbook_Load(object sender, EventArgs e)
        //{

        //}

        private void Handbook_Load_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



    }
}
