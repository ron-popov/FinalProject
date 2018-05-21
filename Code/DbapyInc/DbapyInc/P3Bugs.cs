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
    }
}
