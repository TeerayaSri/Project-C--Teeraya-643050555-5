namespace Project
{
    partial class admin
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
            this.resetseat = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.admins = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.bg = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ยอนกลบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showdata = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetseat
            // 
            this.resetseat.BackColor = System.Drawing.Color.PaleVioletRed;
            this.resetseat.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.resetseat.ForeColor = System.Drawing.Color.White;
            this.resetseat.Location = new System.Drawing.Point(25, 291);
            this.resetseat.Name = "resetseat";
            this.resetseat.Size = new System.Drawing.Size(136, 42);
            this.resetseat.TabIndex = 0;
            this.resetseat.Text = "Reset";
            this.resetseat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.resetseat.UseVisualStyleBackColor = false;
            this.resetseat.Click += new System.EventHandler(this.reset_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.BackColor = System.Drawing.Color.Transparent;
            this.username.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.username.ForeColor = System.Drawing.Color.Navy;
            this.username.Location = new System.Drawing.Point(572, 103);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(125, 44);
            this.username.TabIndex = 1;
            this.username.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(572, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "Password";
            // 
            // user
            // 
            this.user.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.user.Location = new System.Drawing.Point(515, 150);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(254, 51);
            this.user.TabIndex = 3;
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pw
            // 
            this.pw.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.pw.Location = new System.Drawing.Point(515, 258);
            this.pw.Name = "pw";
            this.pw.PasswordChar = '✿';
            this.pw.Size = new System.Drawing.Size(254, 51);
            this.pw.TabIndex = 4;
            this.pw.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // admins
            // 
            this.admins.BackColor = System.Drawing.Color.MidnightBlue;
            this.admins.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.admins.ForeColor = System.Drawing.Color.White;
            this.admins.Location = new System.Drawing.Point(580, 337);
            this.admins.Name = "admins";
            this.admins.Size = new System.Drawing.Size(136, 42);
            this.admins.TabIndex = 5;
            this.admins.Text = "login";
            this.admins.UseVisualStyleBackColor = false;
            this.admins.Click += new System.EventHandler(this.admins_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(85, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 34);
            this.label2.TabIndex = 7;
            this.label2.Text = "ขบวนที่";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SkyBlue;
            this.button2.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(183, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Add_Click);
            // 
            // dateTime
            // 
            this.dateTime.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTime.Location = new System.Drawing.Point(32, 214);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(343, 41);
            this.dateTime.TabIndex = 10;
            // 
            // bg
            // 
            this.bg.Font = new System.Drawing.Font("TH Kodchasal", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.bg.FormattingEnabled = true;
            this.bg.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "76",
            "99"});
            this.bg.Location = new System.Drawing.Point(32, 150);
            this.bg.Name = "bg";
            this.bg.Size = new System.Drawing.Size(194, 45);
            this.bg.TabIndex = 11;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ยอนกลบToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(823, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ยอนกลบToolStripMenuItem
            // 
            this.ยอนกลบToolStripMenuItem.Name = "ยอนกลบToolStripMenuItem";
            this.ยอนกลบToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.ยอนกลบToolStripMenuItem.Text = "ย้อนกลับ";
            this.ยอนกลบToolStripMenuItem.Click += new System.EventHandler(this.ยอนกลบToolStripMenuItem_Click);
            // 
            // showdata
            // 
            this.showdata.BackColor = System.Drawing.Color.Orange;
            this.showdata.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.showdata.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.showdata.Location = new System.Drawing.Point(105, 353);
            this.showdata.Name = "showdata";
            this.showdata.Size = new System.Drawing.Size(136, 44);
            this.showdata.TabIndex = 13;
            this.showdata.Text = "showdata";
            this.showdata.UseVisualStyleBackColor = false;
            this.showdata.Click += new System.EventHandler(this.showdata_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.ADMIN__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 494);
            this.Controls.Add(this.showdata);
            this.Controls.Add(this.bg);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.admins);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.resetseat);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "admin";
            this.Text = "Admin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetseat;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox user;
        private System.Windows.Forms.TextBox pw;
        private System.Windows.Forms.Button admins;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.ComboBox bg;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ยอนกลบToolStripMenuItem;
        private System.Windows.Forms.Button showdata;
    }
}