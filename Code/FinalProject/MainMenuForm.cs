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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void FirstProcessButton_Click(object sender, EventArgs e)
        {
            P1MenuForm form = new P1MenuForm();
            form.Show();
        }
    }
}
