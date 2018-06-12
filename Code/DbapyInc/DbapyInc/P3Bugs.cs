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
    public partial class P3Bugs : Form
    {
        public P3Bugs()
        {
            InitializeComponent();
        }

        private void bugsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bugsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P3Bugs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.BugsToTests' table. You can move, or remove it, as needed.
            this.bugsToTestsTableAdapter.Fill(this.databaseDataSet.BugsToTests);
            // TODO: This line of code loads data into the 'databaseDataSet.Bugs' table. You can move, or remove it, as needed.
            this.bugsTableAdapter.Fill(this.databaseDataSet.Bugs);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bugsBindingSource.AddNew();

            int max = 0;

            // Find the max customer Id in the table
            foreach (DataRow row in databaseDataSet.Bugs.Rows)
            {
                int id = int.Parse(row["BugId"].ToString());

                if (id > max)
                {
                    max = id;
                }


            }

            max += 1;

            bugIdTextBox.Text = max.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bugsBindingSource.RemoveCurrent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Checking for empty input fields
            if (bugIdTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bug Id Cannot be empty");
                return;
            }

            if (bugNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bug Name Cannot be empty");
                return;
            }

            if (bugDescriptionRichTextBox.Text.Length == 0)
            {
                MessageBox.Show("Bug Description Cannot be empty");
                return;
            }


            // Save to database
            bugsBindingSource.EndEdit();
            this.bugsTableAdapter.Update(this.databaseDataSet.Bugs);

            MessageBox.Show("Saved !");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            bugsBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            bugsBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bugsBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bugsBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.bugsTableAdapter.Fill(this.databaseDataSet.Bugs);
        }

        private void bugIdTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateBugCount();
        }

        private void UpdateBugCount()
        {
            int bugId = -1;
            try
            {
                bugId = int.Parse(bugIdTextBox.Text);
            }
            catch
            {
                textBox1.Text = "";
                return;
            }

            int count = 0;

            foreach(DataRow row in databaseDataSet.BugsToTests)
            {
                if((int)row["BugId"] == bugId)
                {
                    count++;
                }
            }

            textBox1.Text = count.ToString();
        }
    }
}
