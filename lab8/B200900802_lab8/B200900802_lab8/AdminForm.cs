using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B200900802_lab8
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void foodAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodAdminForm f = new FoodAdminForm();
            f.MdiParent = this;
            f.Show();
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetailsForm d = new DetailsForm();
            d.MdiParent = this;
            d.Show();
        }
    }
}
