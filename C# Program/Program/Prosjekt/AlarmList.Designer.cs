namespace Prosjekt
{
    partial class AlarmList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAlarms = new System.Windows.Forms.DataGridView();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnExportToPdf = new System.Windows.Forms.Button();
            this.rdoShowAllAlarms = new System.Windows.Forms.RadioButton();
            this.dateTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimeTo = new System.Windows.Forms.DateTimePicker();
            this.rdoShowFromTo = new System.Windows.Forms.RadioButton();
            this.grpDateTime = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).BeginInit();
            this.grpDateTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAlarms
            // 
            this.dgvAlarms.AllowUserToAddRows = false;
            this.dgvAlarms.AllowUserToDeleteRows = false;
            this.dgvAlarms.AllowUserToResizeRows = false;
            this.dgvAlarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlarms.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAlarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlarms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlarms.Location = new System.Drawing.Point(12, 128);
            this.dgvAlarms.MultiSelect = false;
            this.dgvAlarms.Name = "dgvAlarms";
            this.dgvAlarms.ReadOnly = true;
            this.dgvAlarms.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvAlarms.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlarms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlarms.Size = new System.Drawing.Size(440, 480);
            this.dgvAlarms.TabIndex = 5;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Image = global::Prosjekt.Properties.Resources._32x32_Email;
            this.btnSendEmail.Location = new System.Drawing.Point(313, 18);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(140, 48);
            this.btnSendEmail.TabIndex = 6;
            this.btnSendEmail.Text = "Send til e-post";
            this.btnSendEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnExportToPdf
            // 
            this.btnExportToPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPdf.Image = global::Prosjekt.Properties.Resources._32x32_Pdf;
            this.btnExportToPdf.Location = new System.Drawing.Point(313, 72);
            this.btnExportToPdf.Name = "btnExportToPdf";
            this.btnExportToPdf.Size = new System.Drawing.Size(140, 50);
            this.btnExportToPdf.TabIndex = 7;
            this.btnExportToPdf.Text = "Eksporter til pdf";
            this.btnExportToPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportToPdf.UseVisualStyleBackColor = true;
            this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
            // 
            // rdoShowAllAlarms
            // 
            this.rdoShowAllAlarms.AutoSize = true;
            this.rdoShowAllAlarms.Checked = true;
            this.rdoShowAllAlarms.Location = new System.Drawing.Point(16, 23);
            this.rdoShowAllAlarms.Name = "rdoShowAllAlarms";
            this.rdoShowAllAlarms.Size = new System.Drawing.Size(119, 20);
            this.rdoShowAllAlarms.TabIndex = 8;
            this.rdoShowAllAlarms.TabStop = true;
            this.rdoShowAllAlarms.Text = "Vis alle alarmer";
            this.rdoShowAllAlarms.UseVisualStyleBackColor = true;
            this.rdoShowAllAlarms.CheckedChanged += new System.EventHandler(this.rdoShowAllAlarms_CheckedChanged);
            // 
            // dateTimeFrom
            // 
            this.dateTimeFrom.Enabled = false;
            this.dateTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFrom.Location = new System.Drawing.Point(16, 75);
            this.dateTimeFrom.Name = "dateTimeFrom";
            this.dateTimeFrom.Size = new System.Drawing.Size(119, 22);
            this.dateTimeFrom.TabIndex = 9;
            this.dateTimeFrom.Value = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            this.dateTimeFrom.ValueChanged += new System.EventHandler(this.dateTimeFrom_ValueChanged);
            // 
            // dateTimeTo
            // 
            this.dateTimeTo.CustomFormat = "";
            this.dateTimeTo.Enabled = false;
            this.dateTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeTo.Location = new System.Drawing.Point(155, 75);
            this.dateTimeTo.Name = "dateTimeTo";
            this.dateTimeTo.Size = new System.Drawing.Size(119, 22);
            this.dateTimeTo.TabIndex = 10;
            this.dateTimeTo.Value = new System.DateTime(2016, 4, 18, 0, 0, 0, 0);
            this.dateTimeTo.ValueChanged += new System.EventHandler(this.dateTimeTo_ValueChanged);
            // 
            // rdoShowFromTo
            // 
            this.rdoShowFromTo.AutoSize = true;
            this.rdoShowFromTo.Location = new System.Drawing.Point(16, 49);
            this.rdoShowFromTo.Name = "rdoShowFromTo";
            this.rdoShowFromTo.Size = new System.Drawing.Size(96, 20);
            this.rdoShowFromTo.TabIndex = 11;
            this.rdoShowFromTo.Text = "Vis fra dato:";
            this.rdoShowFromTo.UseVisualStyleBackColor = true;
            this.rdoShowFromTo.CheckedChanged += new System.EventHandler(this.rdoShowFromTo_CheckedChanged);
            // 
            // grpDateTime
            // 
            this.grpDateTime.Controls.Add(this.label4);
            this.grpDateTime.Controls.Add(this.dateTimeFrom);
            this.grpDateTime.Controls.Add(this.dateTimeTo);
            this.grpDateTime.Controls.Add(this.rdoShowFromTo);
            this.grpDateTime.Controls.Add(this.rdoShowAllAlarms);
            this.grpDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDateTime.Location = new System.Drawing.Point(12, 12);
            this.grpDateTime.Name = "grpDateTime";
            this.grpDateTime.Size = new System.Drawing.Size(287, 110);
            this.grpDateTime.TabIndex = 13;
            this.grpDateTime.TabStop = false;
            this.grpDateTime.Text = "Datovalg";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(152, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "Til dato:";
            // 
            // AlarmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 623);
            this.Controls.Add(this.grpDateTime);
            this.Controls.Add(this.btnExportToPdf);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.dgvAlarms);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlarmList";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AlarmList";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlarms)).EndInit();
            this.grpDateTime.ResumeLayout(false);
            this.grpDateTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlarms;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnExportToPdf;
        private System.Windows.Forms.RadioButton rdoShowAllAlarms;
        private System.Windows.Forms.DateTimePicker dateTimeFrom;
        private System.Windows.Forms.DateTimePicker dateTimeTo;
        private System.Windows.Forms.RadioButton rdoShowFromTo;
        private System.Windows.Forms.GroupBox grpDateTime;
        private System.Windows.Forms.Label label4;
    }
}