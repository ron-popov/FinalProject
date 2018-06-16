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
    public partial class P1ProjectTypes : Form
    {
        public P1ProjectTypes()
        {
            InitializeComponent();
        }

        private void projectTypesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectTypesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P1ProjectTypes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Surveys' table. You can move, or remove it, as needed.
            this.surveysTableAdapter.Fill(this.databaseDataSet.Surveys);
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
            // TODO: This line of code loads data into the 'databaseDataSet.ProjectTypes' table. You can move, or remove it, as needed.
            this.projectTypesTableAdapter.Fill(this.databaseDataSet.ProjectTypes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            projectTypesBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.ProjectTypes.Rows)
            {
                int id = int.Parse(row["TypeId"].ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            typeIdTextBox.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectTypesBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.projectTypesTableAdapter.Fill(this.databaseDataSet.ProjectTypes);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Checking if all input fields are not empty
            if (typeIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Project Type Id cannot be empty");
                return;
            }

            if (typeNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Project Type Name cannot be empty");
                return;
            }


            // Checking for duplicates
            List<int> idList = new List<int>();

            foreach (DataRow row in databaseDataSet.ProjectTypes.Rows)
            {
                int id = (int)(row["TypeId"]);
                if (idList.Contains(id))
                {
                    MessageBox.Show("Project Type Id Duplicated found, please remove duplicate before saving");
                    return;
                }

                idList.Add(id);
            }

            // Saving to database
            projectTypesBindingSource.EndEdit();
            this.projectTypesTableAdapter.Update(this.databaseDataSet.ProjectTypes);

            MessageBox.Show("Saved !");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            projectTypesBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            projectTypesBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            projectTypesBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            projectTypesBindingSource.MoveNext();
        }

        private void button14_Click(object sender, EventArgs e)
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

            while (i < databaseDataSet.ProjectTypes.Columns.Count)
            {
                e.Graphics.FillRectangle(Brushes.DarkGray, new Rectangle(x, y, w, h));

                e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                e.Graphics.DrawString(databaseDataSet.ProjectTypes.Columns[i].ColumnName.ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                i++;
                x += 100;
            }

            i = 0;

            while (i < databaseDataSet.ProjectTypes.Rows.Count)
            {
                x = 100;
                y += 30;
                w = 100;
                h = 30;
                j = 0;


                while (j < databaseDataSet.ProjectTypes.Columns.Count)
                {
                    e.Graphics.DrawRectangle(P, new Rectangle(x, y, w, h));

                    e.Graphics.DrawString(databaseDataSet.ProjectTypes.Rows[i][j].ToString(), new Font("Ariel", 10, FontStyle.Regular), Brushes.Black, new Rectangle(x + 10, y, w, h));

                    j++;

                    x += 100;
                }

                i++;
            }
        }

        private void typeIdTextBox_TextChanged(object sender, EventArgs e)
        {
            int typeId = -1;
            try
            {
                typeId = int.Parse(typeIdTextBox.Text);
            }
            catch
            {
                textBox1.Text = "";
                return;
            }

            Dictionary<int, DataRow> dict = new Dictionary<int, DataRow>();
            HashSet<int> projects = new HashSet<int>();

            // Projects Count

            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                try
                {
                    if((int)row["ProjectType"] == typeId)
                    {
                        projects.Add((int)row["ProjectId"]);
                    }
                }
                catch(DeletedRowInaccessibleException)
                {

                }
            }

            textBox1.Text = projects.Count.ToString();


            // Average rating
            foreach(DataRow row in databaseDataSet.Surveys.Rows)
            {
                if (projects.Contains((int)row["ProjectId"]))
                {
                    dict[(int)row["ProjectId"]] = row;
                }
            }

            int[] scores = new int[4];
            for (int i = 0; i < 4; i++)
            {
                scores[i] = 0;
            }

            foreach (int key in dict.Keys)
            {
                scores[0] += (int)dict[key]["Q1"];
                scores[1] += (int)dict[key]["Q2"];
                scores[2] += (int)dict[key]["Q3"];
                scores[3] += (int)dict[key]["Q4"];
            }

            if (dict.Keys.Count == 0)
            {
                textBox2.Text = "טרם נעשו סקרים";
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                scores[i] = (int)(scores[i] / dict.Keys.Count);
            }

            float average = scores[0] + scores[1] + scores[2] + scores[3];
            average = average / 4;
            textBox2.Text = average.ToString("0.00");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            printDialog1.Document = printDocument1;
            DialogResult prbutton = printDialog1.ShowDialog();
            if (prbutton.Equals(DialogResult.OK))
            {
                printDocument1.Print();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
