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

namespace Messenger
{
    public partial class message : Form
    {
        Socket socket;
        public message(Socket socket)
        {
            InitializeComponent();
            this.socket = socket;
        }

        private void message_Load(object sender, EventArgs e)
        {
            this.Text =
            Dns.GetHostEntry(((IPEndPoint)(socket.RemoteEndPoint)).Address).HostName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(richTextBox2.Text != "")
            {
                if(!socket.Connected)
                {
                    MessageBox.Show("Хэрэглэгч холбогдоогүй байна.");
                }
                byte[] data = System.Text.UTF8Encoding.UTF8.GetBytes(richTextBox2.Text);
                try
                {
                    socket.Send(data);
                }
                catch(SocketException se)
                {
                    MessageBox.Show(se.Message.ToString() + "-hihi");
                }
                richTextBox1.Text = Dns.GetHostName() + "> " + richTextBox2.Text + '\n';
                richTextBox2.Text = "";
            }
        }
        private void message_FormClosing(object sender, FormClosingEventArgs e)
        {
            socket.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(socket.Available > 0)
            {
                byte[] data = new byte[socket.Available];
                socket.Receive(data);
                richTextBox1.Text +=
               Dns.GetHostEntry(((IPEndPoint)(socket.RemoteEndPoint)).Address).HostName + ">" +
               System.Text.UTF8Encoding.UTF8.GetString(data) + "\n";

            }
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToInt16(Keys.Enter))
            {
                button1_Click(sender, e);
            }

        }
    }
}
