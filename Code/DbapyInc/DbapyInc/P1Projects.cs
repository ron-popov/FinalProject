﻿using System;
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
    public partial class P1Projects : Form
    {
        public P1Projects()
        {
            InitializeComponent();
        }

        private void projectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P1Projects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Tests' table. You can move, or remove it, as needed.
            this.testsTableAdapter.Fill(this.databaseDataSet.Tests);
            // TODO: This line of code loads data into the 'databaseDataSet.Surveys' table. You can move, or remove it, as needed.
            this.surveysTableAdapter.Fill(this.databaseDataSet.Surveys);
            // TODO: This line of code loads data into the 'databaseDataSet.Teams' table. You can move, or remove it, as needed.
            this.teamsTableAdapter.Fill(this.databaseDataSet.Teams);
            // TODO: This line of code loads data into the 'databaseDataSet.ProjectComponents' table. You can move, or remove it, as needed.
            this.projectComponentsTableAdapter.Fill(this.databaseDataSet.ProjectComponents);
            // TODO: This line of code loads data into the 'databaseDataSet.WorkersToTeams' table. You can move, or remove it, as needed.
            this.workersToTeamsTableAdapter.Fill(this.databaseDataSet.WorkersToTeams);
            // TODO: This line of code loads data into the 'databaseDataSet.ProjectTypes' table. You can move, or remove it, as needed.
            this.projectTypesTableAdapter.Fill(this.databaseDataSet.ProjectTypes);
            // TODO: This line of code loads data into the 'databaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
            // TODO: This line of code loads data into the 'databaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);


            foreach(DataRow row in databaseDataSet.Workers)
            {
                comboBox1.Items.Add(row["WorkerName"].ToString());
            }

            foreach(DataRow row in databaseDataSet.ProjectTypes)
            {
                comboBox2.Items.Add(row["TypeName"].ToString());
            }


            UpdateTypeComboBox();
            UpdateManagerComboBox();
            UpdateWorkersCount();

            UpdateWorkerDetails();
            CalcManagerTeams();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectsBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                try
                {
                    int id = int.Parse(row["ProjectId"].ToString());

                    if (id > max)
                    {
                        max = id;
                    }
                }
                catch(DeletedRowInaccessibleException)
                {

                }
            }

            max += 1;

            projectIdTextBox.Text = max.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int projectId = -1;

            try
            {
                projectId = int.Parse(projectIdTextBox.Text);
            }
            catch
            {
                return;
            }

            foreach (DataRow row in databaseDataSet.ProjectComponents.Rows)
            {
                if((int)row["ProjectId"] == projectId)
                {
                    MessageBox.Show("לא ניתן למחוק");
                    return;
                }
            }

            foreach (DataRow row in databaseDataSet.Tests.Rows)
            {
                if ((int)row["ProjectId"] == projectId)
                {
                    MessageBox.Show("לא ניתן למחוק");
                    return;
                }
            }

            foreach (DataRow row in databaseDataSet.Surveys.Rows)
            {
                if ((int)row["ProjectId"] == projectId)
                {
                    MessageBox.Show("לא ניתן למחוק");
                    return;
                }
            }

            projectsBindingSource.RemoveCurrent();

            UpdateTypeComboBox();
            UpdateManagerComboBox();
            UpdateWorkersCount();

            UpdateWorkerDetails();
            CalcManagerTeams();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Asks the user if managment accepted the project the user would like to add
            DialogResult dialogResult = MessageBox.Show("האם ההנהלה אישרה פרויקט זה ?", "אישור הנההלה", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            if (projectNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Project Name cannot be empty");
                return;
            }

            if (projectIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Project Id cannot be empty");
                return;
            }

            if (orderIdComboBox.Text.Length == 0)
            {
                MessageBox.Show("Order Id cannot be empty");
                return;
            }

            if (managerIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Manager Id cannot be empty");
                return;
            }

            if (projectTypeTextBox.Text.Length == 0)
            {
                MessageBox.Show("Project Type Id cannot be empty");
                return;
            }

            // Saving
            projectsBindingSource.EndEdit();
            this.projectsTableAdapter.Update(this.databaseDataSet.Projects);

            MessageBox.Show("Saved !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);

            UpdateTypeComboBox();
            UpdateManagerComboBox();
            UpdateWorkersCount();

            UpdateWorkerDetails();
            CalcManagerTeams();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveFirst();

            UpdateTypeComboBox();
            UpdateManagerComboBox();
            UpdateWorkersCount();

            UpdateWorkerDetails();
            CalcManagerTeams();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveLast();

            UpdateTypeComboBox();
            UpdateManagerComboBox();
            UpdateWorkersCount();

            UpdateWorkerDetails();
            CalcManagerTeams();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MovePrevious();

            UpdateTypeComboBox();
            UpdateManagerComboBox();
            UpdateWorkersCount();

            UpdateWorkerDetails();
            CalcManagerTeams();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveNext();

            UpdateTypeComboBox();
            UpdateManagerComboBox();
            UpdateWorkersCount();

            UpdateWorkerDetails();
            CalcManagerTeams();

        }

        private void projectsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void UpdateWorkerDetails()
        {
            if (managerIdTextBox.Text.Length == 0)
            {
                return;
            }

            int managerId = int.Parse(managerIdTextBox.Text);

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                if ((int)row["WorkerId"] == managerId)
                {
                    textBox2.Text = ((DateTime.Now - (DateTime)row["WorkerJoinDate"]).Days / 365).ToString();
                    return;
                }
            }

            MessageBox.Show("Manger Id Not Found");
        }

        private void CalcManagerTeams()
        {
            if (managerIdTextBox.Text.Length == 0)
            {
                return;
            }

            int managerId = int.Parse(managerIdTextBox.Text);

            int counter = 0;

            foreach(DataRow row in databaseDataSet.WorkersToTeams.Rows)
            {
                if((int)row["WorkerId"] == managerId)
                {
                    counter++;
                }
            }

            textBox1.Text = counter.ToString();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Pen P = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(0, 0));

            e.Graphics.DrawString("דוח פרויקטים", new Font("Ariel", 30, FontStyle.Bold), Brushes.Blue, new Point(300, 100));

            int i = 0;
            int j;
            int x = 100;
            int y = 200;
            int w = 100;
            int h = 30;


            while (i < databaseDataSet.Projects.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.Projects.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                i++;
                x += 100;
            }

            i = 0;

            while (i < databaseDataSet.Projects.Rows.Count)
            {
                x = 100;
                y += 30;
                w = 100;
                h = 30;
                j = 0;

                while (j < databaseDataSet.Projects.Columns.Count)
                {
                    e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                    e.Graphics.DrawString(databaseDataSet.Projects.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                    j++;

                    x += 100;
                }

                i++;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument2;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int i = 0;
            int j;
            int x = 100;
            int y = 200;
            int w = 100;
            int h = 30;

            Pen P = new Pen(Brushes.Black, 2.5f);

            e.Graphics.DrawString(DateTime.Now.ToShortDateString(), new Font("Ariel", 20, FontStyle.Bold), Brushes.Black, new Point(0, 0));

            e.Graphics.DrawString("דוח פרויקט", new Font("Ariel", 30, FontStyle.Bold), Brushes.Blue, new Point(300, 100));

            while (i < databaseDataSet.Projects.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.Projects.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                i++;
                x += 100;
            }



            i = projectsDataGridView.CurrentRow.Index;

            x = 100;
            y += 30;
            w = 100;
            h = 30;
            j = 0;


            while (j < databaseDataSet.Projects.Columns.Count)
            {
                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.Projects.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                j++;

                x += 100;
            }


            i = 0;
            j = 0;
            x = 100;
            y = 300;
            w = 100;
            h = 30;

            while (i < databaseDataSet.ProjectComponents.Columns.Count)
            {
                {
                    e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                    e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                    e.Graphics.DrawString(databaseDataSet.ProjectComponents.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                    x += 100;
                }

                i++;

            }


            i = 0;

            while (i < databaseDataSet.ProjectComponents.Rows.Count)
            {
                x = 100;
                w = 100;
                h = 30;
                j = 0;

                if (databaseDataSet.ProjectComponents.Rows[i]["ProjectId"].ToString().Equals(projectIdTextBox.Text))
                {
                    y += 30;

                    while (j < databaseDataSet.ProjectComponents.Columns.Count)
                    {
                        e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                        e.Graphics.DrawString(databaseDataSet.ProjectComponents.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                        j++;

                        x += 100;
                    }
                }

                i++;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                return;
            }

            string workerName = comboBox1.SelectedItem.ToString();
            
            foreach(DataRow row in databaseDataSet.Workers.Rows)
            {
                if(row["WorkerName"].ToString().Equals(workerName))
                {
                    int id = (int)row["WorkerId"];
                    managerIdTextBox.Text = id.ToString();
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem == null)
            {
                return;
            }

            string typeName = comboBox2.SelectedItem.ToString();

            foreach (DataRow row in databaseDataSet.ProjectTypes.Rows)
            {
                if (row["TypeName"].ToString().Equals(typeName))
                {
                    int id = (int)row["TypeId"];
                    projectTypeTextBox.Text = id.ToString();
                }
            }
        }

        private void UpdateManagerComboBox()
        {
            int id = -1;
            try
            {
                id = int.Parse(managerIdTextBox.Text);
            }
            catch (Exception)
            {

            }

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                if ((int)row["WorkerId"] == id)
                {
                    string WorkerName = row["WorkerName"].ToString();

                    for (int i = 0; i < comboBox1.Items.Count; i++)
                    {
                        if (comboBox1.Items[i].ToString().Equals(WorkerName))
                        {
                            comboBox1.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }
        }

        private void UpdateTypeComboBox()
        {
            int id = -1;
            try
            {
                id = int.Parse(projectTypeTextBox.Text);
            }
            catch (Exception)
            {

            }

            foreach (DataRow row in databaseDataSet.ProjectTypes.Rows)
            {
                if ((int)row["TypeId"] == id)
                {
                    string TypeName = row["TypeName"].ToString();

                    for (int i = 0; i < comboBox2.Items.Count; i++)
                    {
                        if (comboBox2.Items[i].ToString().Equals(TypeName))
                        {
                            comboBox2.SelectedIndex = i;
                            return;
                        }
                    }
                }
            }
        }

        private void UpdateWorkersCount()
        {
            int projectId = -1;

            try
            {
                projectId = int.Parse(projectIdTextBox.Text);
            }
            catch
            {
                textBox3.Text = "";
            }

            int count = 0;

            HashSet<int> workers = new HashSet<int>();
            HashSet<int> projectComponents = new HashSet<int>();
            HashSet<int> teams = new HashSet<int>();

            

            foreach(DataRow row in databaseDataSet.ProjectComponents)
            {
                if((int)row["ProjectId"] == projectId)
                {
                    projectComponents.Add((int)row["ComponentId"]);
                }
            }

            foreach(DataRow row in databaseDataSet.Teams)
            {
                if(projectComponents.Contains((int)row["ComponentId"]))
                {
                    teams.Add((int)row["TeamId"]);
                }
            }

            foreach(DataRow row in databaseDataSet.WorkersToTeams)
            {
                if(teams.Contains((int)row["TeamId"]))
                {
                    workers.Add((int)row["WorkerId"]);
                }
            }

            textBox3.Text = workers.Count.ToString();

        }

        private void projectIdTextBox_TextChanged(object sender, EventArgs e)
        {
            int projectId = -1;
            try
            {
                projectId = int.Parse(projectIdTextBox.Text);
            }
            catch
            {
                textBox4.Text = "";
            }

            DataRow latestSurvey = null;
            foreach(DataRow row in databaseDataSet.Surveys.Rows)
            {
                if((int)row["ProjectId"] == projectId)
                {
                    latestSurvey = row;
                }
            }

            if(latestSurvey == null)
            {
                textBox4.Text = "טרם נעשו סקרים";
            }
            else
            {
                float average = (int)latestSurvey["Q1"] + (int)latestSurvey["Q2"] + (int)latestSurvey["Q3"] + (int)latestSurvey["Q4"];
                average = average / 4;
                textBox4.Text = average.ToString("0.00");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument2;
            DialogResult prbutton = printDialog1.ShowDialog();
            if (prbutton.Equals(DialogResult.OK))
            {
                printDocument2.Print();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult prbutton = printDialog1.ShowDialog();
            if (prbutton.Equals(DialogResult.OK))
            {
                printDocument1.Print();
            }
        }
    }
}
