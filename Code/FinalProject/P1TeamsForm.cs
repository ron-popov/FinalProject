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
        Dictionary<int, string> workerIdToName = new Dictionary<int, string>();

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

            // Building a worker id to name dictionary for fast random access
            foreach(DataRow row in databaseDataSet.tWorkers)
            {
                workerIdToName.Add((int)row["workerId"], (string)row["workerName"]);
            }

            UpdateManagerDetails();
            UpdateTeamMembers();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.MovePrevious();
            UpdateManagerDetails();
            UpdateTeamMembers();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.MoveNext();
            UpdateTeamMembers();
            UpdateManagerDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.MoveFirst();
            UpdateManagerDetails();
            UpdateTeamMembers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tTeamsBindingSource.MoveLast();
            UpdateManagerDetails();
            UpdateTeamMembers();
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
                DataGridViewRow row = tTeamsDataGridView.CurrentRow;
                DataGridViewCell cell = row.Cells[1];
                int managerId = (int)cell.Value;
                string managerName = workerIdToName[managerId];

                ManagerIdTextbox.Text = managerId.ToString();
                ManagerNameTextbox.Text = managerName;
            }
            catch(Exception e)
            {
                MessageBox.Show("Something Went horribly wrong : " + e.ToString());
            }
        }

        private void UpdateTeamMembers()
        {
            teamMembersBox.Items.Clear();

            try
            {
                int teamId = (int)tTeamsDataGridView.CurrentRow.Cells[0].Value;
                foreach (DataRow row in databaseDataSet.tWorkersToTeams.Rows)
                {
                    if((int)row["teamId"] == teamId)
                    {
                        int workerId = (int)row["workerId"];
                        teamMembersBox.Items.Add(workerIdToName[workerId] + " : " + workerId.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error : " + e.ToString());
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int workerId = (int)workersComboBox.SelectedValue;
            int teamId = (int)tTeamsDataGridView.CurrentRow.Cells[0].Value;

            DatabaseDataSet.tWorkersToTeamsRow row = (DatabaseDataSet.tWorkersToTeamsRow)databaseDataSet.tWorkersToTeams.NewRow();
            row["teamId"] = teamId;
            row["workerId"] = workerId;

            databaseDataSet.tWorkersToTeams.AddtWorkersToTeamsRow(row);

            UpdateTeamMembers();

            tWorkersToTeamsBindingSource.EndEdit();
            this.tWorkersToTeamsTableAdapter.Update(this.databaseDataSet.tWorkersToTeams);

        }
        
        private string removeSpaces(string text)
        {
            string newText = "";
            foreach(char c in text)
            {
                if(c != ' ')
                {
                    newText += c;
                }
            }

            return newText;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string selectedItemText = "";

            try
            {
                selectedItemText = teamMembersBox.SelectedItem.ToString();
            }
            catch
            {
                MessageBox.Show("Please select a team member and only then remove him");
                return;
            }


            string[] splittedArray = removeSpaces(selectedItemText).Split(new char[1] { ':' });
            int workerId = int.Parse(splittedArray[splittedArray.Length - 1]);

            DatabaseDataSet.tWorkersToTeamsRow row = null;

            foreach(DatabaseDataSet.tWorkersToTeamsRow r in databaseDataSet.tWorkersToTeams)
            {
                // BUG : This won't work as expected if the are multiple workers at multiple teams
                if((int)r[0] == workerId)
                {
                    row = r;
                }
            }
            MessageBox.Show(this.databaseDataSet.tWorkersToTeams.Count.ToString());

            if (row != null)
            {
                MessageBox.Show("Removed row");
                databaseDataSet.tWorkersToTeams.RemovetWorkersToTeamsRow(row);
            }


            UpdateTeamMembers();

            MessageBox.Show(this.databaseDataSet.tWorkersToTeams.Count.ToString());

            tWorkersToTeamsBindingSource.EndEdit();
            this.tWorkersToTeamsTableAdapter.Update(this.databaseDataSet.tWorkersToTeams);
        }
    }
}
