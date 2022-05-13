
namespace B200900802_lab8
{
    partial class DetailsForm
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
            this.foodDGV = new System.Windows.Forms.DataGridView();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.refBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // foodDGV
            // 
            this.foodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDGV.Location = new System.Drawing.Point(26, 128);
            this.foodDGV.Name = "foodDGV";
            this.foodDGV.RowHeadersWidth = 62;
            this.foodDGV.RowTemplate.Height = 28;
            this.foodDGV.Size = new System.Drawing.Size(818, 410);
            this.foodDGV.TabIndex = 0;
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(255, 65);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(438, 26);
            this.searchTb.TabIndex = 1;
            this.searchTb.TextChanged += new System.EventHandler(this.searchTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search";
            // 
            // refBtn
            // 
            this.refBtn.Location = new System.Drawing.Point(699, 60);
            this.refBtn.Name = "refBtn";
            this.refBtn.Size = new System.Drawing.Size(80, 37);
            this.refBtn.TabIndex = 3;
            this.refBtn.Text = "Refresh";
            this.refBtn.UseVisualStyleBackColor = true;
            this.refBtn.Click += new System.EventHandler(this.refBtn_Click);
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 568);
            this.Controls.Add(this.refBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.foodDGV);
            this.Name = "DetailsForm";
            this.Text = "DetailsForm";
            this.Load += new System.EventHandler(this.DetailsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView foodDGV;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button refBtn;
    }
}