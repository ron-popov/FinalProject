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
            UpdateStatus();
        }

        private void UpButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MovePrevious();
            UpdateStatus();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MoveLast();
            UpdateStatus();
        }

        private void DownButton_Click(object sender, EventArgs e)
        {
            tProjectRequestsBindingSource.MoveNext();
            UpdateStatus();
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
            // TODO : Set the default value of projectRequestManagmentApproved to 0

            tProjectRequestsBindingSource.EndEdit();
            this.tProjectRequestsTableAdapter.Update(this.databaseDataSet.tProjectRequests);
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.tProjectRequestsTableAdapter.Fill(this.databaseDataSet.tProjectRequests);
            tProjectRequestsDataGridView.Refresh();
        }

        private void UpdateStatus()
        {
            // TODO : Handle edge cases (no project request selected and stuff like that).

            int projectId = int.Parse(projectRequestIdTextBox.Text);
            foreach (DataRow row in this.databaseDataSet.tProjectRequests.Rows)
            {
                if((int)row["projectRequestId"] == projectId)
                {
                    //This is our project request

                    statusTextBox.Text = (int)row["projectRequestManagmentApproved"] == 0 ? "Not Approved" : "Approved";
                    return;
                }
            }

            statusTextBox.Text = "";
        }

        private void managerApprovedButton_Click(object sender, EventArgs e)
        {
            // TODO : Implement this
            // Just set projectRequestManagmentApproved to 1 and call the same code
            // as in the update button handler
        }
    }
}
