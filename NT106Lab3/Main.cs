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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            B2 b2 = new B2();   
            b2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            B3 b3 = new B3();
            b3.Show();
        }
    }
}
