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
    }
}
