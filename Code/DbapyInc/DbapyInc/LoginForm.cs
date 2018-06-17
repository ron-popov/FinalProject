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
    public partial class LoginForm : Form
    {

        private readonly string password = "password";
        private readonly bool isDebug = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(isDebug || textBox1.Text.Equals(password))
            {
                (new MainForm()).Show();
            }
        }
    }
}
