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

        // Handler for the surveys button
        private void button1_Click(object sender, EventArgs e)
        {
            // Creating an anonymous P4Surveys objects and calling it's show method
            (new P4Surveys()).Show();
        }

        // Handler for the graphs button
        private void button2_Click(object sender, EventArgs e)
        {
            // Creating an anonymous P4Graphs objects and calling it's show method
            (new P4Graphs()).Show();
        }

        private void P4MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
