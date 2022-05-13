using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShippingHub
{
    public partial class ShippingHub : Form
    {
        public ShippingHub()
        {
            InitializeComponent();
        }

        private ArrayList m_objList; // list of packages
        private Package m_objPackage; // current package
        private int m_intPosition; // position of current package
        private Random m_objRandom; // random number for package ID
        private int m_intPackageID; 
        private void ShippingHub_Load(object sender, EventArgs e)
        {
            m_intPosition = 0; 
            m_objRandom = new Random(); 
            m_intPackageID = m_objRandom.Next(1, 100000); 
                                                          
            cboState.Text = Convert.ToString(
            cboState.Items[0]);
            m_objList = new ArrayList(); 
        }

        private void SetPackage()
        {
            m_objPackage.Address = txtAddress.Text;
            m_objPackage.City = txtCity.Text;
            m_objPackage.State =
            Convert.ToString(cboState.SelectedItem);
            m_objPackage.Zip = Int32.Parse(txtZip.Text);
        }
        private void LoadPackage()
        {
            // retrieve package from list
            m_objPackage = (Package)m_objList[m_intPosition];
            // display package data
            txtAddress.Text = m_objPackage.Address;
            txtCity.Text = m_objPackage.City;
            cboState.Text = m_objPackage.State;
            txtZip.Text = m_objPackage.Zip.ToString("00000");
            lblArrivalTime.Text =
            m_objPackage.ArrivalTime.ToString();
            lblPackageNumber.Text =
            m_objPackage.PackageNumber.ToString();
        }
        private void ClearControls()
        {
            txtAddress.Clear();
            txtCity.Clear();
            txtZip.Clear();
            cboState.SelectedText = "";
            lblArrivalTime.Text = "";
            lblPackageNumber.Text = "";
        }

        private void SetButtons(bool blnState)
        {
            btnRemove.Enabled = blnState;
            btnEditUpdate.Enabled = blnState;
            btnNext.Enabled = blnState;
            btnBack.Enabled = blnState;
            // disable navigation if not multiple packages
            if (m_objList.Count < 1)
            {
                btnNext.Enabled = false;
                btnBack.Enabled = false;
            }
            // if no items, disable Remove and Edit/Update Buttons
            if (m_objList.Count == 0)
            {
                btnEditUpdate.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            m_intPackageID++; // increment package ID
            m_objPackage = new Package(
            m_intPackageID); // create package
            ClearControls(); // clear fields
                             // display package number and arrival time
            lblPackageNumber.Text = m_objPackage.PackageNumber.ToString();
            lblArrivalTime.Text = m_objPackage.ArrivalTime.ToString();
            // only allow user to add package
            fraAddress.Enabled = true; // disable GroupBox and controls
            SetButtons(false); // enable/disable Buttons
            btnAdd.Enabled = true; // enable Add Button
            btnNew.Enabled = false; // disable Scan New Button
            txtAddress.Focus(); // transfer focus to txtAddress TextBox

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetPackage(); // set Package properties from TextBoxes
            m_objList.Add(m_objPackage); // add package to ArrayList
            // disable GroupBox and its controls
            fraAddress.Enabled = false;
            SetButtons(true); // enable appropriate Buttons
            // package cannot be added until Scan New is clicked
            btnAdd.Enabled = false; // disable Add Button
            // if package's state displayed, add ID to ListBox
            if (cboState.Text == cboViewPackages.Text)
            {
                lstPackages.Items.Add(m_objPackage.PackageNumber);
            }
            cboViewPackages.Text = m_objPackage.State; // list packages
            btnNew.Enabled = true; // enable Scan New Button
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (m_intPosition > 0)
            {
                m_intPosition--;
            }
            else
            { 
                m_intPosition = m_objList.Count - 1;
            }
            LoadPackage(); 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (m_intPosition < m_objList.Count - 1)
            {
                m_intPosition++;
            }
            else
            {
                m_intPosition = 0; // wrap to beginning of list
            }
            LoadPackage(); // load package data from item in list
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (cboState.Text == cboViewPackages.Text)
            {
                lstPackages.Items.Remove(m_objPackage.PackageNumber);
            }
            // remove package from list
            m_objList.RemoveAt(m_intPosition);
            // load next package in list if there is one
            if (m_objList.Count > 0)
            {
                // if not at first position, go to previous one
                if (m_intPosition > 0)
                {
                    m_intPosition--;
                }
                LoadPackage(); //load package data from item in list
            }
            else
            {
                ClearControls(); // clear fields
            }
            SetButtons(true); // enable appropriate Buttons
        }

        private void btnEditUpdate_Click(object sender, EventArgs e)
        {
            if (btnEditUpdate.Text == "&Edit")
            {
                fraAddress.Enabled = true;
                SetButtons(false);
                btnEditUpdate.Enabled = true;
                // change Button text from "Edit" to "Update"
                btnEditUpdate.Text = "&Update";
            }
            else
            {
                // when Button reads "Update" remove the old package
                // data and add new data from TextBoxes
                SetPackage();
                m_objList.RemoveAt(m_intPosition);
                m_objList.Insert(m_intPosition, m_objPackage);
                // display state in ComboBox
                cboViewPackages.Text = m_objPackage.State;
                // when done, return to normal operating state
                fraAddress.Enabled = false; // disable GroupBox
                SetButtons(true); // enable appropriate Buttons
                                  // change Button text from "Update" to "Edit"
                btnEditUpdate.Text = "&Edit";
            } 
        }

        private void cboViewPackages_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strState = Convert.ToString(cboViewPackages.SelectedItem);
            lstPackages.Items.Clear(); // clear ListBox
                                       // list all packages for current state in ListBox
            foreach (Package objViewPackage in m_objList)
            {
                // determine if state package is being shipped to
                // matches the state selected in the ComboBox
                if (objViewPackage.State == strState)
                {
                    // add package number to the ListBox
                    lstPackages.Items.Add(objViewPackage.PackageNumber);
                }
            }
        }
    }
}
