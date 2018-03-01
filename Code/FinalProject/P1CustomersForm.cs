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
    public partial class P1CustomersForm : Form
    {
        public P1CustomersForm()
        {
            InitializeComponent();
        }

        private void tCostumersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tCostumersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P1CustomersForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tCostumers' table. You can move, or remove it, as needed.
            this.tCostumersTableAdapter.Fill(this.databaseDataSet.tCostumers);

        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            tCostumersBindingSource.MoveFirst();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            tCostumersBindingSource.MovePrevious();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            tCostumersBindingSource.MoveLast();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            tCostumersBindingSource.MoveNext();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            tCostumersBindingSource.AddNew();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            tCostumersBindingSource.EndEdit();
            this.tCostumersTableAdapter.Update(this.databaseDataSet.tCostumers);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.tCostumersTableAdapter.Fill(this.databaseDataSet.tCostumers);
            tCostumersDataGridView.Refresh();
        }
    }
}
