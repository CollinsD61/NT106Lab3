using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace NT106Lab3
{
    public partial class B3_Client : Form
    {
        public B3_Client()
        {
            InitializeComponent();
        }
        private TcpClient tcpClient = new TcpClient();

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream ns = tcpClient.GetStream();
            Byte[] data = Encoding.ASCII.GetBytes("Hello server \n");
            ns.Write(data, 0, data.Length);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

            IPEndPoint IPEP = new IPEndPoint(
            IPAddress.Parse("127.0.0.1"), 8080);
            tcpClient.Connect(IPEP);
        }

        private void frmB3_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            NetworkStream ns = tcpClient.GetStream();
            Byte[] data = Encoding.ASCII.GetBytes("Quit \n");
            ns.Write(data, 0, data.Length);
            tcpClient.Close();
        }
    }
}
