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

            int count = 0;

            foreach (DataRow row in databaseDataSet.Projects.Rows)
            {
                try
                {
                    if((int)row["ProjectType"] == typeId)
                    {
                        count++;
                    }
                }
                catch(DeletedRowInaccessibleException)
                {

                }
            }

            textBox1.Text = count.ToString() ;
        }
    }
}
