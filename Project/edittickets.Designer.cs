namespace Project
{
    partial class edittickets
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ยอนกลบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flname = new System.Windows.Forms.TextBox();
            this.tofrom = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ticketnumber = new System.Windows.Forms.ComboBox();
            this.idstatus = new System.Windows.Forms.TextBox();
            this.seat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.ComboBox();
            this.times = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ยอนกลบToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(824, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ยอนกลบToolStripMenuItem
            // 
            this.ยอนกลบToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.ยอนกลบToolStripMenuItem.Name = "ยอนกลบToolStripMenuItem";
            this.ยอนกลบToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.ยอนกลบToolStripMenuItem.Text = "ย้อนกลับ";
            this.ยอนกลบToolStripMenuItem.Click += new System.EventHandler(this.backhome_Click);
            // 
            // flname
            // 
            this.flname.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.flname.Location = new System.Drawing.Point(170, 127);
            this.flname.Name = "flname";
            this.flname.ReadOnly = true;
            this.flname.Size = new System.Drawing.Size(349, 41);
            this.flname.TabIndex = 2;
            this.flname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tofrom
            // 
            this.tofrom.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.tofrom.Location = new System.Drawing.Point(170, 192);
            this.tofrom.Name = "tofrom";
            this.tofrom.ReadOnly = true;
            this.tofrom.Size = new System.Drawing.Size(349, 41);
            this.tofrom.TabIndex = 3;
            // 
            // date
            // 
            this.date.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.date.Location = new System.Drawing.Point(170, 265);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(349, 41);
            this.date.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Bisque;
            this.button2.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.button2.Location = new System.Drawing.Point(196, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "ตั๋วรถไฟ";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ticketnumber
            // 
            this.ticketnumber.FormattingEnabled = true;
            this.ticketnumber.Location = new System.Drawing.Point(427, 85);
            this.ticketnumber.Name = "ticketnumber";
            this.ticketnumber.Size = new System.Drawing.Size(92, 24);
            this.ticketnumber.TabIndex = 8;
            this.ticketnumber.SelectedIndexChanged += new System.EventHandler(this.ticketnumber_SelectedIndexChanged);
            // 
            // idstatus
            // 
            this.idstatus.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.idstatus.Location = new System.Drawing.Point(539, 192);
            this.idstatus.Name = "idstatus";
            this.idstatus.Size = new System.Drawing.Size(92, 41);
            this.idstatus.TabIndex = 9;
            this.idstatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seat
            // 
            this.seat.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat.Location = new System.Drawing.Point(665, 192);
            this.seat.Name = "seat";
            this.seat.Size = new System.Drawing.Size(92, 41);
            this.seat.TabIndex = 11;
            this.seat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH Kodchasal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(98, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 12;
            this.label2.Text = "จาก>>>ถึง";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("TH Kodchasal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(544, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "ขบวนที่";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("TH Kodchasal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(673, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "ที่นั่ง";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("TH Kodchasal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(95, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "ออก>>>ถึง";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("TH Kodchasal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(97, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "วันเดินทาง";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("TH Kodchasal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(109, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "ชื่อ-สกุล";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("TH Kodchasal", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(398, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "ชั้น";
            // 
            // status
            // 
            this.status.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.status.FormattingEnabled = true;
            this.status.Items.AddRange(new object[] {
            "ชั้นพัดลม",
            "ชั้นแอร์",
            "ชั้นนอน"});
            this.status.Location = new System.Drawing.Point(430, 336);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(201, 42);
            this.status.TabIndex = 19;
            // 
            // times
            // 
            this.times.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.times.Location = new System.Drawing.Point(170, 337);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(222, 41);
            this.times.TabIndex = 20;
            this.times.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edittickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.ประวัติการจองตั๋ว;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(824, 450);
            this.Controls.Add(this.times);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.seat);
            this.Controls.Add(this.idstatus);
            this.Controls.Add(this.ticketnumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.tofrom);
            this.Controls.Add(this.flname);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "edittickets";
            this.Text = "edit";
            this.Load += new System.EventHandler(this.historyticket_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ยอนกลบToolStripMenuItem;
        private System.Windows.Forms.TextBox flname;
        private System.Windows.Forms.TextBox tofrom;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ticketnumber;
        private System.Windows.Forms.TextBox idstatus;
        private System.Windows.Forms.TextBox seat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox status;
        private System.Windows.Forms.TextBox times;
    }
}