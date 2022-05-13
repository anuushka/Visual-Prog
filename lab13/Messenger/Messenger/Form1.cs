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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        TcpListener lstnr;
        private void гарахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            lstnr = new TcpListener(new IPAddress(new byte[] { 0, 0, 0, 0 }), 1);
            try
            {
                lstnr.Start();
            }
            catch (SocketException se)
            {
                MessageBox.Show("Server холбогдох боломжгүй байна." + se);
            }
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (lstnr.Pending())
            {
                Socket socket = lstnr.AcceptSocket();
                message f = new message(socket);
                f.Show();
            }
        }

        private void хэрэглэгчToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AddUser f2 = new AddUser();
            f2.ShowDialog();
            if (f2.herN != null)
                listBox1.Items.Add(f2.herN);
        }

        private void хэрэглэгчХасахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex >= 0)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Socket socket;
            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream,
           ProtocolType.Tcp);
            try
            {
                socket.Connect(listBox1.Items[listBox1.SelectedIndex].ToString(), 1);
            }
            catch (SocketException ex)
            {
                MessageBox.Show(" Холбогдох боломжгүй!!!. \n" + ex.Message);
            }
            message f3 = new message(socket);
            f3.Show();
        }
    }
}
