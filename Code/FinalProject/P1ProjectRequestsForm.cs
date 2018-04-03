using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class P1ProjectRequestsForm : Form
    {
        public P1ProjectRequestsForm()
        {
            InitializeComponent();
        }

        private void P1ProjectRequestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tCostumers' table. You can move, or remove it, as needed.
            this.tCostumersTableAdapter.Fill(this.databaseDataSet.tCostumers);
            // TODO: This line of code loads data into the 'databaseDataSet.tProjectRequests' table. You can move, or remove it, as needed.
            this.tProjectRequestsTableAdapter.Fill(this.databaseDataSet.tProjectRequests);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MovePrevious();
        }

        private void tProjectRequestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tProjectRequestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // This saves the dataset into the database
            this.tProjectRequestsTableAdapter.Update(this.databaseDataSet.tProjectRequests);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Loads data from the database to the dataset
            tProjectRequestsBindingSource.EndEdit();
            this.tProjectRequestsTableAdapter.Fill(this.databaseDataSet.tProjectRequests);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MoveLast();
        }

        private void tProjectRequestsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tProjectRequestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }
    }
}
