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

            UpdatePrice();

            foreach(DataRow row in databaseDataSet.Customers)
            {
                comboBox1.Items.Add(row["CustomerName"].ToString());
            }

            UpdateComboBox();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            ordersBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Orders.Rows)
            {
                int id = int.Parse(row["OrderId"].ToString());

                MessageBox.Show(id.ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            orderIdTextBox.Text = max.ToString();


            UpdateComboBox();

            UpdatePrice();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ordersBindingSource.RemoveCurrent();


            UpdateComboBox();

            UpdatePrice();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            orderDateDateTimePicker.Value = DateTime.Now;

            // Saving to database
            ordersBindingSource.EndEdit();

            this.ordersTableAdapter.Update(this.databaseDataSet.Orders);

            MessageBox.Show("Saved !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);

            UpdateComboBox();

            UpdatePrice();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveFirst();

            UpdateComboBox();

            UpdatePrice();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveLast();

            UpdateComboBox();

            UpdatePrice();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MovePrevious();

            UpdateComboBox();

            UpdatePrice();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ordersBindingSource.MoveNext();

            UpdateComboBox();

            UpdatePrice();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string customerName = priceTextBox.Text;

            
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

        private void UpdatePrice()
        {
            string selection = string.Copy(orderIdTextBox.Text);
            if (selection.Length == 0)
            {
                priceTextBox.Text = "";
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

            priceTextBox.Text = priceCounter.ToString();
        }
        
        private void customerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProjectIdTextBox();
        }

        private void customerIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UpdateComboBox()
        {
            if (customerIdTextBox.Text.Length == 0)
            {
                return;
            }

            int projectId = int.Parse(customerIdTextBox.Text);

            foreach (DataRow row in databaseDataSet.Customers.Rows)
            {
                try
                {
                    if (projectId == (int)row["CustomerId"])
                    {
                        comboBox1.Text = row["CustomerName"].ToString();
                        return;
                    }
                }
                catch(DeletedRowInaccessibleException)
                {
                }
            }
        }

        private void UpdateProjectIdTextBox()
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }

            string projectName = comboBox1.SelectedItem.ToString();

            foreach (DataRow row in databaseDataSet.Customers.Rows)
            {
                if (row["CustomerName"].ToString().Equals(projectName))
                {
                    customerIdTextBox.Text = row["CustomerId"].ToString();
                    return;
                }
            }
        }
    }
}
