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

        private void tProjectRequestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tProjectRequestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P1ProjectRequestsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tWorkers' table. You can move, or remove it, as needed.
            this.tWorkersTableAdapter.Fill(this.databaseDataSet.tWorkers);
            // TODO: This line of code loads data into the 'databaseDataSet.tCostumers' table. You can move, or remove it, as needed.
            this.tCostumersTableAdapter.Fill(this.databaseDataSet.tCostumers);
            // TODO: This line of code loads data into the 'databaseDataSet.tProjectRequests' table. You can move, or remove it, as needed.
            this.tProjectRequestsTableAdapter.Fill(this.databaseDataSet.tProjectRequests);

        }

        private void FirstButton_Click_1(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MoveFirst();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MovePrevious();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MoveLast();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MoveNext();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.AddNew();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.RemoveCurrent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.EndEdit();
            this.tProjectRequestsTableAdapter.Update(this.databaseDataSet.tProjectRequests);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.tProjectRequestsTableAdapter.Fill(this.databaseDataSet.tProjectRequests);
            tProjectRequestsDataGridView.Refresh();
        }
    }
}
