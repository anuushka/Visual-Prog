
namespace TrafficLight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redStopLight = new System.Windows.Forms.PictureBox();
            this.yellowstopLight = new System.Windows.Forms.PictureBox();
            this.greenLightStop = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.redStopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowstopLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLightStop)).BeginInit();
            this.SuspendLayout();
            // 
            // redStopLight
            // 
            this.redStopLight.Image = ((System.Drawing.Image)(resources.GetObject("redStopLight.Image")));
            this.redStopLight.Location = new System.Drawing.Point(54, 39);
            this.redStopLight.Name = "redStopLight";
            this.redStopLight.Size = new System.Drawing.Size(376, 379);
            this.redStopLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redStopLight.TabIndex = 0;
            this.redStopLight.TabStop = false;
            // 
            // yellowstopLight
            // 
            this.yellowstopLight.Image = global::TrafficLight.Properties.Resources.yellow;
            this.yellowstopLight.Location = new System.Drawing.Point(54, 39);
            this.yellowstopLight.Name = "yellowstopLight";
            this.yellowstopLight.Size = new System.Drawing.Size(376, 379);
            this.yellowstopLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.yellowstopLight.TabIndex = 1;
            this.yellowstopLight.TabStop = false;
            // 
            // greenLightStop
            // 
            this.greenLightStop.Image = ((System.Drawing.Image)(resources.GetObject("greenLightStop.Image")));
            this.greenLightStop.Location = new System.Drawing.Point(54, 39);
            this.greenLightStop.Name = "greenLightStop";
            this.greenLightStop.Size = new System.Drawing.Size(376, 379);
            this.greenLightStop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenLightStop.TabIndex = 2;
            this.greenLightStop.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(575, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(142, 48);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(575, 223);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(142, 48);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 526);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.greenLightStop);
            this.Controls.Add(this.yellowstopLight);
            this.Controls.Add(this.redStopLight);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.redStopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yellowstopLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenLightStop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox redStopLight;
        private System.Windows.Forms.PictureBox yellowstopLight;
        private System.Windows.Forms.PictureBox greenLightStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
    }
}

