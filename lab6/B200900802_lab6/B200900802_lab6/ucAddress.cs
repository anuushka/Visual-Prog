using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B200900802_lab6
{
    public partial class ucAddress : UserControl
    {
        public ucAddress()
        {
            InitializeComponent();
        }

        public Countries SelectedCountry
        { 
            get
            {
                return (Countries)cboCountry.SelectedItem;
            }
        }

        private void ucAddress_Load(object sender, EventArgs e)
        {
            List<Countries> list = new List<Countries>();
            list.Add(new Countries() { ID = 1, Name = "Arkhangai" });
            list.Add(new Countries() { ID = 2, Name = "Bayankhongor" });
            list.Add(new Countries() { ID = 3, Name = "Bayan-Ulgii" });
            list.Add(new Countries() { ID = 4, Name = "Bulgan" });
            list.Add(new Countries() { ID = 5, Name = "Darkhan-Uul" });
            list.Add(new Countries() { ID = 6, Name = "Dornod" });
            list.Add(new Countries() { ID = 7, Name = "Dornogovi" });
            list.Add(new Countries() { ID = 8, Name = "Dundgovi" });
            list.Add(new Countries() { ID = 9, Name = "Govi-Altai" });
            list.Add(new Countries() { ID = 10, Name = "Govisümber" });
            list.Add(new Countries() { ID = 11, Name = "Khentii" });
            list.Add(new Countries() { ID = 12, Name = "Khovd" });
            list.Add(new Countries() { ID = 13, Name = "Khuvsgul" });
            list.Add(new Countries() { ID = 14, Name = "Orkhon" });
            list.Add(new Countries() { ID = 15, Name = "Selenge" });
            list.Add(new Countries() { ID = 16, Name = "Sükhbaatar" });
            list.Add(new Countries() { ID = 17, Name = "Tuv" });
            list.Add(new Countries() { ID = 18, Name = "Umnugovi" });
            list.Add(new Countries() { ID = 19, Name = "Uvs" });
            list.Add(new Countries() { ID = 20, Name = "Uvurkhangai" });
            list.Add(new Countries() { ID = 21, Name = "Zavkhan" });
            list.Add(new Countries() { ID = 22, Name = "Ulaanbaatar" });
            cboCountry.DataSource = list;
            cboCountry.ValueMember = "ID";
            cboCountry.DisplayMember = "Name";
        }

        private void cboCountry_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
