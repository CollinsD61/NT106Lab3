using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106Lab3
{
    public partial class B3 : Form
    {
        public B3()
        {
            InitializeComponent();
        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            B3_Server frm = new B3_Server();
            if (Application.OpenForms.OfType<B3_Server>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                frm.Show();
        }

        private void btnClient_Click(object sender, EventArgs e)
        {
            B3_Client frm = new B3_Client();
            if (Application.OpenForms.OfType<B3_Client>().Any())
            {
                MessageBox.Show("Already Opened.");
            }
            else
                frm.Show();
        }
    }
}
