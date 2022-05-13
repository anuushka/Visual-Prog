
namespace Linq_lab11
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.display = new System.Windows.Forms.Button();
            this.sortAsc = new System.Windows.Forms.Button();
            this.sortDes = new System.Windows.Forms.Button();
            this.groupByCon = new System.Windows.Forms.Button();
            this.filterCountry = new System.Windows.Forms.Button();
            this.txtBoxAimag = new System.Windows.Forms.TextBox();
            this.topfiveBtn = new System.Windows.Forms.Button();
            this.sortOption = new System.Windows.Forms.ComboBox();
            this.filterOption = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 64);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(577, 544);
            this.dataGridView1.TabIndex = 1;
            // 
            // display
            // 
            this.display.Location = new System.Drawing.Point(635, 102);
            this.display.Name = "display";
            this.display.Size = new System.Drawing.Size(408, 37);
            this.display.TabIndex = 2;
            this.display.Text = "Өвчлөлийн тоог харуулах";
            this.display.UseVisualStyleBackColor = true;
            this.display.Click += new System.EventHandler(this.display_Click);
            // 
            // sortAsc
            // 
            this.sortAsc.Location = new System.Drawing.Point(635, 158);
            this.sortAsc.Name = "sortAsc";
            this.sortAsc.Size = new System.Drawing.Size(408, 37);
            this.sortAsc.TabIndex = 2;
            this.sortAsc.Text = "Өсөхөөр эрэмбэлэх /Шинэ";
            this.sortAsc.UseVisualStyleBackColor = true;
            this.sortAsc.Click += new System.EventHandler(this.sortAsc_Click);
            // 
            // sortDes
            // 
            this.sortDes.Location = new System.Drawing.Point(635, 216);
            this.sortDes.Name = "sortDes";
            this.sortDes.Size = new System.Drawing.Size(408, 37);
            this.sortDes.TabIndex = 2;
            this.sortDes.Text = "Буурахаар эрэмбэлэх /Нийт";
            this.sortDes.UseVisualStyleBackColor = true;
            this.sortDes.Click += new System.EventHandler(this.sortDes_Click);
            // 
            // groupByCon
            // 
            this.groupByCon.Location = new System.Drawing.Point(635, 273);
            this.groupByCon.Name = "groupByCon";
            this.groupByCon.Size = new System.Drawing.Size(408, 37);
            this.groupByCon.TabIndex = 2;
            this.groupByCon.Text = "Өвчлөлийг бүсчлэлээр";
            this.groupByCon.UseVisualStyleBackColor = true;
            this.groupByCon.Click += new System.EventHandler(this.groupByCon_Click);
            // 
            // filterCountry
            // 
            this.filterCountry.Location = new System.Drawing.Point(883, 507);
            this.filterCountry.Name = "filterCountry";
            this.filterCountry.Size = new System.Drawing.Size(160, 32);
            this.filterCountry.TabIndex = 2;
            this.filterCountry.Text = "Аймгаар шүүх";
            this.filterCountry.UseVisualStyleBackColor = true;
            this.filterCountry.Click += new System.EventHandler(this.filterCountry_Click);
            // 
            // txtBoxAimag
            // 
            this.txtBoxAimag.Location = new System.Drawing.Point(635, 513);
            this.txtBoxAimag.Name = "txtBoxAimag";
            this.txtBoxAimag.Size = new System.Drawing.Size(242, 26);
            this.txtBoxAimag.TabIndex = 3;
            // 
            // topfiveBtn
            // 
            this.topfiveBtn.Location = new System.Drawing.Point(635, 329);
            this.topfiveBtn.Name = "topfiveBtn";
            this.topfiveBtn.Size = new System.Drawing.Size(408, 37);
            this.topfiveBtn.TabIndex = 4;
            this.topfiveBtn.Text = "Хамгийн өвчлөл өндөртэй 5-н аймаг";
            this.topfiveBtn.UseVisualStyleBackColor = true;
            this.topfiveBtn.Click += new System.EventHandler(this.topfiveBtn_Click);
            // 
            // sortOption
            // 
            this.sortOption.FormattingEnabled = true;
            this.sortOption.Items.AddRange(new object[] {
            "Шинэ өвчлөлийн тоо",
            "Нийт өвчлөлийн тоо "});
            this.sortOption.Location = new System.Drawing.Point(802, 394);
            this.sortOption.Name = "sortOption";
            this.sortOption.Size = new System.Drawing.Size(241, 28);
            this.sortOption.TabIndex = 5;
            this.sortOption.SelectedIndexChanged += new System.EventHandler(this.sortOption_SelectedIndexChanged);
            // 
            // filterOption
            // 
            this.filterOption.FormattingEnabled = true;
            this.filterOption.Items.AddRange(new object[] {
            "Аймгийн нэрээр",
            "Нийт өвчлөлийн тоогоор",
            "Бүсчлэлээр"});
            this.filterOption.Location = new System.Drawing.Point(802, 453);
            this.filterOption.Name = "filterOption";
            this.filterOption.Size = new System.Drawing.Size(241, 28);
            this.filterOption.TabIndex = 6;
            this.filterOption.SelectedIndexChanged += new System.EventHandler(this.filterOption_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(635, 402);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Эрэмбэлэх ангилал";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(639, 460);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Шүүх ангилал";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 620);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filterOption);
            this.Controls.Add(this.sortOption);
            this.Controls.Add(this.topfiveBtn);
            this.Controls.Add(this.txtBoxAimag);
            this.Controls.Add(this.filterCountry);
            this.Controls.Add(this.groupByCon);
            this.Controls.Add(this.sortDes);
            this.Controls.Add(this.sortAsc);
            this.Controls.Add(this.display);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Coronavirus ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button display;
        private System.Windows.Forms.Button sortAsc;
        private System.Windows.Forms.Button sortDes;
        private System.Windows.Forms.Button groupByCon;
        private System.Windows.Forms.Button filterCountry;
        private System.Windows.Forms.TextBox txtBoxAimag;
        private System.Windows.Forms.Button topfiveBtn;
        private System.Windows.Forms.ComboBox sortOption;
        private System.Windows.Forms.ComboBox filterOption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

