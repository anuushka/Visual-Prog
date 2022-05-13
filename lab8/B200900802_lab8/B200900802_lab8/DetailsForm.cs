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

namespace B200900802_lab8
{
    public partial class DetailsForm : Form
    {

        public DetailsForm()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\RestaurantDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void DetailsForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void populate() //show in datagrid view
        {
            Con.Open();
            string query = "select * from Restaurant";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            foodDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Filter() //search in datagrid view
        {
            Con.Open();
            string query = "select * from Restaurant where foodName='" + searchTb.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            foodDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void searchTb_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void refBtn_Click(object sender, EventArgs e)
        {
            searchTb.Text = "";
            populate();
        }
    }
}
