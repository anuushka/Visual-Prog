using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class frmCalculator : Form
    {
        string Result;
        double EndResult;

        string CheckForManipulation;
        private decimal MemoryStore = 0;


        public frmCalculator()
        {
            InitializeComponent();
        }
        private void frmCalculator_Load(object sender, EventArgs e)
        {
            btn0.Click += new EventHandler(digitButton_Click);
            btn1.Click += new EventHandler(digitButton_Click);
            btn2.Click += new EventHandler(digitButton_Click);
            btn3.Click += new EventHandler(digitButton_Click);
            btn4.Click += new EventHandler(digitButton_Click);
            btn5.Click += new EventHandler(digitButton_Click);
            btn6.Click += new EventHandler(digitButton_Click);
            btn7.Click += new EventHandler(digitButton_Click);
            btn8.Click += new EventHandler(digitButton_Click);
            btn9.Click += new EventHandler(digitButton_Click);


            btnPlus.Click += new EventHandler(digitCalculate_Click);
            btnMinus.Click += new EventHandler(digitCalculate_Click);
            btnMult.Click += new EventHandler(digitCalculate_Click);
            btnDiv.Click += new EventHandler(digitCalculate_Click);


            btnMC.Click += new EventHandler(digitCalculate_Click);
            btnMR.Click += new EventHandler(digitCalculate_Click);
            btnMS.Click += new EventHandler(digitCalculate_Click);
            btnMPlus.Click += new EventHandler(digitCalculate_Click);
        }

        void digitButton_Click(object sender, EventArgs e)
        {
            Button ButtonThatWasPushed = (Button)sender;
            txtResult.Text += ButtonThatWasPushed.Text;

        }
        void digitCalculate_Click(object sender, EventArgs e)
        {
            Button ButtonThatWasPushed = (Button)sender;
            string ButtonText = ButtonThatWasPushed.Text;


            if (txtResult.Text != string.Empty)
            {
                double valueHolder1 = Convert.ToDouble(txtResult.Text);
            }

            if (ButtonText == "+")
            {


                Result = txtResult.Text;
                CheckForManipulation = "Add";
                txtResult.Clear();
                txtResult.Focus();


            }
            else if (ButtonText == "-")
            {

                Result = txtResult.Text;
                CheckForManipulation = "Substract";
                txtResult.Clear();
                txtResult.Focus();

            }
            else if (ButtonText == "*")
            {

                Result = txtResult.Text;
                CheckForManipulation = "Multiply";
                txtResult.Clear();
                txtResult.Focus();
            }
            else if (ButtonText == "/")
            {

                Result = txtResult.Text;
                CheckForManipulation = "Division";
                txtResult.Clear();
                txtResult.Focus();
            }

            if (ButtonText == "MC")
            {
                //Memory Clear
                this.MemoryStore = 0;
                return;
            }

            if (ButtonText == "MR")
            {
                //Memory Recall
                txtResult.Text = this.MemoryStore.ToString();
                return;
            }

            if (ButtonText == "MS")
            {
                // Memory subtract
                this.MemoryStore -= Convert.ToDecimal(this.EndResult);
                return;
            }

            if (ButtonText == "M+")
            {
                // Memory add 

                //this.MemoryStore += decimal.Parse(this.Result);
                this.MemoryStore += Convert.ToDecimal(this.EndResult);
                return;

            }
        }

        private void button25_Click(object sender, EventArgs e) //% button
        {
            double num2 = Convert.ToDouble(txtResult.Text);
            double num1 = Convert.ToDouble(Result);
            EndResult = num1 * num2 / 100;
            txtResult.Text = EndResult.ToString();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try {
                if (txtResult.Text == string.Empty && Result == string.Empty)
                    throw new NullReferenceException("It can't be null");
                {
                    double valueHolder2 = Convert.ToDouble(txtResult.Text);
                    double chk = Convert.ToDouble(Result);
                    if (CheckForManipulation == "Add")
                    {

                        EndResult = chk + valueHolder2;
                        txtResult.Text = EndResult.ToString();

                    }
                    else if (CheckForManipulation == "Substract")
                    {

                        EndResult = chk - valueHolder2;
                        txtResult.Text = EndResult.ToString();
                    }
                    else if (CheckForManipulation == "Multiply")
                    {

                        EndResult = chk * valueHolder2;
                        txtResult.Text = EndResult.ToString();
                    }
                    else if (CheckForManipulation == "Division")
                    {
                        try
                        {
                            if (valueHolder2 == 0)
                                throw new DivideByZeroException("Division by zero is not allowed");
                            EndResult = chk / valueHolder2;
                            txtResult.Text = EndResult.ToString();
                        }

                        catch (DivideByZeroException ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid. Please correct it");
            }
            catch(NullReferenceException)
            {
                MessageBox.Show("It mustn't be null");

            }


        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Contains("."))
            {
                txtResult.Text = txtResult.Text;
            }

            else
            {
                txtResult.Text = txtResult.Text + ".";
            }

        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            try
            {

                double chk = Convert.ToDouble("1") / Convert.ToDouble(txtResult.Text);
                txtResult.Text = chk.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid. Please enter number");
            }
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
           try
            {
                double v = Double.Parse(txtResult.Text);
                txtResult.Text = (-v).ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Invalid. Please enter number");
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double SqrRoot = Math.Sqrt(Convert.ToDouble(this.txtResult.Text));
                txtResult.Text = SqrRoot.ToString();
            }

            catch (FormatException)
            {
                MessageBox.Show("Invalid. Please enter correctly");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            txtResult.Focus();

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text != string.Empty)
            {
                int txtlength = txtResult.Text.Length;
                if (txtlength != 1)
                {
                    txtResult.Text = txtResult.Text.Remove(txtlength - 1);
                }
                else
                {
                    txtResult.Text = 0.ToString();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }
    }
}
