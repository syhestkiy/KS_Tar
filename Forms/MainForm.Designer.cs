namespace KS_Tar
{
    partial class mainForm
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.налаштуванняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.lblDrives = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
            this.comboBoxMemoryLimit = new System.Windows.Forms.ComboBox();
            this.MonitoringTimer = new System.Windows.Forms.Timer(this.components);
            this.lblTimeInterval = new System.Windows.Forms.Label();
            this.comboBoxTimeInterval = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.налаштуванняToolStripMenuItem,
            this.проToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(294, 24);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "mainMenu";
            // 
            // налаштуванняToolStripMenuItem
            // 
            this.налаштуванняToolStripMenuItem.Name = "налаштуванняToolStripMenuItem";
            this.налаштуванняToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.налаштуванняToolStripMenuItem.Text = "Налаштування";
            this.налаштуванняToolStripMenuItem.Click += new System.EventHandler(this.налаштуванняToolStripMenuItem_Click);
            // 
            // проToolStripMenuItem
            // 
            this.проToolStripMenuItem.Name = "проToolStripMenuItem";
            this.проToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.проToolStripMenuItem.Text = "Про";
            this.проToolStripMenuItem.Click += new System.EventHandler(this.проToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(207, 172);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(23, 50);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(119, 21);
            this.comboBoxDrives.TabIndex = 6;
            this.comboBoxDrives.Text = "Виберіть диск";
            // 
            // lblDrives
            // 
            this.lblDrives.AutoSize = true;
            this.lblDrives.Location = new System.Drawing.Point(20, 34);
            this.lblDrives.Name = "lblDrives";
            this.lblDrives.Size = new System.Drawing.Size(169, 13);
            this.lblDrives.TabIndex = 7;
            this.lblDrives.Text = "Локалний диск для моніторингу";
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(20, 74);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(70, 13);
            this.lblLimit.TabIndex = 9;
            this.lblLimit.Text = "Ліміт пам\'яті";
            // 
            // comboBoxMemoryLimit
            // 
            this.comboBoxMemoryLimit.FormattingEnabled = true;
            this.comboBoxMemoryLimit.Location = new System.Drawing.Point(23, 90);
            this.comboBoxMemoryLimit.Name = "comboBoxMemoryLimit";
            this.comboBoxMemoryLimit.Size = new System.Drawing.Size(119, 21);
            this.comboBoxMemoryLimit.TabIndex = 8;
            this.comboBoxMemoryLimit.Text = "Default";
            // 
            // MonitoringTimer
            // 
            this.MonitoringTimer.Tick += new System.EventHandler(this.btnStart_Click);
            // 
            // lblTimeInterval
            // 
            this.lblTimeInterval.AutoSize = true;
            this.lblTimeInterval.Location = new System.Drawing.Point(20, 114);
            this.lblTimeInterval.Name = "lblTimeInterval";
            this.lblTimeInterval.Size = new System.Drawing.Size(164, 13);
            this.lblTimeInterval.TabIndex = 11;
            this.lblTimeInterval.Text = "Ітервал часу для перевірки(хв.)";
            // 
            // comboBoxTimeInterval
            // 
            this.comboBoxTimeInterval.FormattingEnabled = true;
            this.comboBoxTimeInterval.Location = new System.Drawing.Point(23, 130);
            this.comboBoxTimeInterval.Name = "comboBoxTimeInterval";
            this.comboBoxTimeInterval.Size = new System.Drawing.Size(119, 21);
            this.comboBoxTimeInterval.TabIndex = 10;
            this.comboBoxTimeInterval.Text = "Default";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(23, 172);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "Старт";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(114, 172);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Стоп";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 209);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimeInterval);
            this.Controls.Add(this.comboBoxTimeInterval);
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.comboBoxMemoryLimit);
            this.Controls.Add(this.lblDrives);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.mainMenu);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "mainForm";
            this.Text = "Memory Limit";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmailToSand;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.Label lblDrives;
        private System.Windows.Forms.Label lblLimit;
        private System.Windows.Forms.ComboBox comboBoxMemoryLimit;
        private System.Windows.Forms.Timer MonitoringTimer;
        private System.Windows.Forms.Label lblTimeInterval;
        private System.Windows.Forms.ComboBox comboBoxTimeInterval;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolStripMenuItem налаштуванняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проToolStripMenuItem;
    }
}

