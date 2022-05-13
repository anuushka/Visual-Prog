
namespace Lab05_MDIform_B200900802
{
    partial class FoodForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FullRadioButton = new System.Windows.Forms.RadioButton();
            this.HalfRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SoupRadioButton = new System.Windows.Forms.RadioButton();
            this.SalmonRadioButton = new System.Windows.Forms.RadioButton();
            this.LambRadioButton = new System.Windows.Forms.RadioButton();
            this.BeefRibsRadioButton = new System.Windows.Forms.RadioButton();
            this.DishQuantityTextBox = new System.Windows.Forms.TextBox();
            this.DishQuantity = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.ChickenRadioButton = new System.Windows.Forms.RadioButton();
            this.ZucchiniRadioButton = new System.Windows.Forms.RadioButton();
            this.HummusRadioButton = new System.Windows.Forms.RadioButton();
            this.SaladRadioButton = new System.Windows.Forms.RadioButton();
            this.AppQuantityTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FullRadioButton);
            this.groupBox1.Controls.Add(this.HalfRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(343, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 98);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            // 
            // FullRadioButton
            // 
            this.FullRadioButton.AutoSize = true;
            this.FullRadioButton.Location = new System.Drawing.Point(6, 56);
            this.FullRadioButton.Name = "FullRadioButton";
            this.FullRadioButton.Size = new System.Drawing.Size(103, 24);
            this.FullRadioButton.TabIndex = 1;
            this.FullRadioButton.TabStop = true;
            this.FullRadioButton.Text = "Full 10.00";
            this.FullRadioButton.UseVisualStyleBackColor = true;
            // 
            // HalfRadioButton
            // 
            this.HalfRadioButton.AutoSize = true;
            this.HalfRadioButton.Location = new System.Drawing.Point(7, 26);
            this.HalfRadioButton.Name = "HalfRadioButton";
            this.HalfRadioButton.Size = new System.Drawing.Size(98, 24);
            this.HalfRadioButton.TabIndex = 0;
            this.HalfRadioButton.TabStop = true;
            this.HalfRadioButton.Text = "Half 5.00";
            this.HalfRadioButton.UseVisualStyleBackColor = true;
            this.HalfRadioButton.CheckedChanged += new System.EventHandler(this.HalfRadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SoupRadioButton);
            this.groupBox3.Controls.Add(this.SalmonRadioButton);
            this.groupBox3.Controls.Add(this.LambRadioButton);
            this.groupBox3.Controls.Add(this.BeefRibsRadioButton);
            this.groupBox3.Controls.Add(this.DishQuantityTextBox);
            this.groupBox3.Controls.Add(this.DishQuantity);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(239, 214);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select Dish";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // SoupRadioButton
            // 
            this.SoupRadioButton.AutoSize = true;
            this.SoupRadioButton.Location = new System.Drawing.Point(11, 140);
            this.SoupRadioButton.Name = "SoupRadioButton";
            this.SoupRadioButton.Size = new System.Drawing.Size(114, 24);
            this.SoupRadioButton.TabIndex = 16;
            this.SoupRadioButton.TabStop = true;
            this.SoupRadioButton.Text = "Bone Soup";
            this.SoupRadioButton.UseVisualStyleBackColor = true;
            this.SoupRadioButton.Click += new System.EventHandler(this.SoupRadioButton_Click);
            // 
            // SalmonRadioButton
            // 
            this.SalmonRadioButton.AutoSize = true;
            this.SalmonRadioButton.Location = new System.Drawing.Point(11, 110);
            this.SalmonRadioButton.Name = "SalmonRadioButton";
            this.SalmonRadioButton.Size = new System.Drawing.Size(92, 24);
            this.SalmonRadioButton.TabIndex = 15;
            this.SalmonRadioButton.TabStop = true;
            this.SalmonRadioButton.Text = "Salmon ";
            this.SalmonRadioButton.UseVisualStyleBackColor = true;
            this.SalmonRadioButton.Click += new System.EventHandler(this.SalmonRadioButton_Click);
            // 
            // LambRadioButton
            // 
            this.LambRadioButton.AutoSize = true;
            this.LambRadioButton.Location = new System.Drawing.Point(11, 80);
            this.LambRadioButton.Name = "LambRadioButton";
            this.LambRadioButton.Size = new System.Drawing.Size(120, 24);
            this.LambRadioButton.TabIndex = 14;
            this.LambRadioButton.TabStop = true;
            this.LambRadioButton.Text = "Lamb Steak";
            this.LambRadioButton.UseVisualStyleBackColor = true;
            this.LambRadioButton.Click += new System.EventHandler(this.LambRadioButton_Click);
            // 
            // BeefRibsRadioButton
            // 
            this.BeefRibsRadioButton.AutoSize = true;
            this.BeefRibsRadioButton.Location = new System.Drawing.Point(11, 50);
            this.BeefRibsRadioButton.Name = "BeefRibsRadioButton";
            this.BeefRibsRadioButton.Size = new System.Drawing.Size(104, 24);
            this.BeefRibsRadioButton.TabIndex = 13;
            this.BeefRibsRadioButton.TabStop = true;
            this.BeefRibsRadioButton.Text = "Beef Ribs";
            this.BeefRibsRadioButton.UseVisualStyleBackColor = true;
            this.BeefRibsRadioButton.Click += new System.EventHandler(this.BeefRibsRadioButton_Click);
            // 
            // DishQuantityTextBox
            // 
            this.DishQuantityTextBox.Location = new System.Drawing.Point(97, 181);
            this.DishQuantityTextBox.Name = "DishQuantityTextBox";
            this.DishQuantityTextBox.Size = new System.Drawing.Size(31, 26);
            this.DishQuantityTextBox.TabIndex = 10;
            this.DishQuantityTextBox.Text = "0";
            // 
            // DishQuantity
            // 
            this.DishQuantity.AutoSize = true;
            this.DishQuantity.Location = new System.Drawing.Point(7, 181);
            this.DishQuantity.Name = "DishQuantity";
            this.DishQuantity.Size = new System.Drawing.Size(68, 20);
            this.DishQuantity.TabIndex = 8;
            this.DishQuantity.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Main Dish";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(389, 137);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 26);
            this.itemPriceTextBox.TabIndex = 11;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(339, 137);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(44, 20);
            this.PriceLabel.TabIndex = 9;
            this.PriceLabel.Text = "Price";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(341, 434);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 35);
            this.exitButton.TabIndex = 14;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(341, 393);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(148, 35);
            this.summaryButton.TabIndex = 13;
            this.summaryButton.Text = "Summary Report";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Location = new System.Drawing.Point(341, 352);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(148, 35);
            this.orderCompleteButton.TabIndex = 12;
            this.orderCompleteButton.Text = "Order Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(341, 311);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(148, 35);
            this.addToOrderButton.TabIndex = 11;
            this.addToOrderButton.Text = "Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // ChickenRadioButton
            // 
            this.ChickenRadioButton.AutoSize = true;
            this.ChickenRadioButton.Location = new System.Drawing.Point(11, 145);
            this.ChickenRadioButton.Name = "ChickenRadioButton";
            this.ChickenRadioButton.Size = new System.Drawing.Size(139, 24);
            this.ChickenRadioButton.TabIndex = 27;
            this.ChickenRadioButton.TabStop = true;
            this.ChickenRadioButton.Text = "Chicken Wings";
            this.ChickenRadioButton.UseVisualStyleBackColor = true;
            this.ChickenRadioButton.Click += new System.EventHandler(this.ChickenRadioButton_Click);
            // 
            // ZucchiniRadioButton
            // 
            this.ZucchiniRadioButton.AutoSize = true;
            this.ZucchiniRadioButton.Location = new System.Drawing.Point(11, 115);
            this.ZucchiniRadioButton.Name = "ZucchiniRadioButton";
            this.ZucchiniRadioButton.Size = new System.Drawing.Size(93, 24);
            this.ZucchiniRadioButton.TabIndex = 26;
            this.ZucchiniRadioButton.TabStop = true;
            this.ZucchiniRadioButton.Text = "Zucchini";
            this.ZucchiniRadioButton.UseVisualStyleBackColor = true;
            this.ZucchiniRadioButton.Click += new System.EventHandler(this.ZucchiniRadioButton_Click);
            // 
            // HummusRadioButton
            // 
            this.HummusRadioButton.AutoSize = true;
            this.HummusRadioButton.Location = new System.Drawing.Point(11, 85);
            this.HummusRadioButton.Name = "HummusRadioButton";
            this.HummusRadioButton.Size = new System.Drawing.Size(98, 24);
            this.HummusRadioButton.TabIndex = 25;
            this.HummusRadioButton.TabStop = true;
            this.HummusRadioButton.Text = "Hummus";
            this.HummusRadioButton.UseVisualStyleBackColor = true;
            this.HummusRadioButton.Click += new System.EventHandler(this.HummusRadioButton_Click);
            // 
            // SaladRadioButton
            // 
            this.SaladRadioButton.AutoSize = true;
            this.SaladRadioButton.Location = new System.Drawing.Point(11, 55);
            this.SaladRadioButton.Name = "SaladRadioButton";
            this.SaladRadioButton.Size = new System.Drawing.Size(123, 24);
            this.SaladRadioButton.TabIndex = 24;
            this.SaladRadioButton.TabStop = true;
            this.SaladRadioButton.Text = "Greek Salad";
            this.SaladRadioButton.UseVisualStyleBackColor = true;
            this.SaladRadioButton.Click += new System.EventHandler(this.SaladRadioButton_Click);
            // 
            // AppQuantityTextBox
            // 
            this.AppQuantityTextBox.Location = new System.Drawing.Point(97, 190);
            this.AppQuantityTextBox.Name = "AppQuantityTextBox";
            this.AppQuantityTextBox.Size = new System.Drawing.Size(31, 26);
            this.AppQuantityTextBox.TabIndex = 23;
            this.AppQuantityTextBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Appetizer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ChickenRadioButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ZucchiniRadioButton);
            this.groupBox2.Controls.Add(this.AppQuantityTextBox);
            this.groupBox2.Controls.Add(this.HummusRadioButton);
            this.groupBox2.Controls.Add(this.SaladRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 256);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(239, 229);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Appetizer";
            // 
            // FoodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FoodForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton FullRadioButton;
        private System.Windows.Forms.RadioButton HalfRadioButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DishQuantityTextBox;
        private System.Windows.Forms.Label DishQuantity;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.RadioButton SoupRadioButton;
        private System.Windows.Forms.RadioButton SalmonRadioButton;
        private System.Windows.Forms.RadioButton LambRadioButton;
        private System.Windows.Forms.RadioButton BeefRibsRadioButton;
        private System.Windows.Forms.RadioButton ChickenRadioButton;
        private System.Windows.Forms.RadioButton ZucchiniRadioButton;
        private System.Windows.Forms.RadioButton HummusRadioButton;
        private System.Windows.Forms.RadioButton SaladRadioButton;
        private System.Windows.Forms.TextBox AppQuantityTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}