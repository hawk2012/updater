namespace updater
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressPercent = new System.Windows.Forms.ToolStripProgressBar();
            this.ServerAddress = new System.Windows.Forms.TextBox();
            this.IPName = new System.Windows.Forms.Label();
            this.sshlogin = new System.Windows.Forms.Label();
            this.sshpass = new System.Windows.Forms.Label();
            this.UpdateStatus = new System.Windows.Forms.Label();
            this.sshlog = new System.Windows.Forms.TextBox();
            this.sshp = new System.Windows.Forms.TextBox();
            this.startupdate = new System.Windows.Forms.Button();
            this.cancelupdate = new System.Windows.Forms.Button();
            this.OverallStatus = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aserver = new System.Windows.Forms.Label();
            this.ServerArchive = new System.Windows.Forms.TextBox();
            this.WebArchive = new System.Windows.Forms.TextBox();
            this.weba = new System.Windows.Forms.Label();
            this.TestConnect = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressPercent});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(881, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressPercent
            // 
            this.ProgressPercent.Name = "ProgressPercent";
            this.ProgressPercent.Size = new System.Drawing.Size(100, 16);
            // 
            // ServerAddress
            // 
            this.ServerAddress.Location = new System.Drawing.Point(95, 50);
            this.ServerAddress.Name = "ServerAddress";
            this.ServerAddress.Size = new System.Drawing.Size(134, 20);
            this.ServerAddress.TabIndex = 1;
            // 
            // IPName
            // 
            this.IPName.AutoSize = true;
            this.IPName.Location = new System.Drawing.Point(27, 53);
            this.IPName.Name = "IPName";
            this.IPName.Size = new System.Drawing.Size(62, 13);
            this.IPName.TabIndex = 2;
            this.IPName.Text = "IP сервера";
            // 
            // sshlogin
            // 
            this.sshlogin.AutoSize = true;
            this.sshlogin.Location = new System.Drawing.Point(27, 89);
            this.sshlogin.Name = "sshlogin";
            this.sshlogin.Size = new System.Drawing.Size(61, 13);
            this.sshlogin.TabIndex = 3;
            this.sshlogin.Text = "SSH логин";
            // 
            // sshpass
            // 
            this.sshpass.AutoSize = true;
            this.sshpass.Location = new System.Drawing.Point(27, 118);
            this.sshpass.Name = "sshpass";
            this.sshpass.Size = new System.Drawing.Size(68, 13);
            this.sshpass.TabIndex = 4;
            this.sshpass.Text = "SSH пароль";
            // 
            // UpdateStatus
            // 
            this.UpdateStatus.AutoSize = true;
            this.UpdateStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.UpdateStatus.Location = new System.Drawing.Point(232, 434);
            this.UpdateStatus.Name = "UpdateStatus";
            this.UpdateStatus.Size = new System.Drawing.Size(142, 17);
            this.UpdateStatus.TabIndex = 5;
            this.UpdateStatus.Text = "Готов к обновлению";
            // 
            // sshlog
            // 
            this.sshlog.Location = new System.Drawing.Point(95, 86);
            this.sshlog.Name = "sshlog";
            this.sshlog.Size = new System.Drawing.Size(134, 20);
            this.sshlog.TabIndex = 6;
            // 
            // sshp
            // 
            this.sshp.Location = new System.Drawing.Point(95, 118);
            this.sshp.Name = "sshp";
            this.sshp.Size = new System.Drawing.Size(134, 20);
            this.sshp.TabIndex = 7;
            // 
            // startupdate
            // 
            this.startupdate.Location = new System.Drawing.Point(30, 239);
            this.startupdate.Name = "startupdate";
            this.startupdate.Size = new System.Drawing.Size(128, 23);
            this.startupdate.TabIndex = 8;
            this.startupdate.Text = "Начать обновление";
            this.startupdate.UseVisualStyleBackColor = true;
            this.startupdate.Click += new System.EventHandler(this.startupdate_Click);
            // 
            // cancelupdate
            // 
            this.cancelupdate.Location = new System.Drawing.Point(164, 239);
            this.cancelupdate.Name = "cancelupdate";
            this.cancelupdate.Size = new System.Drawing.Size(130, 23);
            this.cancelupdate.TabIndex = 9;
            this.cancelupdate.Text = "Отменить обновление";
            this.cancelupdate.UseVisualStyleBackColor = true;
            this.cancelupdate.Click += new System.EventHandler(this.cancelupdate_Click);
            // 
            // OverallStatus
            // 
            this.OverallStatus.Location = new System.Drawing.Point(395, 72);
            this.OverallStatus.Name = "OverallStatus";
            this.OverallStatus.Size = new System.Drawing.Size(460, 333);
            this.OverallStatus.TabIndex = 10;
            this.OverallStatus.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(392, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Статус обновления:";
            // 
            // aserver
            // 
            this.aserver.AutoSize = true;
            this.aserver.Location = new System.Drawing.Point(27, 151);
            this.aserver.Name = "aserver";
            this.aserver.Size = new System.Drawing.Size(61, 39);
            this.aserver.TabIndex = 12;
            this.aserver.Text = "Архив с\r\nсерверной\r\nчастью";
            // 
            // ServerArchive
            // 
            this.ServerArchive.Location = new System.Drawing.Point(94, 160);
            this.ServerArchive.Name = "ServerArchive";
            this.ServerArchive.Size = new System.Drawing.Size(280, 20);
            this.ServerArchive.TabIndex = 13;
            // 
            // WebArchive
            // 
            this.WebArchive.Location = new System.Drawing.Point(94, 196);
            this.WebArchive.Name = "WebArchive";
            this.WebArchive.Size = new System.Drawing.Size(280, 20);
            this.WebArchive.TabIndex = 14;
            // 
            // weba
            // 
            this.weba.AutoSize = true;
            this.weba.Location = new System.Drawing.Point(27, 199);
            this.weba.Name = "weba";
            this.weba.Size = new System.Drawing.Size(64, 26);
            this.weba.TabIndex = 15;
            this.weba.Text = "Архив с\r\nвеб-частью";
            // 
            // TestConnect
            // 
            this.TestConnect.Location = new System.Drawing.Point(30, 268);
            this.TestConnect.Name = "TestConnect";
            this.TestConnect.Size = new System.Drawing.Size(264, 23);
            this.TestConnect.TabIndex = 16;
            this.TestConnect.Text = "Проверить связь";
            this.TestConnect.UseVisualStyleBackColor = true;
            this.TestConnect.Click += new System.EventHandler(this.TestConnect_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 456);
            this.Controls.Add(this.TestConnect);
            this.Controls.Add(this.weba);
            this.Controls.Add(this.WebArchive);
            this.Controls.Add(this.ServerArchive);
            this.Controls.Add(this.aserver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OverallStatus);
            this.Controls.Add(this.cancelupdate);
            this.Controls.Add(this.startupdate);
            this.Controls.Add(this.sshp);
            this.Controls.Add(this.sshlog);
            this.Controls.Add(this.UpdateStatus);
            this.Controls.Add(this.sshpass);
            this.Controls.Add(this.sshlogin);
            this.Controls.Add(this.IPName);
            this.Controls.Add(this.ServerAddress);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Обновление F3Tail Web";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar ProgressPercent;
        private System.Windows.Forms.TextBox ServerAddress;
        private System.Windows.Forms.Label IPName;
        private System.Windows.Forms.Label sshlogin;
        private System.Windows.Forms.Label sshpass;
        private System.Windows.Forms.Label UpdateStatus;
        private System.Windows.Forms.TextBox sshlog;
        private System.Windows.Forms.TextBox sshp;
        private System.Windows.Forms.Button startupdate;
        private System.Windows.Forms.Button cancelupdate;
        private System.Windows.Forms.RichTextBox OverallStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aserver;
        private System.Windows.Forms.TextBox ServerArchive;
        private System.Windows.Forms.TextBox WebArchive;
        private System.Windows.Forms.Label weba;
        private System.Windows.Forms.Button TestConnect;
    }
}

