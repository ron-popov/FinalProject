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

            foreach(DataRow row in databaseDataSet.Projects.Rows)
            {
                comboBox1.Items.Add(row["ProjectName"].ToString());
            }

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                comboBox2.Items.Add(row["WorkerName"].ToString());
            }

            UpdateProjectComboBox();
            UpdateWorkerComboBox();


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

            UpdateProjectComboBox();
            UpdateWorkerComboBox();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.databaseDataSet.Tests);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (projectIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Project Id Cannot be empty");
                return;
            }

            if (workerIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Worker Id Cannot be empty");
                return;
            }

            testsBindingSource.EndEdit();

            // TODO: This line of code loads data into the 'databaseDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Update(this.databaseDataSet.Tests);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            testsBindingSource.MoveFirst();

            UpdateProjectComboBox();
            UpdateWorkerComboBox();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            testsBindingSource.MoveLast();

            UpdateProjectComboBox();
            UpdateWorkerComboBox();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            testsBindingSource.MovePrevious();

            UpdateProjectComboBox();
            UpdateWorkerComboBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            testsBindingSource.MoveNext();

            UpdateProjectComboBox();
            UpdateWorkerComboBox();
        }

        private void projectIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void workerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void projectIdLabel_Click(object sender, EventArgs e)
        {

        }

        private void UpdateBugCount()
        {
            int testId = -1;
            try
            {
                testId = int.Parse(testIdTextBox.Text);
            }
            catch
            {
                textBox1.Text = "";
                return;
            }

            int count = 0;

            foreach (DataRow row in databaseDataSet.BugsToTests)
            {
                if ((int)row["TestId"] == testId)
                {
                    count++;
                }
            }

            textBox1.Text = count.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                return;
            }

            string projectName = comboBox1.SelectedItem.ToString();

            foreach(DataRow row in databaseDataSet.Projects)
            {
                if(row["ProjectName"].ToString().Equals(projectName))
                {
                    projectIdTextBox.Text = row["ProjectId"].ToString();
                    return;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                return;
            }

            string workerName = comboBox2.SelectedItem.ToString();

            foreach (DataRow row in databaseDataSet.Workers)
            {
                if (row["WorkerName"].ToString().Equals(workerName))
                {
                    workerIdTextBox.Text = row["WorkerId"].ToString();
                    return;
                }
            }
        }

        private void UpdateProjectComboBox()
        {
            int id = -1;
            try
            {
                id = int.Parse(projectIdTextBox.Text);
            }
            catch(Exception)
            {

            }

            foreach(DataRow row in databaseDataSet.Projects.Rows)
            {
                if((int)row["ProjectId"] == id)
                {
                    string projectName = row["ProjectName"].ToString();

                    for(int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if(comboBox1.Items[i].ToString().Equals(projectName))
                        {
                            comboBox1.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }

        }

        private void UpdateWorkerComboBox()
        {
            int id = -1;
            try
            {
                id = int.Parse(workerIdTextBox.Text);
            }
            catch (Exception)
            {

            }

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                if ((int)row["WorkerId"] == id)
                {
                    string WorkerName = row["WorkerName"].ToString();

                    for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        if (comboBox2.Items[i].ToString().Equals(WorkerName))
                        {
                            comboBox2.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }

        }

        private void testIdTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateBugCount();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult prbutton = printDialog1.ShowDialog();
            if (prbutton.Equals(DialogResult.OK))
            {
                printDocument1.Print();
            }
        }

        private void workerIdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
