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
    public partial class P4Surveys : Form
    {
        public P4Surveys()
        {
            InitializeComponent();
        }

        private void surveysBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.surveysBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P4Surveys_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
            // TODO: This line of code loads data into the 'databaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
            // TODO: This line of code loads data into the 'databaseDataSet.Surveys' table. You can move, or remove it, as needed.
            this.surveysTableAdapter.Fill(this.databaseDataSet.Surveys);

            // Changing printDocument1 to be in landscape mode
            printDocument1.DefaultPageSettings.Landscape = true;

            // Iterating over workers and adding their names to the workers combobox
            foreach(DataRow row in databaseDataSet.Workers.Rows)
            {
                comboBox1.Items.Add(row["WorkerName"].ToString());
            }


            // Iterating over Projects and adding their names to the Projects combobox
            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                comboBox2.Items.Add(row["ProjectName"].ToString());
            }

            UpdateWorkerComboBox();

        }

        // Handler for the add new button
        private void button1_Click(object sender, EventArgs e)
        {
            surveysBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Surveys.Rows)
            {
                int id = int.Parse(row["SurveyId"].ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            surveyIdTextBox.Text = max.ToString();

            surveyDateDateTimePicker.Value = DateTime.Now;
        }

        // handler for the remove button
        private void button2_Click(object sender, EventArgs e)
        {
            surveysBindingSource.RemoveCurrent();


            UpdateWorkerComboBox();
        }

        // Handler for the first button
        private void button8_Click(object sender, EventArgs e)
        {
            surveysBindingSource.MoveFirst();


            UpdateWorkerComboBox();
        }

        // handler for the last button
        private void button6_Click(object sender, EventArgs e)
        {
            surveysBindingSource.MoveLast();


            UpdateWorkerComboBox();
        }

        // handler for the up button
        private void button7_Click(object sender, EventArgs e)
        {
            surveysBindingSource.MovePrevious();

            UpdateWorkerComboBox();
        }

        // handler for the down button
        private void button5_Click(object sender, EventArgs e)
        {
            surveysBindingSource.MoveNext();


            UpdateWorkerComboBox();
        }

        // Sets the content of printDocument1
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            int i = 0;
            int j;
            int x = 100;
            int y = 200;
            int w = 100;
            int h = 30;

            Pen P = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(0, 0));

            e.Graphics.DrawString("דוח סקרים", new Font("Ariel", 30, FontStyle.Bold), Brushes.Blue, new Point(300, 100));

            while (i < databaseDataSet.Surveys.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.Surveys.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                i++;
                x += 100;
            }

            i = 0;

            while (i < databaseDataSet.Surveys.Rows.Count)
            {
                x = 100;
                y += 30;
                w = 100;
                h = 30;
                j = 0;


                while (j < databaseDataSet.Surveys.Columns.Count)
                {
                    e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                    e.Graphics.DrawString(databaseDataSet.Surveys.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                    j++;

                    x += 100;
                }

                i++;
            }
        }

        // Handler for the show report button
        private void button14_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
        }
        
        // Updates the selected combobox item according to the project id
        private void UpdateProjectCombobox()
        {
            if (projectIdTextBox.Text.Length == 0)
            {
                return;
            }

            int projectId = int.Parse(projectIdTextBox.Text);

            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                if ((int)row["ProjectId"] == projectId)
                {
                    string projectName = row["ProjectName"].ToString();
                    for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        if (projectName.Equals(comboBox2.Items[i]))
                        {
                            comboBox2.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }
        }

        // Updates the content of the project id text box according to the combobox item selected
        private void UpdateProjectIdTextBox()
        {
            if (comboBox2.SelectedItem == null)
            {
                return;
            }

            string projectname = comboBox2.SelectedItem.ToString();

            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                if (projectname.Equals(row["ProjectName"].ToString()))
                {
                    projectIdTextBox.Text = row["ProjectId"].ToString();
                    return;
                }
            }
        }

        // Updates the selected combobox item according to the worker id
        private void UpdateWorkerComboBox()
        {
            UpdateProjectCombobox();

            if (workerIdTextBox.Text.Length == 0)
            {
                return;
            }

            int workerId = int.Parse(workerIdTextBox.Text);

            foreach(DataRow row in databaseDataSet.Workers.Rows)
            {
                if((int)row["WorkerId"] == workerId)
                {
                    string workerName = row["WorkerName"].ToString();
                    for(int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if(workerName.Equals(comboBox1.Items[i]))
                        {
                            comboBox1.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }
        }

        // Updates the content of the worker id text box according to the combobox item selected
        private void UpdateWorkerIdTextBox()
        {
            if (comboBox1.SelectedItem == null)
            {
                return;
            }

            string workerName = comboBox1.SelectedItem.ToString();

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                if (workerName.Equals(row["WorkerName"].ToString()))
                {
                    workerIdTextBox.Text = row["WorkerId"].ToString();
                    return;
                }
            }
        }

        // Handler for the worker id selection event
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWorkerIdTextBox();
        }

        // Handler for the Project id selection event
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProjectIdTextBox();
        }

        // handler for the save button
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

            if (q1ComboBox.Text.Length == 0)
            {
                MessageBox.Show("Q1 Answer Cannot be empty");
                return;
            }

            if (q1ComboBox.Text.Length == 0)
            {
                MessageBox.Show("Q2 Answer Cannot be empty");
                return;
            }

            if (q1ComboBox.Text.Length == 0)
            {
                MessageBox.Show("Q3 Answer Cannot be empty");
                return;
            }

            if (q1ComboBox.Text.Length == 0)
            {
                MessageBox.Show("Q4 Answer Cannot be empty");
                return;
            }

            surveysBindingSource.EndEdit();
            this.surveysTableAdapter.Update(this.databaseDataSet.Surveys);
        }

        // handler for the update from database button
        private void button3_Click(object sender, EventArgs e)
        {
            this.surveysTableAdapter.Fill(this.databaseDataSet.Surveys);


            UpdateWorkerComboBox();

        }

        private void button15_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult prbutton = printDialog1.ShowDialog();
            if(prbutton.Equals(DialogResult.OK))
            {
                printDocument1.Print();
            }
        }
    }
}
