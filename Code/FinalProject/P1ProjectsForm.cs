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
    public partial class P1ProjectsForm : Form
    {
        public P1ProjectsForm()
        {
            InitializeComponent();
        }

        private void P1ProjectsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tProjectRequests' table. You can move, or remove it, as needed.
            this.tProjectRequestsTableAdapter.Fill(this.databaseDataSet.tProjectRequests);
            // TODO: This line of code loads data into the 'databaseDataSet.tCostumers' table. You can move, or remove it, as needed.
            this.tCostumersTableAdapter.Fill(this.databaseDataSet.tCostumers);
            // TODO: This line of code loads data into the 'databaseDataSet.tWorkers' table. You can move, or remove it, as needed.
            this.tWorkersTableAdapter.Fill(this.databaseDataSet.tWorkers);
            // TODO: This line of code loads data into the 'databaseDataSet.tProjects' table. You can move, or remove it, as needed.
            this.tProjectsTableAdapter.Fill(this.databaseDataSet.tProjects);

        }

        private void tProjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tProjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.MoveLast();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Fetching the project request id of the selected project request
            int projectRequestId;
            try
            {
                projectRequestId = (int)comboBox1.SelectedValue;
            }
            catch
            {
                return;
            }

            // Finding the DataRow associated with the project request
            foreach(DataRow row in databaseDataSet.tProjectRequests.Rows)
            {
                if((int)row[0] == projectRequestId)
                {
                    // After we found the data row associated with the project request
                    // we set the content of the textbox to the description of the textbox
                    richTextBox1.Text = row[3].ToString();
                    return;
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Did the managment approve this projet ?", "Managment Approval Dialog", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                MessageBox.Show("A manager has to approve this project request first");
                return;
            }

            //Fetching the project request id of the selected project request
            int projectRequestId;
            try
            {
                projectRequestId = (int)comboBox1.SelectedValue;
            }
            catch
            {
                return;
            }


            int customerId = -1;
            string name = null;
            string description = null;
            int managerId = (int)comboBox2.SelectedValue;

            bool found = false;

            // TODO : Fetch values from table

            foreach(DatabaseDataSet.tProjectRequestsRow r in databaseDataSet.tProjectRequests.Rows)
            {
                if (((int)r["projectRequestId"]).Equals(projectRequestId))
                {
                    if(found)
                    {
                        MessageBox.Show("this project already exists");
                        return;
                    }

                    name = r["projectRequestName"].ToString();
                    description = r["projectRequestDescription"].ToString();
                    customerId = int.Parse(r["projectRequestCustomerId"].ToString());

                    found = true;
                }
            }

            if (!found)
            {
                MessageBox.Show("Project Request not found");
                return;
            }

            // Adding values to table
            DatabaseDataSet.tProjectsRow row = this.databaseDataSet.tProjects.NewtProjectsRow();

            row["projectName"] = name;
            row["projectManagerId"] = managerId;
            row["customerId"] = customerId;
            row["projectRequestId"] = projectRequestId;
            row["projectDescirption"] = description;

            databaseDataSet.tProjects.AddtProjectsRow(row);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.EndEdit();

            this.tProjectsTableAdapter.Update(this.databaseDataSet.tProjects);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tProjectsTableAdapter.Fill(this.databaseDataSet.tProjects);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this project ?", "Confirmation Dialog", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                MessageBox.Show("Action canceled");
            }
            else
            {
                MessageBox.Show("Project Deleted");
                tProjectsBindingSource.RemoveCurrent();
            }

        }
    }
}
