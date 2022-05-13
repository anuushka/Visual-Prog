using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linq_lab11
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable();
        DataTable table2 = new DataTable();
        Province[] aimag = new Province[21];
        public Form1()
        {
            InitializeComponent();
            table.Columns.Add("Аймаг", typeof(string));
            table.Columns.Add("Шинэ гарсан тохиолдол", typeof(int));
            table.Columns.Add("Нийт тохиолдол", typeof(int));
            table.Columns.Add("Бүс нутаг", typeof(string));
            
            table2.Columns.Add("Бүс нутаг", typeof(string));
            table2.Columns.Add("Аймгууд", typeof(int));
            table2.Columns.Add("Нийт шинэ тохиолдол", typeof(long));
            table2.Columns.Add("Дундажаар нийт тохиолдол", typeof(long));
        }     

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int ctr = 0; ctr < aimag.Length; ctr++)
            {
                aimag[ctr] = new Province();
            }
            aimag[0].pName = "Увс";
            aimag[0].nCase = 1;
            aimag[0].oCase = 7;
            aimag[0].pRegion = "Баруун бүс";

            aimag[1].pName = "Завхан";
            aimag[1].nCase = 4;
            aimag[1].oCase = 19;
            aimag[1].pRegion = "Баруун бүс";
           
            aimag[2].pName = "Дундговь";
            aimag[2].nCase = 3;
            aimag[2].oCase = 15;
            aimag[2].pRegion = "Говийн бүс";
            
            aimag[3].pName = "Дорноговь";
            aimag[3].nCase = 1;
            aimag[3].oCase = 59;
            aimag[3].pRegion = "Говийн бүс";

            aimag[4].pName = "Сүхбаатар";
            aimag[4].nCase = 2;
            aimag[4].oCase = 94;
            aimag[4].pRegion = "Зүүн бүс";
            
            aimag[5].pName = "Хэнтий";
            aimag[5].nCase = 4;
            aimag[5].oCase = 27;
            aimag[5].pRegion = "Зүүн бүс";
           
            aimag[6].pName = "Төв";
            aimag[6].nCase = 10;
            aimag[6].oCase = 451;
            aimag[6].pRegion = "Төвийн бүс";
            display_Click(sender, e);
        }

        private void display_Click(object sender, EventArgs e)
        {
            table.Clear();
            label1.Text = "Бүх мэдээллийг харуулбал...";
            var info = from i in aimag select i;
            foreach (var intr in info)
            {
               table.Rows.Add(intr.pName, intr.nCase, intr.oCase, intr.pRegion);
            }
            this.dataGridView1.DataSource = table;
        }

        private void sortAsc_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Өсөхөөр эрэмбэлвэл /Шинээр илэрсэн тохиолдлын тоогоор/ ...";
            var info = from i in aimag orderby i.nCase select i;
            table.Clear();
            foreach (var intr in info)
            {
                table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                intr.pRegion);
            }
           this.dataGridView1.DataSource = table;
        }

        private void groupByCon_Click(object sender, EventArgs e)
        {
            table2.Clear();
            this.label1.Text = "Өвчлөлийг бүс нутгаар нь нэгтгэж харвал...";
            var info = from i in aimag group i by i.pRegion into g select new
            {
                Region = g.Key,
                NumberOfProvines = g.Count(),
                TotalCases = g.Sum(s => s.nCase),
                AverageCases = g.Average(a => (a.nCase + a.oCase))
            };
          
             foreach (var intr in info)
             {
                table2.Rows.Add(intr.Region, intr.NumberOfProvines,
                intr.TotalCases, intr.AverageCases);
             }
            this.dataGridView1.DataSource = table2;
        }

        private void filterCountry_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Аймгийн нэрээр өвчлөлийн мэдээллийг шүүж харвал...";
            MessageBox.Show(txtBoxAimag.Text.Trim().ToUpper());
            var info = from i in aimag where i.pName == txtBoxAimag.Text.Trim() select i;
            table.Clear();
            foreach (var intr in info)
            {
                table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                intr.pRegion);
            }
            this.dataGridView1.DataSource = table;
        }

        private void sortDes_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Өсөхөөр эрэмбэлвэл /Шинээр илэрсэн тохиолдлын тоогоор/ ...";
            var info = from i in aimag orderby i.nCase descending select i;
            table.Clear();
            foreach (var intr in info)
            {
                table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                intr.pRegion);
            }
            this.dataGridView1.DataSource = table;
        }

        private void topfiveBtn_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Хамгийн өвчлөл өндөртэй 5-н аймаг/ ...";
            var info = (from i in aimag orderby i.nCase descending select i).Take(5);
            table.Clear();
            foreach (var intr in info)
            {
                table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                intr.pRegion);
            }
            this.dataGridView1.DataSource = table;
        }

        private void sortOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sortOption.SelectedIndex == 0 )
            {
                var info = from i in aimag orderby i.nCase descending select i;
                table.Clear();
                foreach (var intr in info)
                {
                    table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                    intr.pRegion);
                }
                this.dataGridView1.DataSource = table;
            }
            else
            {
                var info = from i in aimag orderby i.oCase descending select i;
                table.Clear();
                foreach (var intr in info)
                {
                    table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                    intr.pRegion);
                }
                this.dataGridView1.DataSource = table;
            }
        }

        private void filterOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(filterOption.SelectedIndex == 0)
            //Аймгийн нэрээр
            {
                this.label1.Text = "Аймгийн нэрээр өвчлөлийн мэдээллийг шүүж харвал...";
                MessageBox.Show(txtBoxAimag.Text.Trim().ToUpper());
                var info = from i in aimag where i.pName == txtBoxAimag.Text.Trim() select i;
                table.Clear();
                foreach (var intr in info)
                {
                    table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                    intr.pRegion);
                }
                this.dataGridView1.DataSource = table;
            }
            else if(filterOption.SelectedIndex == 1)
            //Нийт өвчлөлийн тоогоор
            {
                this.label1.Text = "Нийт өвчлөлийн тоогоор мэдээллийг шүүж харвал...";
                var info = from i in aimag where i.oCase.ToString() == txtBoxAimag.Text.Trim() select i;
                table.Clear();
                foreach (var intr in info)
                {
                    table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                    intr.pRegion);
                }
                this.dataGridView1.DataSource = table;
            }
            else
            //Бүсчлэлээр
            {
                this.label1.Text = "Бүсчлэлийн нэрээр өвчлөлийн мэдээллийг шүүж харвал...";
                MessageBox.Show(txtBoxAimag.Text.Trim().ToUpper());
                var info = from i in aimag where i.pRegion == txtBoxAimag.Text.Trim() select i;
                table.Clear();
                foreach (var intr in info)
                {
                    table.Rows.Add(intr.pName, intr.nCase, intr.oCase,
                    intr.pRegion);
                }
                this.dataGridView1.DataSource = table;
            }
        }
    }
}
