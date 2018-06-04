namespace Prosjekt
{
    partial class AdministrateSubscribers
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
            this.dgvSubscribers = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEMail = new System.Windows.Forms.TextBox();
            this.grpAlarmtypes = new System.Windows.Forms.GroupBox();
            this.chkMotion = new System.Windows.Forms.CheckBox();
            this.chkNoCharge = new System.Windows.Forms.CheckBox();
            this.chkLowBattery = new System.Windows.Forms.CheckBox();
            this.chkHighTemp = new System.Windows.Forms.CheckBox();
            this.chkLowTemp = new System.Windows.Forms.CheckBox();
            this.chkComFault = new System.Windows.Forms.CheckBox();
            this.btnUpdateSubscriber = new System.Windows.Forms.Button();
            this.btnDeleteSubsriber = new System.Windows.Forms.Button();
            this.pnlBoxes = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).BeginInit();
            this.grpAlarmtypes.SuspendLayout();
            this.pnlBoxes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubscribers
            // 
            this.dgvSubscribers.AllowUserToAddRows = false;
            this.dgvSubscribers.AllowUserToDeleteRows = false;
            this.dgvSubscribers.AllowUserToResizeRows = false;
            this.dgvSubscribers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubscribers.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvSubscribers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscribers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvSubscribers.GridColor = System.Drawing.SystemColors.Control;
            this.dgvSubscribers.Location = new System.Drawing.Point(261, 12);
            this.dgvSubscribers.MultiSelect = false;
            this.dgvSubscribers.Name = "dgvSubscribers";
            this.dgvSubscribers.RowHeadersVisible = false;
            this.dgvSubscribers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSubscribers.Size = new System.Drawing.Size(677, 471);
            this.dgvSubscribers.TabIndex = 0;
            this.dgvSubscribers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubscribers_CellClick);
            this.dgvSubscribers.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvSubscribers_DataBindingComplete);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tlf nummer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Etternavn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Fornavn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "E-post";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(3, 126);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(231, 20);
            this.txtLastName.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(3, 178);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(231, 20);
            this.txtPhoneNumber.TabIndex = 11;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(3, 74);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(231, 20);
            this.txtFirstName.TabIndex = 9;
            // 
            // txtEMail
            // 
            this.txtEMail.Location = new System.Drawing.Point(3, 22);
            this.txtEMail.Name = "txtEMail";
            this.txtEMail.Size = new System.Drawing.Size(231, 20);
            this.txtEMail.TabIndex = 8;
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
            this.grpAlarmtypes.Location = new System.Drawing.Point(15, 217);
            this.grpAlarmtypes.Name = "grpAlarmtypes";
            this.grpAlarmtypes.Size = new System.Drawing.Size(231, 162);
            this.grpAlarmtypes.TabIndex = 16;
            this.grpAlarmtypes.TabStop = false;
            this.grpAlarmtypes.Text = "Abboner på alarm for:";
            // 
            // chkMotion
            // 
            this.chkMotion.AutoSize = true;
            this.chkMotion.Location = new System.Drawing.Point(7, 135);
            this.chkMotion.Name = "chkMotion";
            this.chkMotion.Size = new System.Drawing.Size(93, 21);
            this.chkMotion.TabIndex = 5;
            this.chkMotion.Text = "Bevegelse";
            this.chkMotion.UseVisualStyleBackColor = true;
            // 
            // chkNoCharge
            // 
            this.chkNoCharge.AutoSize = true;
            this.chkNoCharge.Location = new System.Drawing.Point(7, 112);
            this.chkNoCharge.Name = "chkNoCharge";
            this.chkNoCharge.Size = new System.Drawing.Size(202, 21);
            this.chkNoCharge.TabIndex = 4;
            this.chkNoCharge.Text = "Manglende lading av batteri";
            this.chkNoCharge.UseVisualStyleBackColor = true;
            // 
            // chkLowBattery
            // 
            this.chkLowBattery.AutoSize = true;
            this.chkLowBattery.Location = new System.Drawing.Point(7, 89);
            this.chkLowBattery.Name = "chkLowBattery";
            this.chkLowBattery.Size = new System.Drawing.Size(124, 21);
            this.chkLowBattery.TabIndex = 3;
            this.chkLowBattery.Text = "Lavt batterinivå";
            this.chkLowBattery.UseVisualStyleBackColor = true;
            // 
            // chkHighTemp
            // 
            this.chkHighTemp.AutoSize = true;
            this.chkHighTemp.Location = new System.Drawing.Point(7, 66);
            this.chkHighTemp.Name = "chkHighTemp";
            this.chkHighTemp.Size = new System.Drawing.Size(125, 21);
            this.chkHighTemp.TabIndex = 2;
            this.chkHighTemp.Text = "Høy temperatur";
            this.chkHighTemp.UseVisualStyleBackColor = true;
            // 
            // chkLowTemp
            // 
            this.chkLowTemp.AutoSize = true;
            this.chkLowTemp.Location = new System.Drawing.Point(7, 43);
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
            // btnUpdateSubscriber
            // 
            this.btnUpdateSubscriber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateSubscriber.Image = global::Prosjekt.Properties.Resources._32x32_Update;
            this.btnUpdateSubscriber.Location = new System.Drawing.Point(15, 393);
            this.btnUpdateSubscriber.Name = "btnUpdateSubscriber";
            this.btnUpdateSubscriber.Size = new System.Drawing.Size(231, 42);
            this.btnUpdateSubscriber.TabIndex = 17;
            this.btnUpdateSubscriber.Text = "Oppdater abonnent";
            this.btnUpdateSubscriber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdateSubscriber.UseVisualStyleBackColor = true;
            this.btnUpdateSubscriber.Click += new System.EventHandler(this.btnUpdateSubscriber_Click);
            // 
            // btnDeleteSubsriber
            // 
            this.btnDeleteSubsriber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubsriber.Image = global::Prosjekt.Properties.Resources._32x32_Delete;
            this.btnDeleteSubsriber.Location = new System.Drawing.Point(15, 441);
            this.btnDeleteSubsriber.Name = "btnDeleteSubsriber";
            this.btnDeleteSubsriber.Size = new System.Drawing.Size(231, 42);
            this.btnDeleteSubsriber.TabIndex = 18;
            this.btnDeleteSubsriber.Text = "Slett abonnent";
            this.btnDeleteSubsriber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteSubsriber.UseVisualStyleBackColor = true;
            this.btnDeleteSubsriber.Click += new System.EventHandler(this.btnDeleteSubsriber_Click);
            // 
            // pnlBoxes
            // 
            this.pnlBoxes.Controls.Add(this.txtEMail);
            this.pnlBoxes.Controls.Add(this.label1);
            this.pnlBoxes.Controls.Add(this.label2);
            this.pnlBoxes.Controls.Add(this.txtFirstName);
            this.pnlBoxes.Controls.Add(this.label4);
            this.pnlBoxes.Controls.Add(this.txtPhoneNumber);
            this.pnlBoxes.Controls.Add(this.label3);
            this.pnlBoxes.Controls.Add(this.txtLastName);
            this.pnlBoxes.Location = new System.Drawing.Point(12, 12);
            this.pnlBoxes.Name = "pnlBoxes";
            this.pnlBoxes.Size = new System.Drawing.Size(238, 199);
            this.pnlBoxes.TabIndex = 19;
            // 
            // AdministrateSubscribers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 493);
            this.Controls.Add(this.pnlBoxes);
            this.Controls.Add(this.btnDeleteSubsriber);
            this.Controls.Add(this.btnUpdateSubscriber);
            this.Controls.Add(this.grpAlarmtypes);
            this.Controls.Add(this.dgvSubscribers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdministrateSubscribers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdministrateUsers";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscribers)).EndInit();
            this.grpAlarmtypes.ResumeLayout(false);
            this.grpAlarmtypes.PerformLayout();
            this.pnlBoxes.ResumeLayout(false);
            this.pnlBoxes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubscribers;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEMail;
        private System.Windows.Forms.GroupBox grpAlarmtypes;
        private System.Windows.Forms.CheckBox chkNoCharge;
        private System.Windows.Forms.CheckBox chkLowBattery;
        private System.Windows.Forms.CheckBox chkHighTemp;
        private System.Windows.Forms.CheckBox chkLowTemp;
        private System.Windows.Forms.CheckBox chkComFault;
        private System.Windows.Forms.CheckBox chkMotion;
        private System.Windows.Forms.Button btnUpdateSubscriber;
        private System.Windows.Forms.Button btnDeleteSubsriber;
        private System.Windows.Forms.Panel pnlBoxes;
    }
}