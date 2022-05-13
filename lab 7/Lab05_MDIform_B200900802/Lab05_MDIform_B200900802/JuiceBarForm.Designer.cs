
namespace Lab05_MDIform_B200900802
{
    partial class JuiceBarForm
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
            this.twelveOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.noSizeRadioButton = new System.Windows.Forms.RadioButton();
            this.twentyOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.sixteenOunceRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ladiesCheckBox = new System.Windows.Forms.CheckBox();
            this.energyBoosterCheckBox = new System.Windows.Forms.CheckBox();
            this.vitaminPackCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.itemPriceTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.wheatberrySmoothieRadioButton = new System.Windows.Forms.RadioButton();
            this.strawberryBananaRadioButton = new System.Windows.Forms.RadioButton();
            this.pomegranateSmoothieRadioButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.veggieJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.fruitJuiceRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.orderCompleteButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.twelveOunceRadioButton);
            this.groupBox1.Controls.Add(this.noSizeRadioButton);
            this.groupBox1.Controls.Add(this.twentyOunceRadioButton);
            this.groupBox1.Controls.Add(this.sixteenOunceRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // twelveOunceRadioButton
            // 
            this.twelveOunceRadioButton.AutoSize = true;
            this.twelveOunceRadioButton.Location = new System.Drawing.Point(6, 28);
            this.twelveOunceRadioButton.Name = "twelveOunceRadioButton";
            this.twelveOunceRadioButton.Size = new System.Drawing.Size(112, 24);
            this.twelveOunceRadioButton.TabIndex = 4;
            this.twelveOunceRadioButton.TabStop = true;
            this.twelveOunceRadioButton.Text = "150ml 3.00";
            this.twelveOunceRadioButton.UseVisualStyleBackColor = true;
            this.twelveOunceRadioButton.CheckedChanged += new System.EventHandler(this.twelveOunceRadioButton_CheckedChanged);
            // 
            // noSizeRadioButton
            // 
            this.noSizeRadioButton.AutoSize = true;
            this.noSizeRadioButton.Location = new System.Drawing.Point(6, 118);
            this.noSizeRadioButton.Name = "noSizeRadioButton";
            this.noSizeRadioButton.Size = new System.Drawing.Size(89, 24);
            this.noSizeRadioButton.TabIndex = 3;
            this.noSizeRadioButton.TabStop = true;
            this.noSizeRadioButton.Text = "No Size";
            this.noSizeRadioButton.UseVisualStyleBackColor = true;
            // 
            // twentyOunceRadioButton
            // 
            this.twentyOunceRadioButton.AutoSize = true;
            this.twentyOunceRadioButton.Location = new System.Drawing.Point(6, 88);
            this.twentyOunceRadioButton.Name = "twentyOunceRadioButton";
            this.twentyOunceRadioButton.Size = new System.Drawing.Size(116, 24);
            this.twentyOunceRadioButton.TabIndex = 2;
            this.twentyOunceRadioButton.TabStop = true;
            this.twentyOunceRadioButton.Text = "500 ml 4.00";
            this.twentyOunceRadioButton.UseVisualStyleBackColor = true;
            // 
            // sixteenOunceRadioButton
            // 
            this.sixteenOunceRadioButton.AutoSize = true;
            this.sixteenOunceRadioButton.Location = new System.Drawing.Point(7, 58);
            this.sixteenOunceRadioButton.Name = "sixteenOunceRadioButton";
            this.sixteenOunceRadioButton.Size = new System.Drawing.Size(112, 24);
            this.sixteenOunceRadioButton.TabIndex = 1;
            this.sixteenOunceRadioButton.TabStop = true;
            this.sixteenOunceRadioButton.Text = "250ml 3.50";
            this.sixteenOunceRadioButton.UseVisualStyleBackColor = true;
            this.sixteenOunceRadioButton.CheckedChanged += new System.EventHandler(this.sixteenOunceRadioButton_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ladiesCheckBox);
            this.groupBox2.Controls.Add(this.energyBoosterCheckBox);
            this.groupBox2.Controls.Add(this.vitaminPackCheckBox);
            this.groupBox2.Location = new System.Drawing.Point(31, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 122);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Extras 0.5$ each";
            // 
            // ladiesCheckBox
            // 
            this.ladiesCheckBox.AutoSize = true;
            this.ladiesCheckBox.Location = new System.Drawing.Point(6, 86);
            this.ladiesCheckBox.Name = "ladiesCheckBox";
            this.ladiesCheckBox.Size = new System.Drawing.Size(82, 24);
            this.ladiesCheckBox.TabIndex = 2;
            this.ladiesCheckBox.Text = "Ladies";
            this.ladiesCheckBox.UseVisualStyleBackColor = true;
            // 
            // energyBoosterCheckBox
            // 
            this.energyBoosterCheckBox.AutoSize = true;
            this.energyBoosterCheckBox.Location = new System.Drawing.Point(6, 56);
            this.energyBoosterCheckBox.Name = "energyBoosterCheckBox";
            this.energyBoosterCheckBox.Size = new System.Drawing.Size(145, 24);
            this.energyBoosterCheckBox.TabIndex = 1;
            this.energyBoosterCheckBox.Text = "Energy Booster";
            this.energyBoosterCheckBox.UseVisualStyleBackColor = true;
            // 
            // vitaminPackCheckBox
            // 
            this.vitaminPackCheckBox.AutoSize = true;
            this.vitaminPackCheckBox.Location = new System.Drawing.Point(7, 26);
            this.vitaminPackCheckBox.Name = "vitaminPackCheckBox";
            this.vitaminPackCheckBox.Size = new System.Drawing.Size(127, 24);
            this.vitaminPackCheckBox.TabIndex = 0;
            this.vitaminPackCheckBox.Text = "Vitamin Pack";
            this.vitaminPackCheckBox.UseVisualStyleBackColor = true;
            this.vitaminPackCheckBox.CheckedChanged += new System.EventHandler(this.vitaminPackCheckBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quantity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(123, 340);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(31, 26);
            this.quantityTextBox.TabIndex = 4;
            this.quantityTextBox.Text = "0";
            // 
            // itemPriceTextBox
            // 
            this.itemPriceTextBox.Location = new System.Drawing.Point(123, 373);
            this.itemPriceTextBox.Name = "itemPriceTextBox";
            this.itemPriceTextBox.Size = new System.Drawing.Size(100, 26);
            this.itemPriceTextBox.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.wheatberrySmoothieRadioButton);
            this.groupBox3.Controls.Add(this.strawberryBananaRadioButton);
            this.groupBox3.Controls.Add(this.pomegranateSmoothieRadioButton);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.veggieJuiceRadioButton);
            this.groupBox3.Controls.Add(this.fruitJuiceRadioButton);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(416, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 256);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select the drink type";
            // 
            // wheatberrySmoothieRadioButton
            // 
            this.wheatberrySmoothieRadioButton.AutoSize = true;
            this.wheatberrySmoothieRadioButton.Location = new System.Drawing.Point(6, 206);
            this.wheatberrySmoothieRadioButton.Name = "wheatberrySmoothieRadioButton";
            this.wheatberrySmoothieRadioButton.Size = new System.Drawing.Size(118, 24);
            this.wheatberrySmoothieRadioButton.TabIndex = 6;
            this.wheatberrySmoothieRadioButton.TabStop = true;
            this.wheatberrySmoothieRadioButton.Text = "WheatBerry";
            this.wheatberrySmoothieRadioButton.UseVisualStyleBackColor = true;
            // 
            // strawberryBananaRadioButton
            // 
            this.strawberryBananaRadioButton.AutoSize = true;
            this.strawberryBananaRadioButton.Location = new System.Drawing.Point(6, 176);
            this.strawberryBananaRadioButton.Name = "strawberryBananaRadioButton";
            this.strawberryBananaRadioButton.Size = new System.Drawing.Size(170, 24);
            this.strawberryBananaRadioButton.TabIndex = 5;
            this.strawberryBananaRadioButton.TabStop = true;
            this.strawberryBananaRadioButton.Text = "Strawberry Banana";
            this.strawberryBananaRadioButton.UseVisualStyleBackColor = true;
            // 
            // pomegranateSmoothieRadioButton
            // 
            this.pomegranateSmoothieRadioButton.AutoSize = true;
            this.pomegranateSmoothieRadioButton.Location = new System.Drawing.Point(6, 146);
            this.pomegranateSmoothieRadioButton.Name = "pomegranateSmoothieRadioButton";
            this.pomegranateSmoothieRadioButton.Size = new System.Drawing.Size(130, 24);
            this.pomegranateSmoothieRadioButton.TabIndex = 4;
            this.pomegranateSmoothieRadioButton.TabStop = true;
            this.pomegranateSmoothieRadioButton.Text = "Pomegranate";
            this.pomegranateSmoothieRadioButton.UseVisualStyleBackColor = true;
            this.pomegranateSmoothieRadioButton.CheckedChanged += new System.EventHandler(this.pomegranateSmoothieRadioButton_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Smoothies";
            // 
            // veggieJuiceRadioButton
            // 
            this.veggieJuiceRadioButton.AutoSize = true;
            this.veggieJuiceRadioButton.Location = new System.Drawing.Point(6, 80);
            this.veggieJuiceRadioButton.Name = "veggieJuiceRadioButton";
            this.veggieJuiceRadioButton.Size = new System.Drawing.Size(84, 24);
            this.veggieJuiceRadioButton.TabIndex = 2;
            this.veggieJuiceRadioButton.TabStop = true;
            this.veggieJuiceRadioButton.Text = "Veggie";
            this.veggieJuiceRadioButton.UseVisualStyleBackColor = true;
            this.veggieJuiceRadioButton.CheckedChanged += new System.EventHandler(this.veggieJuiceRadioButton_CheckedChanged);
            // 
            // fruitJuiceRadioButton
            // 
            this.fruitJuiceRadioButton.AutoSize = true;
            this.fruitJuiceRadioButton.Location = new System.Drawing.Point(7, 50);
            this.fruitJuiceRadioButton.Name = "fruitJuiceRadioButton";
            this.fruitJuiceRadioButton.Size = new System.Drawing.Size(66, 24);
            this.fruitJuiceRadioButton.TabIndex = 1;
            this.fruitJuiceRadioButton.TabStop = true;
            this.fruitJuiceRadioButton.Text = "Fruit";
            this.fruitJuiceRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Juices";
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.Location = new System.Drawing.Point(548, 315);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(148, 35);
            this.addToOrderButton.TabIndex = 7;
            this.addToOrderButton.Text = "Add to Order";
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // orderCompleteButton
            // 
            this.orderCompleteButton.Location = new System.Drawing.Point(548, 356);
            this.orderCompleteButton.Name = "orderCompleteButton";
            this.orderCompleteButton.Size = new System.Drawing.Size(148, 35);
            this.orderCompleteButton.TabIndex = 8;
            this.orderCompleteButton.Text = "Order Complete";
            this.orderCompleteButton.UseVisualStyleBackColor = true;
            this.orderCompleteButton.Click += new System.EventHandler(this.orderCompleteButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(548, 397);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(148, 35);
            this.summaryButton.TabIndex = 9;
            this.summaryButton.Text = "Summary Report";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(548, 438);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(148, 35);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // JuiceBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 520);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.summaryButton);
            this.Controls.Add(this.orderCompleteButton);
            this.Controls.Add(this.addToOrderButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.itemPriceTextBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "JuiceBarForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton twentyOunceRadioButton;
        private System.Windows.Forms.RadioButton sixteenOunceRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ladiesCheckBox;
        private System.Windows.Forms.CheckBox energyBoosterCheckBox;
        private System.Windows.Forms.CheckBox vitaminPackCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox itemPriceTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton wheatberrySmoothieRadioButton;
        private System.Windows.Forms.RadioButton strawberryBananaRadioButton;
        private System.Windows.Forms.RadioButton pomegranateSmoothieRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton veggieJuiceRadioButton;
        private System.Windows.Forms.RadioButton fruitJuiceRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.Button orderCompleteButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.RadioButton noSizeRadioButton;
        private System.Windows.Forms.RadioButton twelveOunceRadioButton;
    }
}

