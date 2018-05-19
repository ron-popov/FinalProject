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
    public partial class P2Workers : Form
    {
        public P2Workers()
        {
            InitializeComponent();
        }

        private void workersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.workersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void P2Workers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Workers' table. You can move, or remove it, as needed.
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            workersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            workersBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.workersTableAdapter.Fill(this.databaseDataSet.Workers);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            workersBindingSource.EndEdit();
            this.workersTableAdapter.Update(this.databaseDataSet.Workers);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveFirst();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveLast();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            workersBindingSource.MovePrevious();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            workersBindingSource.MoveNext();
        }
    }
}
