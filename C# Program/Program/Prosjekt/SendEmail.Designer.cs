namespace Prosjekt
{
    partial class SendEmail
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.cboEmail = new System.Windows.Forms.ComboBox();
            this.rdoOtherUser = new System.Windows.Forms.RadioButton();
            this.rdoUserInDatabase = new System.Windows.Forms.RadioButton();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(169, 107);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(259, 22);
            this.txtEmail.TabIndex = 0;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // cboEmail
            // 
            this.cboEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmail.FormattingEnabled = true;
            this.cboEmail.Location = new System.Drawing.Point(169, 39);
            this.cboEmail.Name = "cboEmail";
            this.cboEmail.Size = new System.Drawing.Size(259, 24);
            this.cboEmail.TabIndex = 1;
            this.cboEmail.SelectedIndexChanged += new System.EventHandler(this.cboEmail_SelectedIndexChanged);
            // 
            // rdoOtherUser
            // 
            this.rdoOtherUser.AutoSize = true;
            this.rdoOtherUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoOtherUser.Location = new System.Drawing.Point(169, 84);
            this.rdoOtherUser.Name = "rdoOtherUser";
            this.rdoOtherUser.Size = new System.Drawing.Size(151, 20);
            this.rdoOtherUser.TabIndex = 2;
            this.rdoOtherUser.Text = "Send til annen bruker";
            this.rdoOtherUser.UseVisualStyleBackColor = true;
            this.rdoOtherUser.CheckedChanged += new System.EventHandler(this.rdoOtherUser_CheckedChanged);
            // 
            // rdoUserInDatabase
            // 
            this.rdoUserInDatabase.AutoSize = true;
            this.rdoUserInDatabase.Checked = true;
            this.rdoUserInDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoUserInDatabase.Location = new System.Drawing.Point(169, 16);
            this.rdoUserInDatabase.Name = "rdoUserInDatabase";
            this.rdoUserInDatabase.Size = new System.Drawing.Size(178, 20);
            this.rdoUserInDatabase.TabIndex = 3;
            this.rdoUserInDatabase.TabStop = true;
            this.rdoUserInDatabase.Text = "Send til bruker i database";
            this.rdoUserInDatabase.UseVisualStyleBackColor = true;
            this.rdoUserInDatabase.CheckedChanged += new System.EventHandler(this.rdoUserInDatabase_CheckedChanged);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.SystemColors.Control;
            this.btnSendEmail.Enabled = false;
            this.btnSendEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmail.Image = global::Prosjekt.Properties.Resources._32x32_SendEmail;
            this.btnSendEmail.Location = new System.Drawing.Point(451, 39);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(115, 42);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send e-post";
            this.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSendEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSendEmail, "Sender pdf til ønsket e-post");
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Prosjekt.Properties.Resources.Email;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(591, 148);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.rdoUserInDatabase);
            this.Controls.Add(this.rdoOtherUser);
            this.Controls.Add(this.cboEmail);
            this.Controls.Add(this.txtEmail);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SendEmail";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SendEmail";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox cboEmail;
        private System.Windows.Forms.RadioButton rdoOtherUser;
        private System.Windows.Forms.RadioButton rdoUserInDatabase;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}