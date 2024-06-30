namespace clicker
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
            this.btnclick = new System.Windows.Forms.Button();
            this.lblnumber = new System.Windows.Forms.Label();
            this.lblx = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbly = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblStart = new System.Windows.Forms.Label();
            this.lbl_pressR = new System.Windows.Forms.Label();
            this.lblStop = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(182, 44);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(227, 252);
            this.btnclick.TabIndex = 0;
            this.btnclick.Text = "click";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // lblnumber
            // 
            this.lblnumber.AutoSize = true;
            this.lblnumber.Location = new System.Drawing.Point(250, 28);
            this.lblnumber.Name = "lblnumber";
            this.lblnumber.Size = new System.Drawing.Size(81, 13);
            this.lblnumber.TabIndex = 1;
            this.lblnumber.Text = "Number of click";
            // 
            // lblx
            // 
            this.lblx.AutoSize = true;
            this.lblx.Location = new System.Drawing.Point(42, 9);
            this.lblx.Name = "lblx";
            this.lblx.Size = new System.Drawing.Size(12, 13);
            this.lblx.TabIndex = 3;
            this.lblx.Text = "x";
            // 
            // lbly
            // 
            this.lbly.AutoSize = true;
            this.lbly.Location = new System.Drawing.Point(42, 37);
            this.lbly.Name = "lbly";
            this.lbly.Size = new System.Drawing.Size(12, 13);
            this.lbly.TabIndex = 4;
            this.lbly.Text = "y";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "y:";
            // 
            // numInterval
            // 
            this.numInterval.Location = new System.Drawing.Point(27, 107);
            this.numInterval.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(120, 20);
            this.numInterval.TabIndex = 7;
            this.numInterval.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Interval";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 34);
            this.label4.TabIndex = 9;
            this.label4.Text = "interval can be between 500 and 5000.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(157, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "_________________________";
            // 
            // LblStart
            // 
            this.LblStart.AutoSize = true;
            this.LblStart.ForeColor = System.Drawing.Color.Red;
            this.LblStart.Location = new System.Drawing.Point(118, 226);
            this.LblStart.Name = "LblStart";
            this.LblStart.Size = new System.Drawing.Size(29, 13);
            this.LblStart.TabIndex = 11;
            this.LblStart.Text = "Start";
            // 
            // lbl_pressR
            // 
            this.lbl_pressR.AutoSize = true;
            this.lbl_pressR.Location = new System.Drawing.Point(12, 226);
            this.lbl_pressR.Name = "lbl_pressR";
            this.lbl_pressR.Size = new System.Drawing.Size(79, 13);
            this.lbl_pressR.TabIndex = 12;
            this.lbl_pressR.Text = "Press R to start";
            // 
            // lblStop
            // 
            this.lblStop.AutoSize = true;
            this.lblStop.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblStop.Location = new System.Drawing.Point(118, 267);
            this.lblStop.Name = "lblStop";
            this.lblStop.Size = new System.Drawing.Size(29, 13);
            this.lblStop.TabIndex = 13;
            this.lblStop.Text = "Stop";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Press S to stop";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 330);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStop);
            this.Controls.Add(this.lbl_pressR);
            this.Controls.Add(this.LblStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numInterval);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbly);
            this.Controls.Add(this.lblx);
            this.Controls.Add(this.lblnumber);
            this.Controls.Add(this.btnclick);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Auto clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label lblnumber;
        private System.Windows.Forms.Label lblx;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbly;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblStart;
        private System.Windows.Forms.Label lbl_pressR;
        private System.Windows.Forms.Label lblStop;
        private System.Windows.Forms.Label label6;
    }
}

