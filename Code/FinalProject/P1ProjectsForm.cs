using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class P1ProjectsForm : Form
    {
        public P1ProjectsForm()
        {
            InitializeComponent();
        }

        private void P1ProjectsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.tProjectRequests' table. You can move, or remove it, as needed.
            this.tProjectRequestsTableAdapter.Fill(this.databaseDataSet.tProjectRequests);
            // TODO: This line of code loads data into the 'databaseDataSet.tCostumers' table. You can move, or remove it, as needed.
            this.tCostumersTableAdapter.Fill(this.databaseDataSet.tCostumers);
            // TODO: This line of code loads data into the 'databaseDataSet.tWorkers' table. You can move, or remove it, as needed.
            this.tWorkersTableAdapter.Fill(this.databaseDataSet.tWorkers);
            // TODO: This line of code loads data into the 'databaseDataSet.tProjects' table. You can move, or remove it, as needed.
            this.tProjectsTableAdapter.Fill(this.databaseDataSet.tProjects);

        }

        private void tProjectsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tProjectsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.MovePrevious();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.MoveFirst();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tProjectsBindingSource.MoveLast();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int projectRequestId = (int)comboBox1.SelectedValue;

            foreach(DataRow row in databaseDataSet.tProjectRequests.Rows)
            {
                if((int)row[0] == projectRequestId)
                {
                    richTextBox1.Text = row[5].ToString();
                    return;
                }
            }

        }
    }
}
