namespace Rain
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent() {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBarPower = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.trackBarPower)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top |
                                                         System.Windows.Forms.AnchorStyles.Bottom) |
                                                        System.Windows.Forms.AnchorStyles.Left) |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(12, 73);
            this.panel1.MinimumSize = new System.Drawing.Size(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 369);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseClick);
            this.panel1.Resize += new System.EventHandler(this.panelMain_Resize);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.trackBarPower);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setup";
            // 
            // trackBarPower
            // 
            this.trackBarPower.AutoSize = false;
            this.trackBarPower.BackColor = System.Drawing.SystemColors.Control;
            this.trackBarPower.Location = new System.Drawing.Point(87, 17);
            this.trackBarPower.Minimum = -10;
            this.trackBarPower.Name = "trackBarPower";
            this.trackBarPower.Size = new System.Drawing.Size(310, 30);
            this.trackBarPower.TabIndex = 5;
            this.trackBarPower.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trackBarPower.Scroll += new System.EventHandler(this.trackBarPower_Scroll);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 4;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 453);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(674, 300);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.trackBarPower)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TrackBar trackBarPower;
    }
}