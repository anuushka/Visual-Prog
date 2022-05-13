using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace B200900802_lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void txtAncestor_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(txtAncestor.Text))
            {
                e.Cancel = true;
                txtAncestor.Focus();
                errorProvider1.SetError(txtAncestor, "Please enter ancestor name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAncestor, null);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text))
            {
                e.Cancel = true;
                txtFirstName.Focus();
                errorProvider1.SetError(txtFirstName, "Please enter your first name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                e.Cancel = true;
                txtLastName.Focus();
                errorProvider1.SetError(txtLastName, "Please enter your last name !");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, null);
            }
        }

        private void txtBirthdate_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();

            if (!e.IsValidInput)
            {
                toolTip1.ToolTipTitle = "Invalid Date";
                toolTip1.Show("The data you supplied must be a valid date in the format mm/dd/yyyy.", txtBirthdate, 0, -20, 5000);
            }
            else
            {
                DateTime userDate = (DateTime)e.ReturnValue;
                if (( DateTime.Today.Year - userDate.Year < 18) || (DateTime.Today.Year - userDate.Year > 55))
                {
                    toolTip1.ToolTipTitle = "Invalid age";
                    toolTip1.Show("You must be between 18-55", txtBirthdate, 0, -20, 5000);
                    e.Cancel = true;
                }

            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Regex rx = new Regex("^[a-zA-Z0-9_.-]{1,20}@[a-zA-Z0-9]{1,20}.[a-zA-Z]{2,3}$");

            if (ValidateChildren(ValidationConstraints.Enabled) && rx.IsMatch(txtEmail.Text))
            {
                double input = double.Parse(txtSalary.Text);
                double salary = input - input * 0.1 - (input - input * 0.1) * 0.1;
                salaryTb.Text = salary.ToString();
                string summaryString = "Success!";
                MessageBox.Show(summaryString, "Employee Info",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Email format is wrong");
            }

        }

        private void txtEmp_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            ToolTip toolTip2 = new ToolTip();
            if (!e.IsValidInput)
            {
                toolTip2.ToolTipTitle = "Invalid Date";
                toolTip2.Show("The data you supplied must be a valid date in the format mm/dd/yyyy.", txtEmp, 0, -20, 5000);
            }
            else
            {
                //Now that the type has passed basic type validation, enforce more specific type rules.
                DateTime userDate = (DateTime)e.ReturnValue;
                if (userDate > DateTime.Now)
                {
                    toolTip2.ToolTipTitle = "Invalid Date";
                    toolTip2.Show("Your employment date must be less than today's date", txtEmp, 0, -20, 5000);
                    e.Cancel = true;
                }
            }

        }
    }
}
