using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace thread_lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rd;
        Thread thread1;
        private void btnThread1_Click(object sender, EventArgs e)
        {
            thread1 = new Thread(t => {
                for (int i = 0; i < 100; i++)
                {
                    int width = rd.Next(0, this.Width);
                    int heigth = rd.Next(50, this.Height);
                    this.CreateGraphics().DrawEllipse(new Pen(Brushes.Red, 1), new
                   Rectangle(width, heigth, 10, 10));
                    Thread.Sleep(1000);
                }
            })
            { IsBackground = true };
            thread1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
        }

        private void btnThread2_Click(object sender, EventArgs e)
        {
            
        }
        private void btnThread4_Click(object sender, EventArgs e)
        {
            Thread thread4 = new Thread(t => {
                while (true)
                {
                    DateLbl.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate
                   () { DateLbl.Text = Convert.ToString(DateTime.Now.TimeOfDay); });
                    Thread.Sleep(1000);
                }

            })
            { IsBackground = true };
            thread4.Start();

        }

        private void ThreadBtn5_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Thread thread5 = new Thread(t => {
                    richTextBox1.BeginInvoke((System.Windows.Forms.MethodInvoker)delegate ()
                    {
                        richTextBox1.Text = openFileDialog1.FileName;
                        using(StreamReader reader = new StreamReader(richTextBox1.Text))
                        {
                            string line;
                            StringBuilder builder = new StringBuilder();
                            while((line = reader.ReadLine()) != null)
                            {
                                builder.Append(line);
                                Thread.Sleep(100);
                                richTextBox1.Text = builder.ToString();
                            }
                            reader.Close();
                        }
                    });
                })
                { IsBackground = true };
                thread5.Start();
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            picPlay.Left = picPlay.Left + 10;
        }

        private void picPlay_LocationChanged(object sender, EventArgs e)
        {
            if (picPlay.Left > this.Width)
            {
                picPlay.Left = 0 - picPlay.Width;
            }
        }
    }
}
