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
    public partial class FoodForm : Form
    {
        private decimal itemPriceDecimal; //tus tusin une
        private decimal totalOrderDecimal; //niit une
        private decimal totalSalesDecimal;
        private int foodsInteger;
        private int ordersInteger;
        string order_name;
        string app_name;

        public FoodForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BillDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }


        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addToOrderButton_Click(object sender, EventArgs e)
        {
            int quantityInteger = int.Parse(AppQuantityTextBox.Text);
            int quantityInteger2 = int.Parse(DishQuantityTextBox.Text);

            if (quantityInteger != 0 || quantityInteger2 != 0)
                {
                    foodsInteger += quantityInteger + quantityInteger2;
                    orderCompleteButton.Enabled = true;
                    if(quantityInteger2 == 2 && quantityInteger == 1 )
                    {
                        order = order*0.96m;
                    }
                    else if (quantityInteger == 2 && quantityInteger == 2)
                    {
                        order = order * 0.92m;
                    }
                    else if (totalOrderDecimal > 150)
                    {
                        order = order * 0.85m;
                    }
            }
            

        }

        private void orderCompleteButton_Click(object sender, EventArgs e)
        {
            if (itemPriceTextBox.Text != "")
            {
                DialogResult responseDialogResult;
                string messageString = "Current Item not recorded. Add to order?";
                responseDialogResult = MessageBox.Show(messageString,
                "Verify Last Purchase",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (responseDialogResult == DialogResult.Yes)
                {
                    addToOrderButton_Click(sender, e);
                }
            }
            // Display amount due.
            string dueString = "Amount Due " + order.ToString("C");
            MessageBox.Show(dueString, "Order Complete");
            // Add to summary totals.
            ordersInteger++;
            totalSalesDecimal += totalOrderDecimal;
            // Reset buttons and total for new order.
            summaryButton.Enabled = true;
            orderCompleteButton.Enabled = false;
            totalOrderDecimal = 0m;

            if (BeefRibsRadioButton.Checked)
            {
                order_name = "Beef Ribs";
            }
            else if (LambRadioButton.Checked)
            {
                order_name = "Lamb Steak";
            }
            else if (SalmonRadioButton.Checked)
            {
                order_name = "Salmon";
            }
            else 
            {
                order_name = "Bone Soup";
            }
            
            if (SaladRadioButton.Checked)
            {
                app_name = "Greek Salad";
            }
            else if (HummusRadioButton.Checked)
            {
                app_name = "Hummus";
            }
            else if (ZucchiniRadioButton.Checked)
            {
                app_name = "Zucchini";
            }
            else 
            {
                app_name = "Chicken Wings";
            }

            Con.Open();
            SqlCommand cmd = new SqlCommand("insert into BillTbl(OrderName,TotalPrice,Quantity, AppetizerName, AppetizerQuantity)values(@ON, @TP, @Q, @AN, @AQ)", Con);
            cmd.Parameters.AddWithValue("@ON", order_name);
            cmd.Parameters.AddWithValue("@TP", order);
            cmd.Parameters.AddWithValue("@Q", DishQuantityTextBox.Text);
            cmd.Parameters.AddWithValue("@AN", app_name);
            cmd.Parameters.AddWithValue("@AQ", AppQuantityTextBox.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Order Added");
            Con.Close();
        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            string summaryString = "Foods Sold: " + foodsInteger.ToString()
            + "\n\n" + "Number of Orders: "
            + ordersInteger.ToString()
            + "\n\n" + "Total Sales: "
            + totalSalesDecimal.ToString("C");
            MessageBox.Show(summaryString, "Food Sales Summary",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        decimal order;
        private void HalfRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            int n;
            int aq = int.Parse(AppQuantityTextBox.Text);
            int dq = int.Parse(DishQuantityTextBox.Text);
            if (HalfRadioButton.Checked)
            {
                itemPriceDecimal = 5m;
                n = aq + dq;
                order = n * itemPriceDecimal;
            }

            else if (FullRadioButton.Checked)
            {
                itemPriceDecimal = 10m;
                n = aq + dq;
                order = n * itemPriceDecimal;
        
            }
            itemPriceTextBox.Text = order.ToString("C");
        }
        private void BeefRibsRadioButton_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + BeefRibsRadioButton.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            a.BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void LambRadioButton_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + LambRadioButton.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            a.BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SalmonRadioButton_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + SalmonRadioButton.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            a.BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SoupRadioButton_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + SoupRadioButton.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            a.BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void SaladRadioButton_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + SaladRadioButton.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            a.BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void HummusRadioButton_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + HummusRadioButton.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            a.BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ZucchiniRadioButton_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + ZucchiniRadioButton.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            a.BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void ChickenRadioButton_Click(object sender, EventArgs e)
        {
            About a = new About();
            a.Show();
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + ChickenRadioButton.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            a.BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
    }
}
