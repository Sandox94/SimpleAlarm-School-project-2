namespace Prosjekt
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lowTempLimitUpDown = new System.Windows.Forms.NumericUpDown();
            this.highTempLimitUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lowBatteryLimitUpDown = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.readIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lowTempLimitUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.highTempLimitUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowBatteryLimitUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logIntervalUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.readIntervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Høy-grense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Lav-grense";
            // 
            // lowTempLimitUpDown
            // 
            this.lowTempLimitUpDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.lowTempLimitUpDown.Location = new System.Drawing.Point(167, 55);
            this.lowTempLimitUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.lowTempLimitUpDown.Name = "lowTempLimitUpDown";
            this.lowTempLimitUpDown.Size = new System.Drawing.Size(81, 20);
            this.lowTempLimitUpDown.TabIndex = 7;
            this.lowTempLimitUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lowTempLimitUpDown.ValueChanged += new System.EventHandler(this.lowTempLimitUpDown_ValueChanged);
            // 
            // highTempLimitUpDown
            // 
            this.highTempLimitUpDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.highTempLimitUpDown.Location = new System.Drawing.Point(167, 86);
            this.highTempLimitUpDown.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.highTempLimitUpDown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.highTempLimitUpDown.Name = "highTempLimitUpDown";
            this.highTempLimitUpDown.Size = new System.Drawing.Size(81, 20);
            this.highTempLimitUpDown.TabIndex = 6;
            this.highTempLimitUpDown.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.highTempLimitUpDown.ValueChanged += new System.EventHandler(this.highTempLimitUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Temperatur instillinger";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(15, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Strøm instillinger";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Lav-grense";
            // 
            // lowBatteryLimitUpDown
            // 
            this.lowBatteryLimitUpDown.Location = new System.Drawing.Point(167, 165);
            this.lowBatteryLimitUpDown.Name = "lowBatteryLimitUpDown";
            this.lowBatteryLimitUpDown.Size = new System.Drawing.Size(81, 20);
            this.lowBatteryLimitUpDown.TabIndex = 12;
            this.lowBatteryLimitUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.lowBatteryLimitUpDown.ValueChanged += new System.EventHandler(this.lowBatteryLimitUpDown_ValueChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(15, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "Lese- og skriventervall";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 105);
            this.panel1.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Location = new System.Drawing.Point(0, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(382, 2);
            this.label8.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 54);
            this.label7.TabIndex = 17;
            this.label7.Text = "Innstillinger";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.logIntervalUpDown);
            this.panel2.Controls.Add(this.readIntervalUpDown);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.highTempLimitUpDown);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lowTempLimitUpDown);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lowBatteryLimitUpDown);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 122);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(354, 324);
            this.panel2.TabIndex = 16;
            // 
            // logIntervalUpDown
            // 
            this.logIntervalUpDown.Location = new System.Drawing.Point(166, 280);
            this.logIntervalUpDown.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.logIntervalUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.logIntervalUpDown.Name = "logIntervalUpDown";
            this.logIntervalUpDown.Size = new System.Drawing.Size(81, 20);
            this.logIntervalUpDown.TabIndex = 20;
            this.logIntervalUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.logIntervalUpDown.ValueChanged += new System.EventHandler(this.logIntervalUpDown_ValueChanged);
            // 
            // readIntervalUpDown
            // 
            this.readIntervalUpDown.Location = new System.Drawing.Point(167, 248);
            this.readIntervalUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.readIntervalUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.readIntervalUpDown.Name = "readIntervalUpDown";
            this.readIntervalUpDown.Size = new System.Drawing.Size(81, 20);
            this.readIntervalUpDown.TabIndex = 19;
            this.readIntervalUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.readIntervalUpDown.ValueChanged += new System.EventHandler(this.readIntervalUpDown_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(16, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Leseintervall (sek):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Lagrinsintervall (min):";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 460);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            ((System.ComponentModel.ISupportInitialize)(this.lowTempLimitUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.highTempLimitUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowBatteryLimitUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logIntervalUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.readIntervalUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown lowTempLimitUpDown;
        private System.Windows.Forms.NumericUpDown highTempLimitUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown lowBatteryLimitUpDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown logIntervalUpDown;
        private System.Windows.Forms.NumericUpDown readIntervalUpDown;
    }
}