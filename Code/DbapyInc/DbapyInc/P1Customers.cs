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
            // Making sure all of the fields are not empty
            if (customerAddressTextBox.Text.Length > 0)
            {
                MessageBox.Show("Customer address cannot be empty");
                return;
            }

            if (customerIdTextBox.Text.Length > 0)
            {
                MessageBox.Show("Customer id cannot be empty");
                return;
            }

            if (customerNameTextBox.Text.Length > 0)
            {
                MessageBox.Show("Customer name cannot be empty");
                return;
            }

            if (customerPhoneMaskedTextBox.Text.Length > 0)
            {
                MessageBox.Show("Customer phone cannot be empty");
                return;
            }

            // Checking if the customerId is valid
            int id = -1;
            try
            {
                id = int.Parse(customerIdTextBox.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Id is not valid");
                return;
            }

            // Checking if the customerId exists
            foreach(DataRow row in databaseDataSet.Customers.Rows)
            {
                if((int)(row["Customerid"]) == id)
                {
                    MessageBox.Show("Id already exists");
                    return;
                }
            }

            // Save to database
            this.customersBindingSource.EndEdit();
            this.customersTableAdapter.Update(this.databaseDataSet.Customers);
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
    }           
}
        