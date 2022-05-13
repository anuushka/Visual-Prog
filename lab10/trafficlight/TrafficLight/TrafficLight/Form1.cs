using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficLight
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            redStopLight.Visible = true;
            yellowstopLight.Visible = false;
            greenLightStop.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(redStopLight.Visible == true)
            {
                redStopLight.Visible = false;
                yellowstopLight.Visible = false;
                greenLightStop.Visible = true;

            }
            else if(yellowstopLight.Visible == true)
            {
                redStopLight.Visible = true;
                yellowstopLight.Visible = false;
                greenLightStop.Visible = false;
            }
            else if(greenLightStop.Visible == true)
            {
                redStopLight.Visible = false;
                yellowstopLight.Visible = true;
                greenLightStop.Visible = false;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
