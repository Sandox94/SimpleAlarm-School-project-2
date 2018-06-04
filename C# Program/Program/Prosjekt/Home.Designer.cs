namespace Prosjekt
{
    partial class Home
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnShowGraph = new System.Windows.Forms.Button();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeactivateMotionAlarm = new System.Windows.Forms.Button();
            this.btnActivateMotionAlarm = new System.Windows.Forms.Button();
            this.lblMotion = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblArduinoConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblBatteryPercent = new System.Windows.Forms.Label();
            this.grpAlarm = new System.Windows.Forms.GroupBox();
            this.dgvTop5Alarms = new System.Windows.Forms.DataGridView();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.btnExportToPdf = new System.Windows.Forms.Button();
            this.btnShowAlarmlist = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avsluttToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrateUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hjelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visHjelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblPowerAdapter = new System.Windows.Forms.Label();
            this.btnSettings = new System.Windows.Forms.Button();
            this.tmrRead = new System.Windows.Forms.Timer(this.components);
            this.tmrLog = new System.Windows.Forms.Timer(this.components);
            this.tmrActivateMotion = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5Alarms)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.graph);
            this.groupBox1.Controls.Add(this.btnShowGraph);
            this.groupBox1.Controls.Add(this.lblTemperature);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(244, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 374);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperatur";
            // 
            // graph
            // 
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.ScaleView.SizeType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Seconds;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisX.Title = "Klokkeslett";
            chartArea1.AxisY.Title = "Temperatur";
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea1.Name = "ChartArea1";
            this.graph.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(26, 84);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            this.graph.Series.Add(series1);
            this.graph.Size = new System.Drawing.Size(523, 271);
            this.graph.TabIndex = 15;
            // 
            // btnShowGraph
            // 
            this.btnShowGraph.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowGraph.Image = global::Prosjekt.Properties.Resources._32x32_Graph;
            this.btnShowGraph.Location = new System.Drawing.Point(177, 31);
            this.btnShowGraph.Name = "btnShowGraph";
            this.btnShowGraph.Size = new System.Drawing.Size(140, 42);
            this.btnShowGraph.TabIndex = 6;
            this.btnShowGraph.Text = "  Vis  historisk graf";
            this.btnShowGraph.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowGraph.UseVisualStyleBackColor = true;
            this.btnShowGraph.Click += new System.EventHandler(this.btnShowGraph_Click);
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTemperature.Location = new System.Drawing.Point(16, 26);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(145, 55);
            this.lblTemperature.TabIndex = 0;
            this.lblTemperature.Text = "10 °C";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeactivateMotionAlarm);
            this.groupBox2.Controls.Add(this.btnActivateMotionAlarm);
            this.groupBox2.Controls.Add(this.lblMotion);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(215, 129);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bevegelse";
            // 
            // btnDeactivateMotionAlarm
            // 
            this.btnDeactivateMotionAlarm.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeactivateMotionAlarm.BackgroundImage = global::Prosjekt.Properties.Resources.no_red;
            this.btnDeactivateMotionAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeactivateMotionAlarm.Location = new System.Drawing.Point(104, 66);
            this.btnDeactivateMotionAlarm.Name = "btnDeactivateMotionAlarm";
            this.btnDeactivateMotionAlarm.Size = new System.Drawing.Size(50, 50);
            this.btnDeactivateMotionAlarm.TabIndex = 3;
            this.btnDeactivateMotionAlarm.UseVisualStyleBackColor = false;
            this.btnDeactivateMotionAlarm.Click += new System.EventHandler(this.btnDeactivateMotionAlarm_Click);
            // 
            // btnActivateMotionAlarm
            // 
            this.btnActivateMotionAlarm.BackColor = System.Drawing.SystemColors.Control;
            this.btnActivateMotionAlarm.BackgroundImage = global::Prosjekt.Properties.Resources.yes_green;
            this.btnActivateMotionAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivateMotionAlarm.Location = new System.Drawing.Point(13, 66);
            this.btnActivateMotionAlarm.Name = "btnActivateMotionAlarm";
            this.btnActivateMotionAlarm.Size = new System.Drawing.Size(50, 50);
            this.btnActivateMotionAlarm.TabIndex = 2;
            this.btnActivateMotionAlarm.UseVisualStyleBackColor = false;
            this.btnActivateMotionAlarm.Click += new System.EventHandler(this.btnActivateMotionAlarm_Click);
            // 
            // lblMotion
            // 
            this.lblMotion.AutoSize = true;
            this.lblMotion.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMotion.Location = new System.Drawing.Point(6, 22);
            this.lblMotion.Name = "lblMotion";
            this.lblMotion.Size = new System.Drawing.Size(159, 37);
            this.lblMotion.TabIndex = 1;
            this.lblMotion.Text = "Deaktivert";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblArduinoConnected});
            this.statusStrip.Location = new System.Drawing.Point(0, 597);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(842, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblArduinoConnected
            // 
            this.lblArduinoConnected.Name = "lblArduinoConnected";
            this.lblArduinoConnected.Size = new System.Drawing.Size(88, 17);
            this.lblArduinoConnected.Tag = "";
            this.lblArduinoConnected.Text = "Not Connected";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(86, 17);
            this.toolStripStatusLabel1.Text = "Not connected";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblBatteryPercent);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(215, 81);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Batterspenning";
            // 
            // lblBatteryPercent
            // 
            this.lblBatteryPercent.AutoSize = true;
            this.lblBatteryPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatteryPercent.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBatteryPercent.Location = new System.Drawing.Point(16, 28);
            this.lblBatteryPercent.Name = "lblBatteryPercent";
            this.lblBatteryPercent.Size = new System.Drawing.Size(110, 46);
            this.lblBatteryPercent.TabIndex = 5;
            this.lblBatteryPercent.Text = "88 %";
            // 
            // grpAlarm
            // 
            this.grpAlarm.Controls.Add(this.dgvTop5Alarms);
            this.grpAlarm.Controls.Add(this.btnSendEmail);
            this.grpAlarm.Controls.Add(this.btnExportToPdf);
            this.grpAlarm.Controls.Add(this.btnShowAlarmlist);
            this.grpAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAlarm.Location = new System.Drawing.Point(12, 407);
            this.grpAlarm.Name = "grpAlarm";
            this.grpAlarm.Size = new System.Drawing.Size(807, 177);
            this.grpAlarm.TabIndex = 9;
            this.grpAlarm.TabStop = false;
            this.grpAlarm.Text = "Alarmer";
            // 
            // dgvTop5Alarms
            // 
            this.dgvTop5Alarms.AllowUserToAddRows = false;
            this.dgvTop5Alarms.AllowUserToDeleteRows = false;
            this.dgvTop5Alarms.AllowUserToResizeRows = false;
            this.dgvTop5Alarms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop5Alarms.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTop5Alarms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop5Alarms.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvTop5Alarms.Location = new System.Drawing.Point(10, 19);
            this.dgvTop5Alarms.MultiSelect = false;
            this.dgvTop5Alarms.Name = "dgvTop5Alarms";
            this.dgvTop5Alarms.ReadOnly = true;
            this.dgvTop5Alarms.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dgvTop5Alarms.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTop5Alarms.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTop5Alarms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTop5Alarms.Size = new System.Drawing.Size(636, 144);
            this.dgvTop5Alarms.TabIndex = 4;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.Image = global::Prosjekt.Properties.Resources._32x32_Email;
            this.btnSendEmail.Location = new System.Drawing.Point(659, 121);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(140, 42);
            this.btnSendEmail.TabIndex = 3;
            this.btnSendEmail.Text = "Send til e-post";
            this.btnSendEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // btnExportToPdf
            // 
            this.btnExportToPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportToPdf.Image = global::Prosjekt.Properties.Resources._32x32_Pdf;
            this.btnExportToPdf.Location = new System.Drawing.Point(659, 67);
            this.btnExportToPdf.Name = "btnExportToPdf";
            this.btnExportToPdf.Size = new System.Drawing.Size(140, 42);
            this.btnExportToPdf.TabIndex = 2;
            this.btnExportToPdf.Text = "Eksporter til pdf";
            this.btnExportToPdf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExportToPdf.UseVisualStyleBackColor = true;
            this.btnExportToPdf.Click += new System.EventHandler(this.btnExportToPdf_Click);
            // 
            // btnShowAlarmlist
            // 
            this.btnShowAlarmlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAlarmlist.Image = global::Prosjekt.Properties.Resources._32x32_AlarmList;
            this.btnShowAlarmlist.Location = new System.Drawing.Point(659, 19);
            this.btnShowAlarmlist.Name = "btnShowAlarmlist";
            this.btnShowAlarmlist.Size = new System.Drawing.Size(140, 42);
            this.btnShowAlarmlist.TabIndex = 1;
            this.btnShowAlarmlist.Text = "Vis alarmliste";
            this.btnShowAlarmlist.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowAlarmlist.UseVisualStyleBackColor = true;
            this.btnShowAlarmlist.Click += new System.EventHandler(this.btnShowAlarmlist_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.hjelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(842, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filToolStripMenuItem
            // 
            this.filToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avsluttToolStripMenuItem});
            this.filToolStripMenuItem.Name = "filToolStripMenuItem";
            this.filToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.filToolStripMenuItem.Text = "Fil";
            // 
            // avsluttToolStripMenuItem
            // 
            this.avsluttToolStripMenuItem.Name = "avsluttToolStripMenuItem";
            this.avsluttToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.avsluttToolStripMenuItem.Text = "Avslutt";
            this.avsluttToolStripMenuItem.Click += new System.EventHandler(this.avsluttToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewUserToolStripMenuItem,
            this.administrateUsersToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.usersToolStripMenuItem.Text = "Abonnenter";
            // 
            // addNewUserToolStripMenuItem
            // 
            this.addNewUserToolStripMenuItem.Name = "addNewUserToolStripMenuItem";
            this.addNewUserToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.addNewUserToolStripMenuItem.Text = "Legg til ny...";
            this.addNewUserToolStripMenuItem.Click += new System.EventHandler(this.addNewUserToolStripMenuItem_Click);
            // 
            // administrateUsersToolStripMenuItem
            // 
            this.administrateUsersToolStripMenuItem.Name = "administrateUsersToolStripMenuItem";
            this.administrateUsersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.administrateUsersToolStripMenuItem.Text = "Administrer brukerer";
            this.administrateUsersToolStripMenuItem.Click += new System.EventHandler(this.administrateUsersToolStripMenuItem_Click);
            // 
            // hjelpToolStripMenuItem
            // 
            this.hjelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visHjelpToolStripMenuItem,
            this.aboutProgramToolStripMenuItem});
            this.hjelpToolStripMenuItem.Name = "hjelpToolStripMenuItem";
            this.hjelpToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.hjelpToolStripMenuItem.Text = "Hjelp";
            // 
            // visHjelpToolStripMenuItem
            // 
            this.visHjelpToolStripMenuItem.Name = "visHjelpToolStripMenuItem";
            this.visHjelpToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.visHjelpToolStripMenuItem.Text = "Vis hjelp";
            // 
            // aboutProgramToolStripMenuItem
            // 
            this.aboutProgramToolStripMenuItem.Name = "aboutProgramToolStripMenuItem";
            this.aboutProgramToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.aboutProgramToolStripMenuItem.Text = "Om programmet";
            this.aboutProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutProgramToolStripMenuItem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblPowerAdapter);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 87);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(215, 81);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Strømadapter";
            // 
            // lblPowerAdapter
            // 
            this.lblPowerAdapter.AutoSize = true;
            this.lblPowerAdapter.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerAdapter.ForeColor = System.Drawing.Color.Firebrick;
            this.lblPowerAdapter.Location = new System.Drawing.Point(6, 28);
            this.lblPowerAdapter.Name = "lblPowerAdapter";
            this.lblPowerAdapter.Size = new System.Drawing.Size(191, 37);
            this.lblPowerAdapter.TabIndex = 4;
            this.lblPowerAdapter.Text = "Ikke tilkoblet";
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.Image = global::Prosjekt.Properties.Resources._32x32_Settings;
            this.btnSettings.Location = new System.Drawing.Point(12, 30);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(215, 42);
            this.btnSettings.TabIndex = 16;
            this.btnSettings.Text = "  Vis innstillinger";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // tmrRead
            // 
            this.tmrRead.Tick += new System.EventHandler(this.tmrRead_Tick);
            // 
            // tmrLog
            // 
            this.tmrLog.Tick += new System.EventHandler(this.tmrLog_Tick);
            // 
            // tmrActivateMotion
            // 
            this.tmrActivateMotion.Interval = 1000;
            this.tmrActivateMotion.Tick += new System.EventHandler(this.tmrActivateMotion_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(842, 619);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grpAlarm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Home";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpAlarm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTop5Alarms)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMotion;
        private System.Windows.Forms.Button btnActivateMotionAlarm;
        private System.Windows.Forms.Button btnDeactivateMotionAlarm;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnShowGraph;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblBatteryPercent;
        private System.Windows.Forms.GroupBox grpAlarm;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.Button btnExportToPdf;
        private System.Windows.Forms.Button btnShowAlarmlist;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avsluttToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrateUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hjelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visHjelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel lblArduinoConnected;
        private System.Windows.Forms.DataGridView dgvTop5Alarms;
        private System.Windows.Forms.ToolStripMenuItem aboutProgramToolStripMenuItem;
        public System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblPowerAdapter;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Timer tmrRead;
        private System.Windows.Forms.Timer tmrLog;
        private System.Windows.Forms.Timer tmrActivateMotion;
    }
}

