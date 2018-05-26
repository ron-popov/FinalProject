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
    public partial class P2Workers : Form
    {
        public P2Workers()
        {
            InitializeComponent();

        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P2Workers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.ProjectComponents' table. You can move, or remove it, as needed.
            this.projectComponentsTableAdapter.Fill(this.databaseDataSet.ProjectComponents);
            // TODO: This line of code loads data into the 'databaseDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.databaseDataSet.Teams);
            // TODO: This line of code loads data into the 'databaseDataSet.WorkersToTeams' table. You can move, or remove it, as needed.
            this.workersToTeamsTableAdapter.Fill(this.databaseDataSet.WorkersToTeams);
            // TODO: This line of code loads data into the 'databaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);

            UpdateWorkerDetails();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            workersBindingSource.AddNew();

            workerJoinDateDateTimePicker.Value = DateTime.Now;


            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                int id = int.Parse(row["WorkerId"].ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            workerIdTextBox.Text = max.ToString();

            UpdateWorkerDetails();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workersBindingSource.RemoveCurrent();
            UpdateWorkerDetails();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
            UpdateWorkerDetails();
        }

        private void button4_Click(object sender, EventArgs e)
        {




            // Check if the worker is 18 yet
            DateTime birthDate = workerBirthDateDateTimePicker.Value;
            TimeSpan age = DateTime.Now - birthDate;

            if (age.TotalDays < 18*365 && DateTime.Now > birthDate)
            {
                MessageBox.Show("You have to be 18 to work here");
                return;
            }


            // Looking for empty fields
            if (workerIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Worker Id cannot be empty");
                return;
            }

            if (workerNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Worker Name cannot be empty");
                return;
            }

            if (workerPhoneMaskedTextBox.Text.Length == 0)
            {
                MessageBox.Show("Worker Phone Number cannot be empty");
                return;
            }

            if (workerAddressTextBox.Text.Length == 0)
            {
                MessageBox.Show("Worker address cannot be empty");
                return;
            }

            // Checking for duplicates
            List<int> idList = new List<int>();

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                int id = (int)(row["WorkerId"]);
                if (idList.Contains(id))
                {
                    MessageBox.Show("Worker Id Duplicated found, please remove duplicate before saving");
                    return;
                }

                idList.Add(id);
            }

            // Save everything to the database
            workersBindingSource.EndEdit();
            this.workersTableAdapter.Update(this.databaseDataSet.Workers);

            MessageBox.Show("Saved !");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveFirst();
            UpdateWorkerDetails();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveLast();
            UpdateWorkerDetails();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            workersBindingSource.MovePrevious();
            UpdateWorkerDetails();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveNext();
            UpdateWorkerDetails();
        }

        private void workerPhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void workerBirthDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void workerBirthDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            DataView dv = new DataView(databaseDataSet.Workers);
            dv.RowFilter = "WorkerName Like '%" + name + "%'";
            workersDataGridView.DataSource = dv;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(databaseDataSet.Workers);
            workersDataGridView.DataSource = dv;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string id = textBox2.Text;

            DataView dv = new DataView(databaseDataSet.Workers);
            dv.RowFilter = "WorkerId = " + id;
            workersDataGridView.DataSource = dv;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UpdateWorkerDetails()
        {
            if (workerIdTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please select worker first");
                textBox3.Text = "";
                return;
            }

            // Calculate years of experience
            TimeSpan Experience = DateTime.Now - workerJoinDateDateTimePicker.Value;
            textBox3.Text = ((Experience).Days / 365).ToString();

            // Calculate years of experience
            TimeSpan Age = DateTime.Now - workerBirthDateDateTimePicker.Value;
            textBox4.Text = ((Age).Days / 365).ToString();

            listBox1.Items.Clear();

            // Find worker teams
            foreach (DataRow r in databaseDataSet.WorkersToTeams)
            {
                if (r["WorkerId"].ToString().Equals(workerIdTextBox.Text))
                {
                    int teamId = (int)r["TeamId"];

                    foreach (DataRow row in databaseDataSet.Teams.Rows)
                    {
                        if((int)row["TeamId"] == teamId)
                        {
                            listBox1.Items.Add(row["TeamName"].ToString());
                        }
                    }
                }
            }

            int counter = 0;

            foreach(DataRow r1 in databaseDataSet.WorkersToTeams.Rows)
            {
                int teamId = (int)r1["TeamId"];
                int workerId = (int)r1["WorkerId"];

                if (workerId == int.Parse(workerIdTextBox.Text))
                {
                    foreach(DataRow r2 in databaseDataSet.Teams.Rows)
                    {
                        if (teamId == (int)r2["TeamId"])
                        {
                            int componentId = (int)r2["ComponentId"];

                            foreach(DataRow r3 in databaseDataSet.ProjectComponents.Rows)
                            {
                                if((int)r3["ComponentId"] == componentId)
                                {
                                    if(!(bool)r3["Finished"])
                                    {
                                        counter++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            textBox5.Text = counter.ToString();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen p = new Pen(Brushes.Black, 2.5f);

            // Date
            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(0, 0));

            // Title
            e.Graphics.DrawString("דוח עובד", new Font("Arial", 30, FontStyle.Bold), Brushes.Black, new Point(300, 100));

            // Worker fields
            e.Graphics.DrawString(workerIdTextBox.Text + " : קוד עובד", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 150));

            e.Graphics.DrawString(workerNameTextBox.Text + " : שם עובד", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 175));

            e.Graphics.DrawString(workerPhoneMaskedTextBox.Text + " : מספר טלפון עובד", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 200));

            e.Graphics.DrawString(workerAddressTextBox.Text + " : כתובת עובד", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 225));

            e.Graphics.DrawString(workerBirthDateDateTimePicker.Value.ToShortDateString() + " : תאריך לידה עובד", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 250));

            e.Graphics.DrawString(workerJoinDateDateTimePicker.Value.ToShortDateString() + " : תאריך הצטרפות עובד", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 275));

            // Calculate years of experience
            TimeSpan Experience = DateTime.Now - workerJoinDateDateTimePicker.Value;
            string experience = ((Experience).Days / 365).ToString();

            e.Graphics.DrawString(experience + " : שנות וותק עובד", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 300));

            // Calculate years of experience
            TimeSpan Age = DateTime.Now - workerBirthDateDateTimePicker.Value;
            string age = ((Age).Days / 365).ToString();

            e.Graphics.DrawString(age + " : גיל עובד", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(300, 325));



            int i = 0;
            int j;
            int x = 100;
            int y = 600;
            int w = 100;
            int h = 30;

            Pen P = new Pen(Brushes.Black, 2.5f);

            while (i < databaseDataSet.WorkersToTeams.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.WorkersToTeams.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                i++;
                x += 100;
            }

            i = 0;

            y += 30;

            while (i < databaseDataSet.WorkersToTeams.Rows.Count)
            {
                x = 100;
                w = 100;
                h = 30;
                j = 0;

                if (databaseDataSet.WorkersToTeams.Rows[i]["WorkerId"].ToString().Equals(workerIdTextBox.Text))
                {
                    while (j < databaseDataSet.WorkersToTeams.Columns.Count)
                    {

                        e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                        e.Graphics.DrawString(databaseDataSet.WorkersToTeams.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                        j++;

                        x += 100;
                    }

                    y += 30;
                }

                i++;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            DialogResult prbutton = printDialog1.ShowDialog();
            if(prbutton.Equals(DialogResult.OK))
            {
                printDocument1.Print();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();


        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult prbutton = printDialog1.ShowDialog();
            if (prbutton.Equals(DialogResult.OK))
            {
                printDocument2.Print();
            }
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0;
            int j;
            int x = 100;
            int y = 100;
            int w = 100;
            int h = 30;

            Pen P = new Pen(Brushes.Black, 2.5f);

            while (i < databaseDataSet.Workers.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.Workers.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                i++;
                x += 100;
            }

            i = 0;

            while (i < databaseDataSet.Workers.Rows.Count)
            {
                x = 100;
                y += 30;
                w = 100;
                h = 30;
                j = 0;

                while (j < databaseDataSet.Workers.Columns.Count)
                {
                    e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                    e.Graphics.DrawString(databaseDataSet.Workers.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                    j++;

                    x += 100;
                }

                i++;
            }
        }
    }
}
