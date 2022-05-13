
namespace thread_lab
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
            this.components = new System.ComponentModel.Container();
            this.btnThread1 = new System.Windows.Forms.Button();
            this.btnThread4 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.DateLbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ThreadBtn5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThread1
            // 
            this.btnThread1.Location = new System.Drawing.Point(29, 29);
            this.btnThread1.Name = "btnThread1";
            this.btnThread1.Size = new System.Drawing.Size(106, 40);
            this.btnThread1.TabIndex = 0;
            this.btnThread1.Text = "Thread 1";
            this.btnThread1.UseVisualStyleBackColor = true;
            this.btnThread1.Click += new System.EventHandler(this.btnThread1_Click);
            // 
            // btnThread4
            // 
            this.btnThread4.Location = new System.Drawing.Point(151, 29);
            this.btnThread4.Name = "btnThread4";
            this.btnThread4.Size = new System.Drawing.Size(106, 40);
            this.btnThread4.TabIndex = 0;
            this.btnThread4.Text = "Thread 2";
            this.btnThread4.UseVisualStyleBackColor = true;
            this.btnThread4.Click += new System.EventHandler(this.btnThread4_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(510, 72);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(331, 315);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(564, 39);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(0, 20);
            this.DateLbl.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ThreadBtn5
            // 
            this.ThreadBtn5.Location = new System.Drawing.Point(735, 393);
            this.ThreadBtn5.Name = "ThreadBtn5";
            this.ThreadBtn5.Size = new System.Drawing.Size(106, 40);
            this.ThreadBtn5.TabIndex = 3;
            this.ThreadBtn5.Text = "Load File";
            this.ThreadBtn5.UseVisualStyleBackColor = true;
            this.ThreadBtn5.Click += new System.EventHandler(this.ThreadBtn5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(511, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Time:";
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Maroon;
            this.picPlay.Location = new System.Drawing.Point(12, 456);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(100, 50);
            this.picPlay.TabIndex = 5;
            this.picPlay.TabStop = false;
            this.picPlay.LocationChanged += new System.EventHandler(this.picPlay_LocationChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 527);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ThreadBtn5);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnThread4);
            this.Controls.Add(this.btnThread1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThread1;
        private System.Windows.Forms.Button btnThread4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ThreadBtn5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.Timer timer1;
    }
}

