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
            // TODO: This line of code loads data into the 'databaseDataSet.BugsToTests' table. You can move, or remove it, as needed.
            this.bugsToTestsTableAdapter.Fill(this.databaseDataSet.BugsToTests);
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

        private void button15_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0;
            int j;
            int x = 100;
            int y = 100;
            int w = 100;
            int h = 30;

            Pen P = new Pen(Brushes.Black, 2.5f);

            while (i < databaseDataSet.Tests.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.Tests.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                i++;
                x += 100;
            }

            e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

            e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

            e.Graphics.DrawString("Bugs Count", new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));



            i = 0;

            while (i < databaseDataSet.Tests.Rows.Count)
            {
                x = 100;
                y += 30;
                w = 100;
                h = 30;
                j = 0;

                while (j < databaseDataSet.Tests.Columns.Count)
                {
                    e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                    e.Graphics.DrawString(databaseDataSet.Tests.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                    j++;

                    x += 100;
                }

                int testId = int.Parse(testIdTextBox.Text);
                int count = 0;

                foreach (DataRow row in databaseDataSet.BugsToTests.Rows)
                {
                    if((int)row["TestId"] == testId)
                    {
                        count++;
                    }
                }

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(count.ToString() , new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                j++;

                x += 100;

                i++;
            }
        }
    }
}
