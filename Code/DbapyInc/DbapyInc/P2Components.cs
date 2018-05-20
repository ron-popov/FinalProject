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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.RemoveCurrent();
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

            if (projectIdComboBox.Text.Length == 0)
            {
                MessageBox.Show("Project Id cannot be empty");
                return;
            }


            // Checking for duplicates
            List<int> idList = new List<int>();

            foreach (DataRow row in databaseDataSet.ProjectComponents.Rows)
            {
                int id = (int)(row["ComponentId"]);
                if (idList.Contains(id))
                {
                    MessageBox.Show("Component Id Duplicated found, please remove duplicate before saving");
                    return;
                }

                idList.Add(id);
            }

            // Saving to database
            projectComponentsBindingSource.EndEdit();
            this.projectComponentsTableAdapter.Update(this.databaseDataSet.ProjectComponents);

            MessageBox.Show("Saved !");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            projectComponentsBindingSource.MoveNext();
        }
    }
}
