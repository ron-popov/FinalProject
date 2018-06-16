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

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void P1Customers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
            // TODO: This line of code loads data into the 'databaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);
            // TODO: This line of code loads data into the 'databaseDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.databaseDataSet.Customers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            customersBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Customers.Rows)
            {
                int id = int.Parse(row["CustomerId"].ToString());
                
                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            customerIdTextBox.Text = max.ToString();

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
            // Making sure all of the fields are not empty
            if (customerAddressTextBox.Text.Length == 0)
            {
                MessageBox.Show("Customer address cannot be empty");
                return;
            }

            if (customerIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Customer id cannot be empty");
                return;
            }

            if (customerNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Customer name cannot be empty");
                return;
            }

            if (customerPhoneMaskedTextBox.Text.Length == 0)
            {
                MessageBox.Show("Customer phone cannot be empty");
                return;
            }

            // Checking if the customerId is valid
            try
            {
                int id = int.Parse(customerIdTextBox.Text);
            }
            catch(Exception)
            {
                MessageBox.Show("Id is not valid");
                return;
            }

            List<int> idList = new List<int>();

            // Checking for customer id duplicates
            foreach(DataRow row in databaseDataSet.Customers.Rows)
            {
                int id = (int)(row["CustomerId"]);
                if(idList.Contains(id))
                {
                    MessageBox.Show("Id Duplicated found, please remove duplicate before saving");
                    return;
                }

                idList.Add(id);
            }

            // Save to database
            this.customersBindingSource.EndEdit();
            this.customersTableAdapter.Update(this.databaseDataSet.Customers);

            MessageBox.Show("Saved !");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveLast();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveNext();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            customersBindingSource.MovePrevious();
        }

        private void customerIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            int customerId = -1;
            try
            {
                customerId = int.Parse(customerIdTextBox.Text);
            }
            catch
            {
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            int projectsCount = 0;
            int totalPrice = 0;
            HashSet<int> orders = new HashSet<int>();

            foreach(DataRow row in databaseDataSet.Orders.Rows)
            {
                if((int)row["CustomerId"] == customerId)
                {
                    orders.Add((int)row["OrderId"]);
                }
            }

            foreach(DataRow row in databaseDataSet.Projects.Rows)
            {
                if(orders.Contains((int)row["OrderId"]))
                {
                    projectsCount++;
                    totalPrice += (int)row["ProjectPrice"];
                }
            }

            textBox1.Text = projectsCount.ToString();
            textBox2.Text = totalPrice.ToString();
        }

        private void customerNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerPhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerPhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void customerAddressLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerAddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }           
}
        