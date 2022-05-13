using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Airline : Form
    {
        //Airline INSTANCE = new Airline();
        public Airline()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            comboBox3.SelectedItem = null;
            dateTimePicker1.Value = DateTime.Now;

            checkBox1.Checked = false;
            checkBox2.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == comboBox3.Text && comboBox2.Text != string.Empty && comboBox3.Text != string.Empty)
            {
                MessageBox.Show("Source and Destination same!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            string ticketText = textBox1.Text;
            int number;
            if (ticketText.Length != 9 || (Int32.TryParse(ticketText, out number)) == false)
            {
                
                MessageBox.Show("Invalid. Ticket must contain 9 integers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var nameText = textBox2.Text;
            if (Int32.TryParse(nameText, out number))
            {

                MessageBox.Show("Invalid. Name must be string", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            var passportText = textBox3.Text;
            if (passportText.Length != 7)
            {

                MessageBox.Show("Invalid. Passport must contain 7 characters", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("Accepted", "Booked a ticket", MessageBoxButtons.OK, MessageBoxIcon.None);
        }
    }
}
