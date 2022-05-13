using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_MDIform_B200900802
{
    public partial class Restaurant_Registry : Form
    {
        public Restaurant_Registry()
        {
            InitializeComponent();
        }

        private void foodFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodForm f = new FoodForm();
            f.MdiParent = this;
            f.Show();
        }

        private void juiceBarFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JuiceBarForm j = new JuiceBarForm();
            j.MdiParent = this;
            j.Show();
        }

        private void summaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Summary s = new Summary();
            s.MdiParent = this;
            s.Show();
        }

        private void addFoodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.MdiParent = this;
            a.Show();
        }
    }
}
