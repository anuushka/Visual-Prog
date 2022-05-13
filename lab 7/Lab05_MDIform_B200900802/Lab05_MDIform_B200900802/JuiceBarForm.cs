using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_MDIform_B200900802
{
    public partial class JuiceBarForm : Form
    {
        private decimal itemPriceDecimal;
        private decimal totalOrderDecimal;
        private decimal totalSalesDecimal;
        private int drinksInteger;
        private int ordersInteger;
        string order_name;
        private decimal price;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BillDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void orderCompleteButton_Click(object sender, EventArgs e)
        {
            if (itemPriceTextBox.Text != "")
            {
                DialogResult responseDialogResult;
                string messageString = "Current Item not recorded. Add to order?";
                responseDialogResult = MessageBox.Show(messageString,
                "Verify Last Drink Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    addToOrderButton_Click(sender, e);
                }
            }
            // Display amount due.
            string dueString = "Amount Due " + totalOrderDecimal.ToString("C");
            MessageBox.Show(dueString, "Order Complete");
            // Add to summary totals.
            ordersInteger++;
            totalSalesDecimal += totalOrderDecimal;
            // Reset buttons and total for new order.
            summaryButton.Enabled = true;
            orderCompleteButton.Enabled = false;
            totalOrderDecimal = 0m;

            if (fruitJuiceRadioButton.Checked)
            {
                order_name = "Fruit juice";
            }
            else if (veggieJuiceRadioButton.Checked)
            {
                order_name = "Vegetable juice";
            }
            else if (pomegranateSmoothieRadioButton.Checked)
            {
                order_name = "Pomegranate smoothie";
            }
            else if (strawberryBananaRadioButton.Checked)
            {
                order_name = "Strawberry Banana smoothie";
            }
            else
            {
                order_name = "Wheatberry smoothie";
            }

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into BillTbl(OrderName,TotalPrice,Quantity)values(@ON, @TP, @Q)", Con);
            cmd.Parameters.AddWithValue("@ON", order_name);
            cmd.Parameters.AddWithValue("@TP", price);
            cmd.Parameters.AddWithValue("@Q", quantityTextBox.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Added");
            Con.Close();
        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            if (noSizeRadioButton.Checked)
            {
                MessageBox.Show("You must select a drink size.",
                "Missing required entry");
            }
            else
            {
                try
                {
                    int quantityInteger = int.Parse(quantityTextBox.Text);
                    if (quantityInteger != 0)
                    {
                        drinksInteger += quantityInteger;
                        totalOrderDecimal += itemPriceDecimal * quantityInteger;
                        orderCompleteButton.Enabled = true;
                        // Reset defaults for next item.
                        noSizeRadioButton.Checked = true;
                        fruitJuiceRadioButton.Checked = false;
                        vitaminPackCheckBox.Checked = false;
                        energyBoosterCheckBox.Checked = false;
                        ladiesCheckBox.Checked = false;
                        itemPriceTextBox.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Please enter a quantity.",
                        "Missing Required Entry");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Invalid quantity.", "Data Entry Error");
                    quantityTextBox.Focus();
                    quantityTextBox.SelectAll();
                }

            }

            
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            string summaryString = "Drinks Sold: " + drinksInteger.ToString()
            + "\n\n" + "Number of Orders: "
            + ordersInteger.ToString()
            + "\n\n" + "Total Sales: "
            + totalSalesDecimal.ToString("C");
            MessageBox.Show(summaryString, "Juice Bar Sales Summary",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            FoodForm objEmp = new FoodForm();
            objEmp.Show();
            this.Hide();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void twelveOunceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int extrasInteger = 0;
            if (twelveOunceRadioButton.Checked)
            {
                itemPriceDecimal = 3m;
            }
            else if (sixteenOunceRadioButton.Checked)
            {
                itemPriceDecimal = 3.5m;
            }
            else if (twentyOunceRadioButton.Checked)
            {
                itemPriceDecimal = 4m;
            }
            if (vitaminPackCheckBox.Checked)
            {
                extrasInteger++;
            }
            if (energyBoosterCheckBox.Checked)
            {
                extrasInteger++;
            }
            if (ladiesCheckBox.Checked)
            {
                extrasInteger++;
            }

            int q = int.Parse(quantityTextBox.Text);
            itemPriceDecimal += extrasInteger * .5m; // 50 cents for each extra.
            itemPriceTextBox.Text = itemPriceDecimal.ToString("C");
            price = q * itemPriceDecimal;
        }

        public JuiceBarForm()
        {
            InitializeComponent();
        }

        private void veggieJuiceRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pomegranateSmoothieRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void sixteenOunceRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void vitaminPackCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
