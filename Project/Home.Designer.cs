namespace Project
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.login = new System.Windows.Forms.Button();
            this.member = new System.Windows.Forms.Button();
            this.adminpage = new System.Windows.Forms.Button();
            this.change = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.GB = new System.Windows.Forms.GroupBox();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.to = new System.Windows.Forms.ComboBox();
            this.from = new System.Windows.Forms.ComboBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyIcon2 = new System.Windows.Forms.NotifyIcon(this.components);
            this.GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.LightPink;
            this.login.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.login.ForeColor = System.Drawing.Color.Crimson;
            this.login.Location = new System.Drawing.Point(949, 406);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(162, 69);
            this.login.TabIndex = 0;
            this.login.Text = "เข้าสู่ระบบ";
            this.login.UseVisualStyleBackColor = false;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // member
            // 
            this.member.BackColor = System.Drawing.Color.LightSkyBlue;
            this.member.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.member.ForeColor = System.Drawing.Color.MidnightBlue;
            this.member.Location = new System.Drawing.Point(951, 327);
            this.member.Name = "member";
            this.member.Size = new System.Drawing.Size(160, 69);
            this.member.TabIndex = 1;
            this.member.Text = "สมัครสมาชิก";
            this.member.UseVisualStyleBackColor = false;
            this.member.Click += new System.EventHandler(this.member_Click);
            // 
            // adminpage
            // 
            this.adminpage.BackColor = System.Drawing.Color.SteelBlue;
            this.adminpage.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.adminpage.ForeColor = System.Drawing.Color.GhostWhite;
            this.adminpage.Location = new System.Drawing.Point(29, 0);
            this.adminpage.Name = "adminpage";
            this.adminpage.Size = new System.Drawing.Size(161, 33);
            this.adminpage.TabIndex = 5;
            this.adminpage.Text = "ระบบพนักงาน";
            this.adminpage.UseVisualStyleBackColor = false;
            this.adminpage.Click += new System.EventHandler(this.adminpage_Click);
            // 
            // change
            // 
            this.change.BackColor = System.Drawing.Color.LightBlue;
            this.change.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.change.Location = new System.Drawing.Point(219, 0);
            this.change.Name = "change";
            this.change.Size = new System.Drawing.Size(161, 33);
            this.change.TabIndex = 7;
            this.change.Text = "ประวัติการจองตั๋ว";
            this.change.UseVisualStyleBackColor = false;
            this.change.Click += new System.EventHandler(this.change_click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cancel.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cancel.Location = new System.Drawing.Point(429, 0);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(161, 33);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "ยกเลิกตั๋ว";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // GB
            // 
            this.GB.BackColor = System.Drawing.Color.Transparent;
            this.GB.Controls.Add(this.search);
            this.GB.Controls.Add(this.adminpage);
            this.GB.Controls.Add(this.change);
            this.GB.Controls.Add(this.cancel);
            this.GB.Controls.Add(this.label2);
            this.GB.Controls.Add(this.dateTimePicker1);
            this.GB.Controls.Add(this.to);
            this.GB.Controls.Add(this.from);
            this.GB.Location = new System.Drawing.Point(226, 145);
            this.GB.Name = "GB";
            this.GB.Size = new System.Drawing.Size(656, 352);
            this.GB.TabIndex = 9;
            this.GB.TabStop = false;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.MidnightBlue;
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search.Font = new System.Drawing.Font("TH Kodchasal", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.search.ForeColor = System.Drawing.SystemColors.Control;
            this.search.Location = new System.Drawing.Point(219, 229);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(186, 61);
            this.search.TabIndex = 5;
            this.search.Text = "ค้นหา";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(474, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "วันเดินทางไป";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Black;
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Highlight;
            this.dateTimePicker1.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dateTimePicker1.Location = new System.Drawing.Point(429, 93);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(186, 36);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 6, 23, 15, 48, 50, 0);
          
            // 
            // to
            // 
            this.to.BackColor = System.Drawing.Color.Azure;
            this.to.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.to.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.to.FormattingEnabled = true;
            this.to.Location = new System.Drawing.Point(219, 91);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(186, 42);
            this.to.TabIndex = 1;
            this.to.Text = "ปลายทาง";
        
            // 
            // from
            // 
            this.from.BackColor = System.Drawing.Color.Azure;
            this.from.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.from.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.from.FormattingEnabled = true;
            this.from.Location = new System.Drawing.Point(15, 91);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(186, 42);
            this.from.TabIndex = 0;
            this.from.Text = "ต้นทาง";

            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // notifyIcon2
            // 
            this.notifyIcon2.Text = "notifyIcon2";
            this.notifyIcon2.Visible = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.BackgroundImage = global::Project.Properties.Resources.การรถไฟแห่ง_ประเทศน้องนีแลนด์;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1123, 524);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.member);
            this.Controls.Add(this.login);
            this.DoubleBuffered = true;
            this.Name = "Home";
            this.Text = "main";
            this.Load += new System.EventHandler(this.Home_Load);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button member;
        private System.Windows.Forms.Button adminpage;
        private System.Windows.Forms.Button change;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.NotifyIcon notifyIcon2;
        private System.Windows.Forms.ComboBox to;
        private System.Windows.Forms.ComboBox from;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
    }
}

