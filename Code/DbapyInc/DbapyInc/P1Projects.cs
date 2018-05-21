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
            // TODO: This line of code loads data into the 'databaseDataSet.ProjectTypes' table. You can move, or remove it, as needed.
            this.projectTypesTableAdapter.Fill(this.databaseDataSet.ProjectTypes);
            // TODO: This line of code loads data into the 'databaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.databaseDataSet.Orders);
            // TODO: This line of code loads data into the 'databaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
            // TODO: This line of code loads data into the 'databaseDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this.databaseDataSet.Projects);
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
    }
}
