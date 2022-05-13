
namespace Lab05_MDIform_B200900802
{
    partial class About
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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.dishNameLbl = new System.Windows.Forms.Label();
            this.dishPriceLbl = new System.Windows.Forms.Label();
            this.FNameTb = new System.Windows.Forms.TextBox();
            this.FPriceTb = new System.Windows.Forms.TextBox();
            this.FDescTb = new System.Windows.Forms.TextBox();
            this.DishDescLbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.sizeCb = new System.Windows.Forms.ComboBox();
            this.sizeLbl = new System.Windows.Forms.Label();
            this.EditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(930, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 34);
            this.button1.TabIndex = 9;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(597, 110);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(327, 26);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged_1);
            // 
            // BillDGV
            // 
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Location = new System.Drawing.Point(515, 174);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersWidth = 62;
            this.BillDGV.RowTemplate.Height = 28;
            this.BillDGV.Size = new System.Drawing.Size(496, 470);
            this.BillDGV.TabIndex = 6;
            this.BillDGV.DoubleClick += new System.EventHandler(this.BillDGV_DoubleClick);
            // 
            // dishNameLbl
            // 
            this.dishNameLbl.AutoSize = true;
            this.dishNameLbl.Location = new System.Drawing.Point(67, 157);
            this.dishNameLbl.Name = "dishNameLbl";
            this.dishNameLbl.Size = new System.Drawing.Size(51, 20);
            this.dishNameLbl.TabIndex = 10;
            this.dishNameLbl.Text = "Name";
            // 
            // dishPriceLbl
            // 
            this.dishPriceLbl.AutoSize = true;
            this.dishPriceLbl.Location = new System.Drawing.Point(67, 251);
            this.dishPriceLbl.Name = "dishPriceLbl";
            this.dishPriceLbl.Size = new System.Drawing.Size(44, 20);
            this.dishPriceLbl.TabIndex = 12;
            this.dishPriceLbl.Text = "Price";
            // 
            // FNameTb
            // 
            this.FNameTb.Location = new System.Drawing.Point(203, 157);
            this.FNameTb.Name = "FNameTb";
            this.FNameTb.Size = new System.Drawing.Size(215, 26);
            this.FNameTb.TabIndex = 14;
            // 
            // FPriceTb
            // 
            this.FPriceTb.Location = new System.Drawing.Point(205, 251);
            this.FPriceTb.Name = "FPriceTb";
            this.FPriceTb.Size = new System.Drawing.Size(215, 26);
            this.FPriceTb.TabIndex = 14;
            // 
            // FDescTb
            // 
            this.FDescTb.Location = new System.Drawing.Point(203, 289);
            this.FDescTb.Multiline = true;
            this.FDescTb.Name = "FDescTb";
            this.FDescTb.Size = new System.Drawing.Size(215, 86);
            this.FDescTb.TabIndex = 16;
            // 
            // DishDescLbl
            // 
            this.DishDescLbl.AutoSize = true;
            this.DishDescLbl.Location = new System.Drawing.Point(65, 295);
            this.DishDescLbl.Name = "DishDescLbl";
            this.DishDescLbl.Size = new System.Drawing.Size(89, 20);
            this.DishDescLbl.TabIndex = 15;
            this.DishDescLbl.Text = "Description";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(69, 460);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(126, 36);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // sizeCb
            // 
            this.sizeCb.FormattingEnabled = true;
            this.sizeCb.Items.AddRange(new object[] {
            "Half",
            "Full"});
            this.sizeCb.Location = new System.Drawing.Point(203, 202);
            this.sizeCb.Name = "sizeCb";
            this.sizeCb.Size = new System.Drawing.Size(217, 28);
            this.sizeCb.TabIndex = 20;
            // 
            // sizeLbl
            // 
            this.sizeLbl.AutoSize = true;
            this.sizeLbl.Location = new System.Drawing.Point(67, 202);
            this.sizeLbl.Name = "sizeLbl";
            this.sizeLbl.Size = new System.Drawing.Size(40, 20);
            this.sizeLbl.TabIndex = 21;
            this.sizeLbl.Text = "Size";
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(217, 460);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(126, 36);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 746);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.sizeLbl);
            this.Controls.Add(this.sizeCb);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FDescTb);
            this.Controls.Add(this.DishDescLbl);
            this.Controls.Add(this.FPriceTb);
            this.Controls.Add(this.FNameTb);
            this.Controls.Add(this.dishPriceLbl);
            this.Controls.Add(this.dishNameLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.BillDGV);
            this.Name = "About";
            this.Text = "About";
            this.Load += new System.EventHandler(this.About_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label dishNameLbl;
        private System.Windows.Forms.Label dishPriceLbl;
        private System.Windows.Forms.Label DishDescLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label sizeLbl;
        private System.Windows.Forms.Button EditBtn;
        public System.Windows.Forms.TextBox FNameTb;
        public System.Windows.Forms.DataGridView BillDGV;
        public System.Windows.Forms.TextBox FPriceTb;
        public System.Windows.Forms.TextBox FDescTb;
        public System.Windows.Forms.ComboBox sizeCb;
    }
}