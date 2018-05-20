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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new P1MainForm()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new P2MainForm()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new P3MainForm()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new P4MainForm()).Show();
        }
    }
}
