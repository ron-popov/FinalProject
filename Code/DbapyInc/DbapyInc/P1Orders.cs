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

        
        private void P1Orders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
            // TODO: This line of code loads data into the 'databaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.databaseDataSet.Customers);
            // TODO: This line of code loads data into the 'databaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);

            UpdateCustomerName();
            UpdatePrice();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ordersBindingSource.AddNew();

            orderDateDateTimePicker.MinDate = DateTime.Today;
            orderDateDateTimePicker.MaxDate = DateTime.Today;

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Orders.Rows)
            {
                int id = int.Parse(row["OrderId"].ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            orderIdTextBox.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customersBindingSource.RemoveCurrent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(orderIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Order Id Cannot be empty");
                return;
            }

            if (customerIdComboBox.Text.Length == 0)
            {
                MessageBox.Show("Order Id Cannot be empty");
                return;
            }

            orderDateDateTimePicker.Value = DateTime.Now;

            // Checking for duplicates
            List<int> idList = new List<int>();

            foreach (DataRow row in databaseDataSet.Orders.Rows)
            {
                int id = (int)(row["OrderId"]);
                if (idList.Contains(id))
                {
                    MessageBox.Show("Order Id Duplicated found, please remove duplicate before saving");
                    return;
                }

                idList.Add(id);
            }

            // Saving to database
            customersBindingSource.EndEdit();
            this.customersTableAdapter.Update(this.databaseDataSet.Customers);

            MessageBox.Show("Saved !");
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
            /*string customerName = textBox1.Text;

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
            }*/
        }

        private void UpdateCustomerName()
        {
            object selection = customerIdComboBox.SelectedValue;
            if (selection == null)
            {
                textBox2.Text = "";
                return;
            }

            int customerId = (int)selection;

            foreach (DataRow row in databaseDataSet.Customers.Rows)
            {
                if ((int)row["CustomerId"] == customerId)
                {
                    textBox2.Text = row["CustomerName"].ToString();
                    return;
                }
            }

            MessageBox.Show("Customer Id Not Found");
        }

        private void UpdatePrice()
        {
            string selection = orderIdTextBox.Text;
            if (selection.Length == 0)
            {
                textBox1.Text = "";
                return;
            }

            int orderId = int.Parse(selection);

            int priceCounter = 0;

            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                if((int)row["OrderId"] == orderId)
                {
                    priceCounter += (int)row["ProjectPrice"];
                }
            }

            textBox1.Text = priceCounter.ToString();
        }
        
        private void customerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateCustomerName();
        }

        private void orderIdTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
