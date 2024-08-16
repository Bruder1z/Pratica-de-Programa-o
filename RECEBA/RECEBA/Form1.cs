using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RECEBA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Socket socketreceber = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            EndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            byte[] data = new byte[1024];
            int qtdbytes;

            socketreceber.Bind(endereco);
            while (true)
            {
                qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
                string msg = Encoding.ASCII.GetString(data, 0, qtdbytes);
                listBox1.Items.Add(msg);
                Refresh();
            }
        }

    }
}
