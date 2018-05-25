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
    public partial class P3BugsToTests : Form
    {
        public P3BugsToTests()
        {
            InitializeComponent();
        }

        private void bugsToTestsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugsToTestsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P3BugsToTests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.databaseDataSet.Tests);
            // TODO: This line of code loads data into the 'databaseDataSet.Bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.databaseDataSet.Bugs);
            // TODO: This line of code loads data into the 'databaseDataSet.BugsToTests' table. You can move, or remove it, as needed.
            this.bugsToTestsTableAdapter.Fill(this.databaseDataSet.BugsToTests);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bugsToTestsBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bugsToTestsTableAdapter.Fill(this.databaseDataSet.BugsToTests);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bugsToTestsBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bugsToTestsBindingSource.EndEdit();
            this.bugsToTestsTableAdapter.Update(this.databaseDataSet.BugsToTests);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bugsToTestsBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bugsToTestsBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bugsToTestsBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bugsToTestsBindingSource.MoveNext();
        }

        private void bugIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void testIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selection = testIdComboBox.SelectedValue;

            if (selection == null)
            {
                return;
            }

            int testId = (int)selection;

            foreach(DataRow row in databaseDataSet.Tests.Rows)
            {
                if ((int)row["TestId"] == testId)
                {
                    UpdateWorkerName((int)row["WorkerId"]);
                    UpdateProjectName((int)row["ProjectId"]);
                }
            }
        }


        private void UpdateWorkerName(int workerId)
        {
            int managerId = workerId;

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                if (managerId == (int)row["WorkerId"])
                {
                    textBox2.Text = row["WorkerName"].ToString();
                    return;
                }
            }

            MessageBox.Show("Worker Not Found");
        }

        private void UpdateProjectName(int projectId)
        {
            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                if (projectId == (int)row["ProjectId"])
                {
                    textBox1.Text = row["ProjectName"].ToString();
                    return;
                }
            }

            MessageBox.Show("Project Not Found");
        }
    }
}
