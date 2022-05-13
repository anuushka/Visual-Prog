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

namespace lab12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread th, th1, th2, th3, th4;
        Random rd;
        private void Form1_Load(object sender, EventArgs e)
        {
            rd = new Random();
        }
        public void thread()
        {
            for (int i = 0; i < 100; i++)
            {
                int width = rd.Next(0, this.Width);
                int heigth = rd.Next(0, this.Height);

                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Red, 4), new Rectangle(width, heigth, 20, 20)); 
                Thread.Sleep(100);
            }
        }
        public void threadb()
        {
            for (int i = 0; i < 100; i++)
            {
                int width = rd.Next(0, this.Width);
                int heigth = rd.Next(0, this.Height);

                this.CreateGraphics().DrawRectangle(new Pen(Brushes.Blue, 4), new Rectangle(width, heigth, 20, 20));
                Thread.Sleep(100);
            }
        }
        public void threadc()
        {
            for (int i = 0; i < 100; i++)
            {
                int width = rd.Next(0, this.Width);
                int heigth = rd.Next(0, this.Height);

                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Red, 4), new Rectangle(width, heigth, 20, 20));
                Thread.Sleep(100);
            }
        }

        public void threadcb()
        {
            for (int i = 0; i < 100; i++)
            {
                int width = rd.Next(0, this.Width);
                int heigth = rd.Next(0, this.Height);

                this.CreateGraphics().DrawEllipse(new Pen(Brushes.Blue, 4), new Rectangle(width, heigth, 20, 20));
                Thread.Sleep(100);
            }
        }
        public void threadt()
        {
            for (int i = 0; i < 100; i++)
            {
                Point[] pnt = new Point[3];

                pnt[0].X = rd.Next(0, this.Width);
                pnt[0].Y = rd.Next(0, this.Height);

                pnt[1].X = rd.Next(0, this.Width);
                pnt[1].Y = rd.Next(0, this.Height);

                pnt[2].X = rd.Next(0, this.Width);
                pnt[2].Y = rd.Next(0, this.Height);

                this.CreateGraphics().DrawPolygon(new Pen(Color.Green), pnt);
                Thread.Sleep(100);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            th3 = new Thread(threadcb);
            th3.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            th4 = new Thread(threadt);
            th4.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            th = new Thread(thread);
            th.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            th2 = new Thread(threadc);
            th2.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            th1 = new Thread(threadb);
            th1.Start();
        }


   
    }
}
