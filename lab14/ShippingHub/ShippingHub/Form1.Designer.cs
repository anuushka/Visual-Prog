
namespace ShippingHub
{
    partial class ShippingHub
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblArrived = new System.Windows.Forms.Label();
            this.fraAddress = new System.Windows.Forms.GroupBox();
            this.lblPackageID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.fraListByState = new System.Windows.Forms.GroupBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.lblArrivalTime = new System.Windows.Forms.Label();
            this.lblPackageNumber = new System.Windows.Forms.Label();
            this.cboViewPackages = new System.Windows.Forms.ComboBox();
            this.lstPackages = new System.Windows.Forms.ListBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnEditUpdate = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.fraAddress.SuspendLayout();
            this.fraListByState.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblArrived
            // 
            this.lblArrived.AutoSize = true;
            this.lblArrived.Location = new System.Drawing.Point(35, 41);
            this.lblArrived.Name = "lblArrived";
            this.lblArrived.Size = new System.Drawing.Size(82, 20);
            this.lblArrived.TabIndex = 0;
            this.lblArrived.Text = "Arrived At:";
            this.lblArrived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fraAddress
            // 
            this.fraAddress.Controls.Add(this.lblPackageNumber);
            this.fraAddress.Controls.Add(this.cboState);
            this.fraAddress.Controls.Add(this.txtZip);
            this.fraAddress.Controls.Add(this.txtCity);
            this.fraAddress.Controls.Add(this.txtAddress);
            this.fraAddress.Controls.Add(this.lblZip);
            this.fraAddress.Controls.Add(this.lblState);
            this.fraAddress.Controls.Add(this.lblCity);
            this.fraAddress.Controls.Add(this.lblAddress);
            this.fraAddress.Controls.Add(this.lblPackageID);
            this.fraAddress.Location = new System.Drawing.Point(39, 97);
            this.fraAddress.Name = "fraAddress";
            this.fraAddress.Size = new System.Drawing.Size(685, 196);
            this.fraAddress.TabIndex = 1;
            this.fraAddress.TabStop = false;
            this.fraAddress.Text = "Package Information";
            // 
            // lblPackageID
            // 
            this.lblPackageID.AutoSize = true;
            this.lblPackageID.Location = new System.Drawing.Point(7, 35);
            this.lblPackageID.Name = "lblPackageID";
            this.lblPackageID.Size = new System.Drawing.Size(96, 20);
            this.lblPackageID.TabIndex = 0;
            this.lblPackageID.Text = "Package ID:";
            this.lblPackageID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(11, 98);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(72, 20);
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Address:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(15, 155);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(39, 20);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City:";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(276, 155);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(52, 20);
            this.lblState.TabIndex = 3;
            this.lblState.Text = "State:";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(475, 155);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(35, 20);
            this.lblZip.TabIndex = 4;
            this.lblZip.Text = "Zip:";
            // 
            // fraListByState
            // 
            this.fraListByState.Controls.Add(this.lstPackages);
            this.fraListByState.Controls.Add(this.cboViewPackages);
            this.fraListByState.Location = new System.Drawing.Point(760, 97);
            this.fraListByState.Name = "fraListByState";
            this.fraListByState.Size = new System.Drawing.Size(232, 196);
            this.fraListByState.TabIndex = 2;
            this.fraListByState.TabStop = false;
            this.fraListByState.Text = "Package by State:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(118, 98);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(536, 26);
            this.txtAddress.TabIndex = 3;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(118, 155);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(139, 26);
            this.txtCity.TabIndex = 5;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(516, 155);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(138, 26);
            this.txtZip.TabIndex = 6;
            // 
            // cboState
            // 
            this.cboState.FormattingEnabled = true;
            this.cboState.Items.AddRange(new object[] {
            "AL",
            "FL",
            "GA",
            "KY",
            "MS",
            "NC",
            "SC",
            "TN",
            "VA",
            "WV"});
            this.cboState.Location = new System.Drawing.Point(334, 155);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(121, 28);
            this.cboState.TabIndex = 7;
            // 
            // lblArrivalTime
            // 
            this.lblArrivalTime.AutoSize = true;
            this.lblArrivalTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArrivalTime.Location = new System.Drawing.Point(157, 40);
            this.lblArrivalTime.Name = "lblArrivalTime";
            this.lblArrivalTime.Size = new System.Drawing.Size(57, 22);
            this.lblArrivalTime.TabIndex = 3;
            this.lblArrivalTime.Text = "label 2";
            // 
            // lblPackageNumber
            // 
            this.lblPackageNumber.AutoSize = true;
            this.lblPackageNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPackageNumber.Location = new System.Drawing.Point(122, 35);
            this.lblPackageNumber.Name = "lblPackageNumber";
            this.lblPackageNumber.Size = new System.Drawing.Size(53, 22);
            this.lblPackageNumber.TabIndex = 8;
            this.lblPackageNumber.Text = "label8";
            // 
            // cboViewPackages
            // 
            this.cboViewPackages.FormattingEnabled = true;
            this.cboViewPackages.Items.AddRange(new object[] {
            "AL",
            "FL",
            "GA",
            "KY",
            "MS",
            "NC",
            "SC",
            "TN",
            "VA",
            "WV"});
            this.cboViewPackages.Location = new System.Drawing.Point(22, 38);
            this.cboViewPackages.Name = "cboViewPackages";
            this.cboViewPackages.Size = new System.Drawing.Size(178, 28);
            this.cboViewPackages.TabIndex = 0;
            this.cboViewPackages.SelectedIndexChanged += new System.EventHandler(this.cboViewPackages_SelectedIndexChanged);
            // 
            // lstPackages
            // 
            this.lstPackages.FormattingEnabled = true;
            this.lstPackages.ItemHeight = 20;
            this.lstPackages.Location = new System.Drawing.Point(22, 83);
            this.lstPackages.Name = "lstPackages";
            this.lstPackages.Size = new System.Drawing.Size(184, 104);
            this.lstPackages.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 325);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 35);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(161, 325);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(113, 35);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "Scan New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(280, 325);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(113, 35);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(399, 325);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(113, 35);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEditUpdate
            // 
            this.btnEditUpdate.Location = new System.Drawing.Point(518, 325);
            this.btnEditUpdate.Name = "btnEditUpdate";
            this.btnEditUpdate.Size = new System.Drawing.Size(113, 35);
            this.btnEditUpdate.TabIndex = 8;
            this.btnEditUpdate.Text = "Update";
            this.btnEditUpdate.UseVisualStyleBackColor = true;
            this.btnEditUpdate.Click += new System.EventHandler(this.btnEditUpdate_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(637, 325);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(113, 35);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // ShippingHub
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 389);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnEditUpdate);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblArrivalTime);
            this.Controls.Add(this.fraListByState);
            this.Controls.Add(this.fraAddress);
            this.Controls.Add(this.lblArrived);
            this.Name = "ShippingHub";
            this.Text = "ShippingHub";
            this.Load += new System.EventHandler(this.ShippingHub_Load);
            this.fraAddress.ResumeLayout(false);
            this.fraAddress.PerformLayout();
            this.fraListByState.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArrived;
        private System.Windows.Forms.GroupBox fraAddress;
        private System.Windows.Forms.Label lblPackageNumber;
        private System.Windows.Forms.ComboBox cboState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPackageID;
        private System.Windows.Forms.GroupBox fraListByState;
        private System.Windows.Forms.ListBox lstPackages;
        private System.Windows.Forms.ComboBox cboViewPackages;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnEditUpdate;
        private System.Windows.Forms.Button btnNext;
    }
}

