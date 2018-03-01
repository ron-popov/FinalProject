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
    public partial class P1MenuForm : Form
    {
        public P1MenuForm()
        {
            InitializeComponent();
        }

        private void CustomersButton_Click(object sender, EventArgs e)
        {
            P1CustomersForm form = new P1CustomersForm();
            form.Show();
        }

        private void ProjectRequestsButton_Click(object sender, EventArgs e)
        {
            P1ProjectRequestsForm form = new P1ProjectRequestsForm();
            form.Show();
        }
    }
}
