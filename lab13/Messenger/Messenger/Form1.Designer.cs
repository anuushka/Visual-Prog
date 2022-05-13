
namespace Messenger
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.цэсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гарахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хэрэглэгчToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хэрэглэгчToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.хэрэглэгчХасахToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.цэсToolStripMenuItem,
            this.хэрэглэгчToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(554, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // цэсToolStripMenuItem
            // 
            this.цэсToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гарахToolStripMenuItem});
            this.цэсToolStripMenuItem.Name = "цэсToolStripMenuItem";
            this.цэсToolStripMenuItem.Size = new System.Drawing.Size(62, 29);
            this.цэсToolStripMenuItem.Text = "Цэс ";
            // 
            // гарахToolStripMenuItem
            // 
            this.гарахToolStripMenuItem.Name = "гарахToolStripMenuItem";
            this.гарахToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.гарахToolStripMenuItem.Size = new System.Drawing.Size(245, 34);
            this.гарахToolStripMenuItem.Text = "Гарах ";
            this.гарахToolStripMenuItem.Click += new System.EventHandler(this.гарахToolStripMenuItem_Click);
            // 
            // хэрэглэгчToolStripMenuItem
            // 
            this.хэрэглэгчToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.хэрэглэгчToolStripMenuItem1,
            this.хэрэглэгчХасахToolStripMenuItem});
            this.хэрэглэгчToolStripMenuItem.Name = "хэрэглэгчToolStripMenuItem";
            this.хэрэглэгчToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.хэрэглэгчToolStripMenuItem.Text = "Хэрэглэгч ";
            // 
            // хэрэглэгчToolStripMenuItem1
            // 
            this.хэрэглэгчToolStripMenuItem1.Name = "хэрэглэгчToolStripMenuItem1";
            this.хэрэглэгчToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.хэрэглэгчToolStripMenuItem1.Size = new System.Drawing.Size(313, 34);
            this.хэрэглэгчToolStripMenuItem1.Text = "Хэрэглэгч нэмэх ";
            this.хэрэглэгчToolStripMenuItem1.Click += new System.EventHandler(this.хэрэглэгчToolStripMenuItem1_Click);
            // 
            // хэрэглэгчХасахToolStripMenuItem
            // 
            this.хэрэглэгчХасахToolStripMenuItem.Name = "хэрэглэгчХасахToolStripMenuItem";
            this.хэрэглэгчХасахToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.хэрэглэгчХасахToolStripMenuItem.Size = new System.Drawing.Size(313, 34);
            this.хэрэглэгчХасахToolStripMenuItem.Text = "Хэрэглэгч хасах ";
            this.хэрэглэгчХасахToolStripMenuItem.Click += new System.EventHandler(this.хэрэглэгчХасахToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(13, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(529, 324);
            this.listBox1.TabIndex = 1;
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(554, 411);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Мессенжер ";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem цэсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem гарахToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хэрэглэгчToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хэрэглэгчToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem хэрэглэгчХасахToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
    }
}

