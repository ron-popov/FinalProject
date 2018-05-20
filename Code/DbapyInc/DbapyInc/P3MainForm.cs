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
    public partial class P3MainForm : Form
    {
        public P3MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new P3Tests()).Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new P3Bugs()).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new P3BugsToTests()).Show();
        }
    }
}
