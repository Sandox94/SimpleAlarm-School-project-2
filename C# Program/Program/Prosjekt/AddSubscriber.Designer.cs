namespace Prosjekt
{
    partial class AddSubscriber
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
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpAlarmtypes = new System.Windows.Forms.GroupBox();
            this.chkMotion = new System.Windows.Forms.CheckBox();
            this.chkNoCharge = new System.Windows.Forms.CheckBox();
            this.chkLowBattery = new System.Windows.Forms.CheckBox();
            this.chkHighTemp = new System.Windows.Forms.CheckBox();
            this.chkLowTemp = new System.Windows.Forms.CheckBox();
            this.chkComFault = new System.Windows.Forms.CheckBox();
            this.pnlBoxes = new System.Windows.Forms.Panel();
            this.grpAlarmtypes.SuspendLayout();
            this.pnlBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(3, 23);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(231, 20);
            this.txtEMail.TabIndex = 0;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(3, 72);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(231, 20);
            this.txtFirstName.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(3, 170);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(231, 20);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(3, 121);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(231, 20);
            this.txtLastName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "E-post";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Etternavn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tlf nummer";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Location = new System.Drawing.Point(12, 211);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(220, 30);
            this.btnAddUser.TabIndex = 4;
            this.btnAddUser.Text = "Legg til";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(262, 211);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(220, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpAlarmtypes
            // 
            this.grpAlarmtypes.Controls.Add(this.chkMotion);
            this.grpAlarmtypes.Controls.Add(this.chkNoCharge);
            this.grpAlarmtypes.Controls.Add(this.chkLowBattery);
            this.grpAlarmtypes.Controls.Add(this.chkHighTemp);
            this.grpAlarmtypes.Controls.Add(this.chkLowTemp);
            this.grpAlarmtypes.Controls.Add(this.chkComFault);
            this.grpAlarmtypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlarmtypes.Location = new System.Drawing.Point(262, 12);
            this.grpAlarmtypes.Name = "grpAlarmtypes";
            this.grpAlarmtypes.Size = new System.Drawing.Size(220, 184);
            this.grpAlarmtypes.TabIndex = 17;
            this.grpAlarmtypes.TabStop = false;
            this.grpAlarmtypes.Text = "Abboner på alarm for:";
            // 
            // chkMotion
            // 
            this.chkMotion.AutoSize = true;
            this.chkMotion.Location = new System.Drawing.Point(6, 155);
            this.chkMotion.Name = "chkMotion";
            this.chkMotion.Size = new System.Drawing.Size(93, 21);
            this.chkMotion.TabIndex = 5;
            this.chkMotion.Text = "Bevegelse";
            this.chkMotion.UseVisualStyleBackColor = true;
            // 
            // chkNoCharge
            // 
            this.chkNoCharge.AutoSize = true;
            this.chkNoCharge.Location = new System.Drawing.Point(7, 128);
            this.chkNoCharge.Name = "chkNoCharge";
            this.chkNoCharge.Size = new System.Drawing.Size(202, 21);
            this.chkNoCharge.TabIndex = 4;
            this.chkNoCharge.Text = "Manglende lading av batteri";
            this.chkNoCharge.UseVisualStyleBackColor = true;
            // 
            // chkLowBattery
            // 
            this.chkLowBattery.AutoSize = true;
            this.chkLowBattery.Location = new System.Drawing.Point(7, 101);
            this.chkLowBattery.Name = "chkLowBattery";
            this.chkLowBattery.Size = new System.Drawing.Size(124, 21);
            this.chkLowBattery.TabIndex = 3;
            this.chkLowBattery.Text = "Lavt batterinivå";
            this.chkLowBattery.UseVisualStyleBackColor = true;
            // 
            // chkHighTemp
            // 
            this.chkHighTemp.AutoSize = true;
            this.chkHighTemp.Location = new System.Drawing.Point(7, 74);
            this.chkHighTemp.Name = "chkHighTemp";
            this.chkHighTemp.Size = new System.Drawing.Size(125, 21);
            this.chkHighTemp.TabIndex = 2;
            this.chkHighTemp.Text = "Høy temperatur";
            this.chkHighTemp.UseVisualStyleBackColor = true;
            // 
            // chkLowTemp
            // 
            this.chkLowTemp.AutoSize = true;
            this.chkLowTemp.Location = new System.Drawing.Point(7, 47);
            this.chkLowTemp.Name = "chkLowTemp";
            this.chkLowTemp.Size = new System.Drawing.Size(123, 21);
            this.chkLowTemp.TabIndex = 1;
            this.chkLowTemp.Text = "Lav temperatur";
            this.chkLowTemp.UseVisualStyleBackColor = true;
            // 
            // chkComFault
            // 
            this.chkComFault.AutoSize = true;
            this.chkComFault.Location = new System.Drawing.Point(7, 20);
            this.chkComFault.Name = "chkComFault";
            this.chkComFault.Size = new System.Drawing.Size(151, 21);
            this.chkComFault.TabIndex = 0;
            this.chkComFault.Text = "Kommunikasjonsfeil";
            this.chkComFault.UseVisualStyleBackColor = true;
            // 
            // pnlBoxes
            // 
            this.pnlBoxes.Controls.Add(this.label1);
            this.pnlBoxes.Controls.Add(this.txtEMail);
            this.pnlBoxes.Controls.Add(this.txtFirstName);
            this.pnlBoxes.Controls.Add(this.label4);
            this.pnlBoxes.Controls.Add(this.txtPhoneNumber);
            this.pnlBoxes.Controls.Add(this.label3);
            this.pnlBoxes.Controls.Add(this.txtLastName);
            this.pnlBoxes.Controls.Add(this.label2);
            this.pnlBoxes.Location = new System.Drawing.Point(12, 4);
            this.pnlBoxes.Name = "pnlBoxes";
            this.pnlBoxes.Size = new System.Drawing.Size(244, 193);
            this.pnlBoxes.TabIndex = 18;
            // 
            // AddSubscriber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(494, 258);
            this.Controls.Add(this.pnlBoxes);
            this.Controls.Add(this.grpAlarmtypes);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddUser);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSubscriber";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddUser";
            this.grpAlarmtypes.ResumeLayout(false);
            this.grpAlarmtypes.PerformLayout();
            this.pnlBoxes.ResumeLayout(false);
            this.pnlBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpAlarmtypes;
        private System.Windows.Forms.CheckBox chkMotion;
        private System.Windows.Forms.CheckBox chkNoCharge;
        private System.Windows.Forms.CheckBox chkLowBattery;
        private System.Windows.Forms.CheckBox chkHighTemp;
        private System.Windows.Forms.CheckBox chkLowTemp;
        private System.Windows.Forms.CheckBox chkComFault;
        private System.Windows.Forms.Panel pnlBoxes;
    }
}