using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbapyInc
{
    public partial class P1Customers : Form
    {
        public P1Customers()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P1Customers_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.databaseDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.databaseDataSet.Customers);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.databaseDataSet.Customers);
        }
    }
}
