namespace IA2112_SendAndRecive
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
            this.btnGetValue = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.txtClear = new System.Windows.Forms.Button();
            this.cboMinTemp = new System.Windows.Forms.ComboBox();
            this.cboMaxTemp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGetValue
            // 
            this.btnGetValue.Location = new System.Drawing.Point(103, 164);
            this.btnGetValue.Name = "btnGetValue";
            this.btnGetValue.Size = new System.Drawing.Size(127, 23);
            this.btnGetValue.TabIndex = 0;
            this.btnGetValue.Text = "Get Sensor";
            this.btnGetValue.UseVisualStyleBackColor = true;
            this.btnGetValue.Click += new System.EventHandler(this.btnGetValue_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(336, 139);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ReadOnly = true;
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(283, 343);
            this.txtShow.TabIndex = 1;
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(103, 217);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(127, 23);
            this.btnAlarm.TabIndex = 2;
            this.btnAlarm.Text = "Send Alarm";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // txtClear
            // 
            this.txtClear.Location = new System.Drawing.Point(103, 271);
            this.txtClear.Name = "txtClear";
            this.txtClear.Size = new System.Drawing.Size(127, 23);
            this.txtClear.TabIndex = 3;
            this.txtClear.Text = "Clear Tekst";
            this.txtClear.UseVisualStyleBackColor = true;
            this.txtClear.Click += new System.EventHandler(this.txtClear_Click);
            // 
            // cboMinTemp
            // 
            this.cboMinTemp.FormattingEnabled = true;
            this.cboMinTemp.Items.AddRange(new object[] {
            "19",
            "18",
            "17",
            "16",
            "15",
            "14",
            "13",
            "12",
            "11",
            "10",
            "9",
            "8"});
            this.cboMinTemp.Location = new System.Drawing.Point(154, 414);
            this.cboMinTemp.Name = "cboMinTemp";
            this.cboMinTemp.Size = new System.Drawing.Size(121, 24);
            this.cboMinTemp.TabIndex = 4;
            this.cboMinTemp.SelectedIndexChanged += new System.EventHandler(this.cboMinTemp_SelectedIndexChanged);
            // 
            // cboMaxTemp
            // 
            this.cboMaxTemp.FormattingEnabled = true;
            this.cboMaxTemp.Items.AddRange(new object[] {
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30"});
            this.cboMaxTemp.Location = new System.Drawing.Point(154, 333);
            this.cboMaxTemp.Name = "cboMaxTemp";
            this.cboMaxTemp.Size = new System.Drawing.Size(121, 24);
            this.cboMaxTemp.TabIndex = 5;
            this.cboMaxTemp.SelectedIndexChanged += new System.EventHandler(this.cboMaxTemp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Min";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 534);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboMaxTemp);
            this.Controls.Add(this.cboMinTemp);
            this.Controls.Add(this.txtClear);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnGetValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetValue;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button txtClear;
        private System.Windows.Forms.ComboBox cboMinTemp;
        private System.Windows.Forms.ComboBox cboMaxTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

