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
    public partial class FoodAdminForm : Form
    {
        public FoodAdminForm()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\RestaurantDb.mdf;Integrated Security=True;Connect Timeout=30");
        string type;

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
        private void Reset()
        {
            name.Text = "";
            code.Text = "";
            dishBtn.Checked = false;
            appBtn.Checked = false;
            ingred.Text = "";
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //Picture
            Image img = pictureBox1.Image;
            byte[] arr;
            ImageConverter converter = new ImageConverter();
            arr = (byte[])converter.ConvertTo(img, typeof(byte[]));
            /*if (dishBtn.Checked)
            {
                type = "Dish";
            }
            else
            {
                type = "Appetizer";
            }*/

            if (code.Text == "" || name.Text == "" || ingred.Text == "" || (dishBtn.Checked == false && appBtn.Checked == false))
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Restaurant(foodCode, foodName, foodType, foodIngre, foodPic)values(@FC, @FN, @FT, @FI, @arr)", Con);
                    cmd.Parameters.AddWithValue("@FC", code.Text);
                    cmd.Parameters.AddWithValue("@FN", name.Text);
                    cmd.Parameters.AddWithValue("@FT", type);
                    //cmd.Parameters.AddWithValue("@FP", null);
                    cmd.Parameters.AddWithValue("@FI", ingred.Text);
                    cmd.Parameters.AddWithValue("@arr", arr);
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

        private void FoodAdminForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        int Key = 0;
        private void foodDGV_DoubleClick(object sender, EventArgs e)
        {
    
            if (foodDGV.CurrentRow.Index != -1)
            {
                code.Text = foodDGV.CurrentRow.Cells[0].Value.ToString();
                name.Text = foodDGV.CurrentRow.Cells[1].Value.ToString();
                type = foodDGV.CurrentRow.Cells[2].Value.ToString();
                ingred.Text = foodDGV.CurrentRow.Cells[3].Value.ToString();
            }

            if (type == "Dish")
            {
                dishBtn.Checked = true;
            }
            else if (type == "App")
            {
                appBtn.Checked = true;
            }
            if (name.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(foodDGV.CurrentRow.Cells[0].Value.ToString());

            }

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            if (code.Text == "" || name.Text == "" || ingred.Text == "")
            { 
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update Restaurant Set  foodCode=@FC, foodName=@FN,foodType=@FT,foodIngre=@FI where foodCode = @FK", Con);
                    cmd.Parameters.AddWithValue("@FC", code.Text);
                    cmd.Parameters.AddWithValue("@FN", name.Text);
                    cmd.Parameters.AddWithValue("@FT", type);
                    cmd.Parameters.AddWithValue("@FI", ingred.Text);
                    cmd.Parameters.AddWithValue("@FK", Key);
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

        private void dishBtn_CheckedChanged(object sender, EventArgs e)
        {
            type = "Dish";
        }

        private void appBtn_CheckedChanged(object sender, EventArgs e)
        {
            type = "App";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (Key == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from Restaurant where foodCode=" + Key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Food Deleted Succesfully");
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

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                }
            }
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            MessageBox.Show("Success");
            Con.Close();
        }
    }
}
