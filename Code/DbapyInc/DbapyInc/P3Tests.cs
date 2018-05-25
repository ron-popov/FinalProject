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
    public partial class P3Tests : Form
    {
        public P3Tests()
        {
            InitializeComponent();
        }

        private void testsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.testsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P3Tests_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
            // TODO: This line of code loads data into the 'databaseDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.databaseDataSet.Tests);

            testDateDateTimePicker.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            testsBindingSource.AddNew();

            testDateDateTimePicker.Value = DateTime.Today;

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Tests.Rows)
            {
                int id = int.Parse(row["TestId"].ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            testIdTextBox.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            testsBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.databaseDataSet.Tests);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            testsBindingSource.EndEdit();

            // TODO: This line of code loads data into the 'databaseDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Update(this.databaseDataSet.Tests);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            testsBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            testsBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            testsBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            testsBindingSource.MoveNext();
        }

        private void projectIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProjectName();
        }

        private void UpdateWorkerName()
        {
            object selection = workerIdComboBox.SelectedValue;

            if (selection == null)
            {
                textBox2.Text = "";
                return;
            }

            int managerId = (int)selection;

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

        private void UpdateProjectName()
        {
            object selection = projectIdComboBox.SelectedValue;

            if (selection == null)
            {
                textBox1.Text = "";
                return;
            }

            int projectId = (int)selection;

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

        private void workerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWorkerName();
        }
    }
}
