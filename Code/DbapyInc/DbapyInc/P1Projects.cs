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

            UpdateWorkerDetails();
            UpdateProjectTypeDetails();
            CalcManagerTeams();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectsBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                int id = int.Parse(row["ProjectId"].ToString());

                if (id > max)
                {
                    max = id;
                }
            }

            max += 1;

            projectIdTextBox.Text = max.ToString();

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectsBindingSource.RemoveCurrent();

            
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

            if (managerIdComboBox.Text.Length == 0)
            {
                MessageBox.Show("Manager Id cannot be empty");
                return;
            }

            if (projectTypeComboBox.Text.Length == 0)
            {
                MessageBox.Show("Project Type cannot be empty");
                return;
            }

            // Checking for duplicates
            List<int> idList = new List<int>();

            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                int id = (int)(row["ProjectId"]);
                if (idList.Contains(id))
                {
                    MessageBox.Show("Project Id Duplicated found, please remove duplicate before saving");
                    return;
                }

                idList.Add(id);
            }

            // Saving
            projectsBindingSource.EndEdit();
            this.projectsTableAdapter.Update(this.databaseDataSet.Projects);

            MessageBox.Show("Saved !");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            projectsBindingSource.EndEdit();
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveFirst();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveLast();
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MovePrevious();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            projectsBindingSource.MoveNext();
            
        }

        private void projectsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.projectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void UpdateWorkerDetails()
        {
            object selection = managerIdComboBox.SelectedValue;
            if (selection == null)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            int managerId = (int)selection;

            foreach (DataRow row in databaseDataSet.Workers.Rows)
            {
                if ((int)row["WorkerId"] == managerId)
                {
                    textBox1.Text = row["WorkerName"].ToString();
                    textBox2.Text = ((DateTime.Now - (DateTime)row["WorkerJoinDate"]).Days / 365).ToString();
                    return;
                }
            }

            MessageBox.Show("Manger Id Not Found");
        }

        private void UpdateProjectTypeDetails()
        {
            object selection = projectTypeComboBox.SelectedValue;
            if (selection == null)
            {
                textBox3.Text = "";
                return;
            }

            int managerId = (int)selection;

            foreach (DataRow row in databaseDataSet.ProjectTypes.Rows)
            {
                if ((int)row["TypeId"] == managerId)
                {
                    textBox3.Text = row["TypeName"].ToString();
                    return;
                }
            }

            MessageBox.Show("Project Type Id Not Found");
        }

        private void CalcManagerTeams()
        {
            object selection = managerIdComboBox.SelectedValue;
            if (selection == null)
            {
                textBox1.Text = "";
                textBox2.Text = "";
                return;
            }

            int managerId = (int)selection;

            int counter = 0;

            foreach(DataRow row in databaseDataSet.WorkersToTeams.Rows)
            {
                if((int)row["WorkerId"] == managerId)
                {
                    counter++;
                }
            }

            textBox4.Text = counter.ToString();
        }

        private void managerIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateWorkerDetails();
            CalcManagerTeams();
        }

        private void projectTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProjectTypeDetails();
        }

        private void managerIdComboBox_ValueMemberChanged(object sender, EventArgs e)
        {
            UpdateWorkerDetails();
            CalcManagerTeams();
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
    }
}
