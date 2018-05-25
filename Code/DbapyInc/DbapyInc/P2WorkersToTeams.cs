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
    public partial class P2WorkersToTeams : Form
    {
        public P2WorkersToTeams()
        {
            InitializeComponent();
        }

        private void P2WorkersToTeams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
            // TODO: This line of code loads data into the 'databaseDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.databaseDataSet.Teams);
            // TODO: This line of code loads data into the 'databaseDataSet.WorkersToTeams' table. You can move, or remove it, as needed.
            this.workersToTeamsTableAdapter.Fill(this.databaseDataSet.WorkersToTeams);

        }

        private void workersToTeamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersToTeamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            workersToTeamsBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workersToTeamsBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.workersToTeamsTableAdapter.Fill(this.databaseDataSet.WorkersToTeams);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (teamIdComboBox.Text.Length == 0)
            {
                MessageBox.Show("Team Id Number cannot be empty");
                return;
            }

            if (workerIdComboBox.Text.Length == 0)
            {
                MessageBox.Show("Worker Id Number cannot be empty");
                return;
            }

            // Checking for duplicates
            HashSet<string> set = new HashSet<string>();

            foreach (DataRow row in databaseDataSet.WorkersToTeams.Rows)
            {
                int workerId = (int)(row["WorkerId"]);
                int teamId = (int)(row["TeamId"]);

                string pair = workerId + ":" + teamId;

                if (set.Contains(pair))
                {
                    MessageBox.Show("Duplicate found, please remove before saving");
                    return;
                }

                set.Add(pair);
            }

            // Save to database
            workersToTeamsBindingSource.EndEdit();
            this.workersToTeamsTableAdapter.Update(this.databaseDataSet.WorkersToTeams);

            MessageBox.Show("Saved !");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            workersToTeamsBindingSource.MoveFirst();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            workersToTeamsBindingSource.MoveNext();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            workersToTeamsBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            workersToTeamsBindingSource.MovePrevious();
        }

        private void workerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWorkerName();
        }

        private void UpdateTeamName()
        {
            object selection = teamIdComboBox.SelectedValue;

            if (selection == null)
            {
                textBox1.Text = "";
                return;
            }

            int teamId = (int)selection;

            foreach (DataRow row in databaseDataSet.Teams.Rows)
            {
                if (teamId == (int)row["TeamId"])
                {
                    textBox1.Text = row["TeamName"].ToString();
                    return;
                }
            }

            MessageBox.Show("Team Not Found");
        }

        private void UpdateWorkerName()
        {
            object selection = workerIdComboBox.SelectedValue;

            if (selection == null)
            {
                textBox2.Text = "";
                return;
            }

            int workerId = (int)selection;

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                if (workerId == (int)row["WorkerId"])
                {
                    textBox2.Text = row["WorkerName"].ToString();
                    return;
                }
            }

            MessageBox.Show("Worker Not Found");
        }

        private void teamIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTeamName();
        }
    }
}
