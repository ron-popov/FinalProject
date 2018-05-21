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
    }
}
