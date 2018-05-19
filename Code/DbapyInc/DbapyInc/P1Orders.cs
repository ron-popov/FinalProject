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
    public partial class P1Orders : Form
    {
        public P1Orders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P1Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.databaseDataSet.Customers);
            // TODO: This line of code loads data into the 'databaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customersBindingSource.EndEdit();
            this.customersTableAdapter.Update(this.databaseDataSet.Customers);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.databaseDataSet.Customers);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customersBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveNext();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string customerName = textBox1.Text;

            // A list of wanted customer id's
            List<int> customerId = new List<int>();
            
            // Find the customerId with that name
            foreach (DataRow row in databaseDataSet.Customers.Rows)
            {
                if(row["CustomerName"].ToString().ToLower().Contains(customerName.ToLower()))
                {
                    int id = int.Parse(row["CustomerId"].ToString());
                    customerId.Add(id);
                }
            }

            if (customerId.Count == 0)
            {
                MessageBox.Show("Customer with that name not found");
            }
            else
            {
                string query = "";
                foreach(int id in customerId)
                {
                    query += "CustomerId Like ";
                    query += id.ToString();
                    query += " OR ";
                }

                query = query.Remove(query.Length - 4);

                DataView dv = new DataView(databaseDataSet.Customers);
                dv.RowFilter = query;
                ordersDataGridView.DataSource = dv;
            }
        }
    }
}
