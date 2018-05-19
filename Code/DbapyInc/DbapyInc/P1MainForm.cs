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
    public partial class P1MainForm : Form
    {
        public P1MainForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new P1Orders()).Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new P1Customers()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new P1Projects()).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new P1ProjectTypes()).Show();
        }
    }
}
