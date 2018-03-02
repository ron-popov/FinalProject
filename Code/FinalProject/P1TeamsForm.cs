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
    public partial class P1TeamsForm : Form
    {
        public P1TeamsForm()
        {
            InitializeComponent();
        }

        private void tTeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tTeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P1TeamsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tWorkersToTeams' table. You can move, or remove it, as needed.
            this.tWorkersToTeamsTableAdapter.Fill(this.databaseDataSet.tWorkersToTeams);
            // TODO: This line of code loads data into the 'databaseDataSet.tWorkers' table. You can move, or remove it, as needed.
            this.tWorkersTableAdapter.Fill(this.databaseDataSet.tWorkers);
            // TODO: This line of code loads data into the 'databaseDataSet.tTeams' table. You can move, or remove it, as needed.
            this.tTeamsTableAdapter.Fill(this.databaseDataSet.tTeams);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.MovePrevious();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.MoveNext();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.MoveFirst();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.MoveLast();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tTeams' table. You can move, or remove it, as needed.
            this.tTeamsTableAdapter.Fill(this.databaseDataSet.tTeams);
            tTeamsDataGridView.Refresh();
        }

        private void UpdateManagerDetails()
        {
            try
            {
                int managerId = (int)tTeamsDataGridView.SelectedRows[0].Cells[1].Value;

                DataRow managerRow = null;

                foreach(DataRow row in this.databaseDataSet.tWorkers.Rows)
                {
                    if((int)row["workerId"] == managerId)
                    {
                        managerRow = row;
                    }
                }

                if(managerRow == null)
                {
                    MessageBox.Show("Input invalid, manager id entered does not exist");
                }

                ManagerNameTextbox.Text = managerRow["workerName"].ToString();
                ManagerIdTextbox.Text = managerRow["workerId"].ToString();
            }
            catch(Exception e)
            {
                MessageBox.Show("Something Went horribly wrong : " + e.ToString());
            }
        }
    }
}
