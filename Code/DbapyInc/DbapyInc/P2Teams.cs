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
    public partial class P2Teams : Form
    {
        public P2Teams()
        {
            InitializeComponent();
        }

        private void teamsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.teamsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P2Teams_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
            // TODO: This line of code loads data into the 'databaseDataSet.ProjectComponents' table. You can move, or remove it, as needed.
            this.projectComponentsTableAdapter.Fill(this.databaseDataSet.ProjectComponents);
            // TODO: This line of code loads data into the 'databaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
            // TODO: This line of code loads data into the 'databaseDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.databaseDataSet.Teams);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            teamsBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Teams.Rows)
            {
                int id = int.Parse(row["TeamId"].ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            teamIdTextBox.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            teamsBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.teamsTableAdapter.Fill(this.databaseDataSet.Teams);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (teamIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Teams Id cannot be empty");
                return;
            }

            if (teamNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Teams Name cannot be empty");
                return;
            }

            if (manageridComboBox.Text.Length == 0)
            {
                MessageBox.Show("Manager Id cannot be empty");
                return;
            }

            if (componentIdComboBox.Text.Length == 0)
            {
                MessageBox.Show("Component Id cannot be empty");
                return;
            }

            // Checking for duplicates
            List<int> idList = new List<int>();

            foreach (DataRow row in databaseDataSet.Teams.Rows)
            {
                int id = (int)(row["TeamId"]);
                if (idList.Contains(id))
                {
                    MessageBox.Show("Team Id Duplicated found, please remove duplicate before saving");
                    return;
                }

                idList.Add(id);
            }

            // Saving to database
            teamsBindingSource.EndEdit();
            this.teamsTableAdapter.Update(this.databaseDataSet.Teams);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            teamsBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            teamsBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            teamsBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            teamsBindingSource.MoveNext();
        }

        private void manageridComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateManagerName();
        }

        private void UpdateManagerName()
        {

            object selection = manageridComboBox.SelectedValue;

            if (selection == null)
            {
                textBox1.Text = "";
                return;
            }

            int managerId = (int)selection;

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                if (managerId == (int)row["WorkerId"])
                {
                    textBox1.Text = row["WorkerName"].ToString();
                    return;
                }
            }

            MessageBox.Show("Worker Not Found");
        }

        private void UpdateComponentName()
        {
            object selection = componentIdComboBox.SelectedValue;

            if (selection == null)
            {
                textBox2.Text = "";
                textBox3.Text = "";
                return;
            }

            int componentId = (int)selection;

            foreach (DataRow row in databaseDataSet.ProjectComponents.Rows)
            {
                if (componentId == (int)row["ComponentId"])
                {
                    textBox2.Text = row["ComponentName"].ToString();

                    int ProjectId = (int)row["ProjectId"];

                    foreach (DataRow r in databaseDataSet.Projects.Rows)
                    {
                        if (ProjectId == (int)r["ProjectId"])
                        {
                            textBox3.Text = r["ProjectName"].ToString();
                        }
                    }

                    return;
                }
            }

            MessageBox.Show("Component Not Found");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void componentIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateComponentName();
        }
    }
}
