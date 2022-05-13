
namespace B200900802_lab8
{
    partial class FoodAdminForm
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
            this.fcode = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.fingred = new System.Windows.Forms.Label();
            this.ingred = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dishBtn = new System.Windows.Forms.RadioButton();
            this.appBtn = new System.Windows.Forms.RadioButton();
            this.foodDGV = new System.Windows.Forms.DataGridView();
            this.testBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.foodDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fcode
            // 
            this.fcode.AutoSize = true;
            this.fcode.Location = new System.Drawing.Point(65, 66);
            this.fcode.Name = "fcode";
            this.fcode.Size = new System.Drawing.Size(89, 20);
            this.fcode.TabIndex = 0;
            this.fcode.Text = "Food code:";
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(165, 63);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(198, 26);
            this.code.TabIndex = 1;
            // 
            // fname
            // 
            this.fname.AutoSize = true;
            this.fname.Location = new System.Drawing.Point(65, 124);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(94, 20);
            this.fname.TabIndex = 0;
            this.fname.Text = "Food name:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(165, 124);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(198, 26);
            this.name.TabIndex = 1;
            // 
            // fingred
            // 
            this.fingred.AutoSize = true;
            this.fingred.Location = new System.Drawing.Point(502, 66);
            this.fingred.Name = "fingred";
            this.fingred.Size = new System.Drawing.Size(132, 20);
            this.fingred.TabIndex = 0;
            this.fingred.Text = "Food ingredients:";
            // 
            // ingred
            // 
            this.ingred.Location = new System.Drawing.Point(640, 66);
            this.ingred.Multiline = true;
            this.ingred.Name = "ingred";
            this.ingred.Size = new System.Drawing.Size(198, 84);
            this.ingred.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food type:";
            // 
            // dishBtn
            // 
            this.dishBtn.AutoSize = true;
            this.dishBtn.Location = new System.Drawing.Point(154, 194);
            this.dishBtn.Name = "dishBtn";
            this.dishBtn.Size = new System.Drawing.Size(101, 24);
            this.dishBtn.TabIndex = 3;
            this.dishBtn.TabStop = true;
            this.dishBtn.Text = "Main dish";
            this.dishBtn.UseVisualStyleBackColor = true;
            this.dishBtn.CheckedChanged += new System.EventHandler(this.dishBtn_CheckedChanged);
            // 
            // appBtn
            // 
            this.appBtn.AutoSize = true;
            this.appBtn.Location = new System.Drawing.Point(261, 194);
            this.appBtn.Name = "appBtn";
            this.appBtn.Size = new System.Drawing.Size(102, 24);
            this.appBtn.TabIndex = 3;
            this.appBtn.TabStop = true;
            this.appBtn.Text = "Appetizer";
            this.appBtn.UseVisualStyleBackColor = true;
            this.appBtn.CheckedChanged += new System.EventHandler(this.appBtn_CheckedChanged);
            // 
            // foodDGV
            // 
            this.foodDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodDGV.Location = new System.Drawing.Point(69, 349);
            this.foodDGV.Name = "foodDGV";
            this.foodDGV.RowHeadersWidth = 62;
            this.foodDGV.RowTemplate.Height = 28;
            this.foodDGV.Size = new System.Drawing.Size(769, 315);
            this.foodDGV.TabIndex = 4;
            this.foodDGV.DoubleClick += new System.EventHandler(this.foodDGV_DoubleClick);
            // 
            // testBtn
            // 
            this.testBtn.Location = new System.Drawing.Point(69, 690);
            this.testBtn.Name = "testBtn";
            this.testBtn.Size = new System.Drawing.Size(134, 33);
            this.testBtn.TabIndex = 5;
            this.testBtn.Text = "Test";
            this.testBtn.UseVisualStyleBackColor = true;
            this.testBtn.Click += new System.EventHandler(this.testBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(381, 690);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(134, 33);
            this.addBtn.TabIndex = 5;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(545, 690);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(134, 33);
            this.editBtn.TabIndex = 5;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(704, 690);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(134, 33);
            this.deleteBtn.TabIndex = 5;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(640, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(506, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoodAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 812);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.testBtn);
            this.Controls.Add(this.foodDGV);
            this.Controls.Add(this.appBtn);
            this.Controls.Add(this.dishBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.ingred);
            this.Controls.Add(this.fingred);
            this.Controls.Add(this.code);
            this.Controls.Add(this.fcode);
            this.Name = "FoodAdminForm";
            this.Text = "Food admin form";
            this.Load += new System.EventHandler(this.FoodAdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.foodDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fcode;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label fname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label fingred;
        private System.Windows.Forms.TextBox ingred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton dishBtn;
        private System.Windows.Forms.RadioButton appBtn;
        private System.Windows.Forms.DataGridView foodDGV;
        private System.Windows.Forms.Button testBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

