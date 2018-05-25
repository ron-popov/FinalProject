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
    public partial class P4MainForm : Form
    {
        public P4MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            P4Surveys form = new P4Surveys();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new P4Graphs()).Show();
        }
    }
}
