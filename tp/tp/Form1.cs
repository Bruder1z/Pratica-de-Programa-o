using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
namespace tp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Socket socketenviar = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            IPEndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            string msg = textBox1.Text;
            socketenviar.SendTo(Encoding.ASCII.GetBytes("VC " + msg), endereco);
            listBox1.Items.Add("vc : " + msg);

            textBox1.Clear();
            textBox1.Focus();
        }
    }
}
