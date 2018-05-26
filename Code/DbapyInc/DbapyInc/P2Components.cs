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
    public partial class P2Components : Form
    {
        public P2Components()
        {
            InitializeComponent();
        }

        private void P2Components_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
            // TODO: This line of code loads data into the 'databaseDataSet.ProjectComponents' table. You can move, or remove it, as needed.
            this.projectComponentsTableAdapter.Fill(this.databaseDataSet.ProjectComponents);


            // Loading Project Id's to combobox
            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                string data = row["ProjectId"].ToString();
                comboBox1.Items.Add(row["ProjectName"].ToString());
            }

            UpdateComboBox();

        }

        private void projectComponentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectComponentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.ProjectComponents.Rows)
            {
                int id = int.Parse(row["ComponentId"].ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            componentIdTextBox.Text = max.ToString();

            finishedCheckBox.Checked = false;

            UpdateComboBox();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.RemoveCurrent();

            UpdateComboBox();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.projectComponentsTableAdapter.Fill(this.databaseDataSet.ProjectComponents);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (componentIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Component Id cannot be empty");
                return;
            }

            if (componentNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Component Name cannot be empty");
                return;
            }

            if (projectIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Project Id cannot be empty");
                return;
            }


            // Checking for duplicates
            List<int> idList = new List<int>();

            foreach (DataRow row in databaseDataSet.ProjectComponents.Rows)
            {
                try
                {
                    int id = (int)(row["ComponentId"]);
                    if (idList.Contains(id))
                    {
                        MessageBox.Show("Component Id Duplicated found, please remove duplicate before saving");
                        return;
                    }

                    idList.Add(id);
                }
                catch(DeletedRowInaccessibleException)
                {

                }

            }

            // Saving to database
            projectComponentsBindingSource.EndEdit();
            this.projectComponentsTableAdapter.Update(this.databaseDataSet.ProjectComponents);


            MessageBox.Show("Saved !");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.MoveFirst();

            UpdateComboBox();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.MoveLast();

            UpdateComboBox();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.MovePrevious();

            UpdateComboBox();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.MoveNext();

            UpdateComboBox();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string projectId = textBox2.Text;

            DataView dv = new DataView(databaseDataSet.ProjectComponents);

            dv.RowFilter = "ProjectId = " + projectId;

            projectComponentsDataGridView.DataSource = dv;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string projectName = textBox1.Text;

            List<int> idList = new List<int>();

            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                if (row["ProjectName"].ToString().ToLower().Contains(projectName))
                {
                    idList.Add((int)row["ProjectId"]);
                }
            }

            string filter = "";

            foreach(int i in idList)
            {
                filter += "ProjectId = " + i + " OR";
            }

            if (filter.Length > 3)
            {
                filter = filter.Remove(filter.Length - 3);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(databaseDataSet.ProjectComponents);
            projectComponentsDataGridView.DataSource = dv;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            finishedCheckBox.Checked = true;
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

            while (i < databaseDataSet.ProjectComponents.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.ProjectComponents.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                i++;
                x += 100;
            }

            i = 0;

            while (i < databaseDataSet.ProjectComponents.Rows.Count)
            {
                x = 100;
                y += 30;
                w = 100;
                h = 30;
                j = 0;


                while (j < databaseDataSet.ProjectComponents.Columns.Count)
                {
                    e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                    e.Graphics.DrawString(databaseDataSet.ProjectComponents.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                    j++;

                    x += 100;
                }

                i++;
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void UpdateComboBox()
        {
            if(projectIdTextBox.Text.Length == 0)
            {
                return;
            }

            int projectId = int.Parse(projectIdTextBox.Text);

            foreach(DataRow row in databaseDataSet.Projects.Rows)
            {
                if(projectId == (int)row["ProjectId"])
                {
                    comboBox1.Text = row["ProjectName"].ToString();
                    return;
                }
            }
        }

        private void UpdateProjectIdTextBox()
        {
            if(comboBox1.SelectedItem == null)
            {
                return;
            }

            string projectName = comboBox1.SelectedItem.ToString();

            foreach(DataRow row in databaseDataSet.Projects.Rows)
            {
                if(row["ProjectName"].ToString().Equals(projectName))
                {
                    projectIdTextBox.Text = row["ProjectId"].ToString();
                    return;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProjectIdTextBox();
        }
    }
}
