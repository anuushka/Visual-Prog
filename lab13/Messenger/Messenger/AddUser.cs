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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        public string herN = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != null)
                herN = textBox1.Text;
            this.Close();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
