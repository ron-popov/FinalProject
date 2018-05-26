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

            printDocument1.DefaultPageSettings.Landscape = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            surveysBindingSource.AddNew();

            surveyDateDateTimePicker.MinDate = DateTime.Now;
            surveyDateDateTimePicker.MaxDate = DateTime.Now;

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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            surveysBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            surveysBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            surveysBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            surveysBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            surveysBindingSource.MoveNext();
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

        private void button14_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;

            printPreviewDialog1.ShowDialog();
        }
    }
}
