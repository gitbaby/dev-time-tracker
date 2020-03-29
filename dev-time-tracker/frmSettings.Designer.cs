namespace DevTimeTracker
{
    partial class frmSettings
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
            this.tlpContent = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.chkAfk = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.numAfkDelay = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkAutoStart = new System.Windows.Forms.CheckBox();
            this.chkLockScreen = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.chkResetDaily = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numResetDailyAt = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbTimeFormat = new System.Windows.Forms.ComboBox();
            this.chkShowNotifications = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tlpContent.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAfkDelay)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResetDailyAt)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpContent
            // 
            this.tlpContent.ColumnCount = 2;
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpContent.Controls.Add(this.label2, 0, 6);
            this.tlpContent.Controls.Add(this.label1, 0, 4);
            this.tlpContent.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tlpContent.Controls.Add(this.label3, 0, 3);
            this.tlpContent.Controls.Add(this.label4, 0, 0);
            this.tlpContent.Controls.Add(this.chkAutoStart, 1, 0);
            this.tlpContent.Controls.Add(this.chkLockScreen, 1, 3);
            this.tlpContent.Controls.Add(this.label5, 0, 1);
            this.tlpContent.Controls.Add(this.flowLayoutPanel2, 1, 1);
            this.tlpContent.Controls.Add(this.label9, 0, 2);
            this.tlpContent.Controls.Add(this.cbTimeFormat, 1, 2);
            this.tlpContent.Controls.Add(this.chkShowNotifications, 1, 6);
            this.tlpContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpContent.Location = new System.Drawing.Point(0, 0);
            this.tlpContent.Margin = new System.Windows.Forms.Padding(6);
            this.tlpContent.Name = "tlpContent";
            this.tlpContent.Padding = new System.Windows.Forms.Padding(10);
            this.tlpContent.RowCount = 6;
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpContent.Size = new System.Drawing.Size(764, 299);
            this.tlpContent.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(16, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Suspend when away from keyboard";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAfk
            // 
            this.chkAfk.AutoSize = true;
            this.chkAfk.Location = new System.Drawing.Point(6, 12);
            this.chkAfk.Margin = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.chkAfk.Name = "chkAfk";
            this.chkAfk.Size = new System.Drawing.Size(28, 27);
            this.chkAfk.TabIndex = 6;
            this.chkAfk.UseVisualStyleBackColor = true;
            this.chkAfk.CheckedChanged += new System.EventHandler(this.chkAfk_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.chkAfk);
            this.flowLayoutPanel1.Controls.Add(this.numAfkDelay);
            this.flowLayoutPanel1.Controls.Add(this.label8);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(375, 193);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(428, 48);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // numAfkDelay
            // 
            this.numAfkDelay.Location = new System.Drawing.Point(46, 6);
            this.numAfkDelay.Margin = new System.Windows.Forms.Padding(6);
            this.numAfkDelay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numAfkDelay.Name = "numAfkDelay";
            this.numAfkDelay.Size = new System.Drawing.Size(122, 31);
            this.numAfkDelay.TabIndex = 7;
            this.numAfkDelay.ValueChanged += new System.EventHandler(this.numAfkDelay_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(180, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(201, 45);
            this.label8.TabIndex = 3;
            this.label8.Text = "minutes of inactivity";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(16, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(353, 45);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suspend when screen is locked";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(16, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(353, 45);
            this.label4.TabIndex = 0;
            this.label4.Text = "Auto start timer";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // chkAutoStart
            // 
            this.chkAutoStart.AutoSize = true;
            this.chkAutoStart.Location = new System.Drawing.Point(381, 22);
            this.chkAutoStart.Margin = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.chkAutoStart.Name = "chkAutoStart";
            this.chkAutoStart.Size = new System.Drawing.Size(28, 27);
            this.chkAutoStart.TabIndex = 1;
            this.chkAutoStart.UseVisualStyleBackColor = true;
            this.chkAutoStart.CheckedChanged += new System.EventHandler(this.chkAutoStart_CheckedChanged);
            // 
            // chkLockScreen
            // 
            this.chkLockScreen.AutoSize = true;
            this.chkLockScreen.Location = new System.Drawing.Point(381, 160);
            this.chkLockScreen.Margin = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.chkLockScreen.Name = "chkLockScreen";
            this.chkLockScreen.Size = new System.Drawing.Size(28, 27);
            this.chkLockScreen.TabIndex = 5;
            this.chkLockScreen.UseVisualStyleBackColor = true;
            this.chkLockScreen.CheckedChanged += new System.EventHandler(this.chkLockScreen_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(16, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 48);
            this.label5.TabIndex = 0;
            this.label5.Text = "Reset timer daily";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.chkResetDaily);
            this.flowLayoutPanel2.Controls.Add(this.label6);
            this.flowLayoutPanel2.Controls.Add(this.numResetDailyAt);
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(375, 55);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(428, 48);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // chkResetDaily
            // 
            this.chkResetDaily.AutoSize = true;
            this.chkResetDaily.Location = new System.Drawing.Point(6, 12);
            this.chkResetDaily.Margin = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.chkResetDaily.Name = "chkResetDaily";
            this.chkResetDaily.Size = new System.Drawing.Size(28, 27);
            this.chkResetDaily.TabIndex = 2;
            this.chkResetDaily.UseVisualStyleBackColor = true;
            this.chkResetDaily.CheckedChanged += new System.EventHandler(this.chkResetDaily_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(40, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 45);
            this.label6.TabIndex = 0;
            this.label6.Text = "At";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numResetDailyAt
            // 
            this.numResetDailyAt.Location = new System.Drawing.Point(84, 6);
            this.numResetDailyAt.Margin = new System.Windows.Forms.Padding(6);
            this.numResetDailyAt.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numResetDailyAt.Name = "numResetDailyAt";
            this.numResetDailyAt.Size = new System.Drawing.Size(112, 31);
            this.numResetDailyAt.TabIndex = 3;
            this.numResetDailyAt.ValueChanged += new System.EventHandler(this.numResetDailyAt_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(208, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 45);
            this.label7.TabIndex = 2;
            this.label7.Text = "h";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(16, 103);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(353, 45);
            this.label9.TabIndex = 0;
            this.label9.Text = "Time format";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbTimeFormat
            // 
            this.cbTimeFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTimeFormat.FormattingEnabled = true;
            this.cbTimeFormat.Location = new System.Drawing.Point(381, 109);
            this.cbTimeFormat.Margin = new System.Windows.Forms.Padding(6);
            this.cbTimeFormat.Name = "cbTimeFormat";
            this.cbTimeFormat.Size = new System.Drawing.Size(238, 33);
            this.cbTimeFormat.TabIndex = 4;
            this.cbTimeFormat.SelectedIndexChanged += new System.EventHandler(this.cbTimeFormat_SelectedIndexChanged);
            // 
            // chkShowNotifications
            // 
            this.chkShowNotifications.AutoSize = true;
            this.chkShowNotifications.Location = new System.Drawing.Point(381, 253);
            this.chkShowNotifications.Margin = new System.Windows.Forms.Padding(6, 12, 6, 6);
            this.chkShowNotifications.Name = "chkShowNotifications";
            this.chkShowNotifications.Size = new System.Drawing.Size(28, 27);
            this.chkShowNotifications.TabIndex = 8;
            this.chkShowNotifications.UseVisualStyleBackColor = true;
            this.chkShowNotifications.CheckedChanged += new System.EventHandler(this.chkShowNotifications_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(16, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Show Notifications";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(764, 299);
            this.Controls.Add(this.tlpContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(790, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(760, 330);
            this.Name = "frmSettings";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Active Time Tracker Settings";
            this.TopMost = true;
            this.tlpContent.ResumeLayout(false);
            this.tlpContent.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAfkDelay)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numResetDailyAt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpContent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkAfk;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkAutoStart;
        private System.Windows.Forms.NumericUpDown numAfkDelay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkLockScreen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkResetDaily;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbTimeFormat;
        private System.Windows.Forms.NumericUpDown numResetDailyAt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkShowNotifications;
    }
}

