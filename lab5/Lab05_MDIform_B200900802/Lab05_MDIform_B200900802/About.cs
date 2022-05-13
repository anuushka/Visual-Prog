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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\BillDb.mdf;Integrated Security=True;Connect Timeout=30");

        private void About_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate() //show in datagrid view
        {
            Con.Open();
            string query = "select * from FoodTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Filter() //search in datagrid view
        {
            Con.Open();
            string query = "select * from FoodTbl where FoodName='" + txtSearch.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            BillDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Reset()
        {
            FNameTb.Text = "";
            FPriceTb.Text = "";
            sizeCb.SelectedIndex = 0;
            FDescTb.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            populate();
            txtSearch.Text = "";
        }

        int Key = 0;
        private void BillDGV_DoubleClick(object sender, EventArgs e)
        {
            if (BillDGV.CurrentRow.Index != -1)
            { 
                FNameTb.Text = BillDGV.CurrentRow.Cells[1].Value.ToString();
                sizeCb.SelectedItem = BillDGV.CurrentRow.Cells[2].Value.ToString();
                FPriceTb.Text = BillDGV.CurrentRow.Cells[3].Value.ToString();
                FDescTb.Text = BillDGV.CurrentRow.Cells[4].Value.ToString();
            }
            if (FNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(BillDGV.CurrentRow.Cells[0].Value.ToString());

            }

        }     

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (FNameTb.Text == "" || FPriceTb.Text == "" || FDescTb.Text == "" || sizeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FoodTbl(FoodName, SizeCat, FoodPrice,FoodDesc)values(@FN, @SC, @FP, @FD)", Con);
                    cmd.Parameters.AddWithValue("@FN", FNameTb.Text);
                    cmd.Parameters.AddWithValue("@SC", sizeCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FP", FPriceTb.Text);
                    cmd.Parameters.AddWithValue("@FD", FDescTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Food Added");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            Filter();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (FNameTb.Text == "" || FPriceTb.Text == "" || FDescTb.Text == "" || sizeCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update FoodTbl Set FoodName=@FN,SizeCat=@SC,FoodPrice=@FP,FoodDesc=@FD where Food_Id = @FI", Con);
                    cmd.Parameters.AddWithValue("@FN", FNameTb.Text);
                    cmd.Parameters.AddWithValue("@SC", sizeCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FP", FPriceTb.Text);
                    cmd.Parameters.AddWithValue("@FD", FDescTb.Text);
                    cmd.Parameters.AddWithValue("@FI", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Food Table Updated");
                    Con.Close();
                    populate();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
    }
}
