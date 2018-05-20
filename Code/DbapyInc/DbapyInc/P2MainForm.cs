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
    public partial class P2MainForm : Form
    {
        public P2MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new P2Workers()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new P2Teams()).Show();
        }
    }
}
