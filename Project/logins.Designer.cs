namespace Project
{
    partial class logins
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
            this.phone = new System.Windows.Forms.RadioButton();
            this.passport = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.forgotpw = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // phone
            // 
            this.phone.AutoSize = true;
            this.phone.BackColor = System.Drawing.Color.Navy;
            this.phone.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.Location = new System.Drawing.Point(115, 118);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(145, 38);
            this.phone.TabIndex = 1;
            this.phone.TabStop = true;
            this.phone.Text = "เบอร์โทรศัพท์";
            this.phone.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.phone.UseVisualStyleBackColor = false;
            this.phone.CheckedChanged += new System.EventHandler(this.phone_CheckedChanged);
            // 
            // passport
            // 
            this.passport.AutoSize = true;
            this.passport.BackColor = System.Drawing.Color.Navy;
            this.passport.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.passport.ForeColor = System.Drawing.Color.White;
            this.passport.Location = new System.Drawing.Point(296, 118);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(257, 38);
            this.passport.TabIndex = 2;
            this.passport.TabStop = true;
            this.passport.Text = "เลขบัตรประจำตัวประชาชน";
            this.passport.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.passport.UseVisualStyleBackColor = false;
            this.passport.CheckedChanged += new System.EventHandler(this.passport_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBox1.Location = new System.Drawing.Point(155, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(301, 41);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.password.Location = new System.Drawing.Point(155, 258);
            this.password.Name = "password";
            this.password.PasswordChar = '✿';
            this.password.Size = new System.Drawing.Size(301, 41);
            this.password.TabIndex = 4;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Navy;
            this.Login.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Login.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Login.Location = new System.Drawing.Point(201, 326);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(197, 71);
            this.Login.TabIndex = 5;
            this.Login.Text = "เข้าสู่ระบบ";
            this.Login.UseVisualStyleBackColor = false;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH Kodchasal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(273, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "รหัสผ่าน";
            // 
            // forgotpw
            // 
            this.forgotpw.AutoSize = true;
            this.forgotpw.BackColor = System.Drawing.Color.Transparent;
            this.forgotpw.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.forgotpw.ForeColor = System.Drawing.Color.White;
            this.forgotpw.Location = new System.Drawing.Point(253, 400);
            this.forgotpw.Name = "forgotpw";
            this.forgotpw.Size = new System.Drawing.Size(105, 30);
            this.forgotpw.TabIndex = 7;
            this.forgotpw.Text = "ลืมรหัสผ่าน?";
            this.forgotpw.Click += new System.EventHandler(this.forgotpw_Click);
            // 
            // logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.BackgroundImage = global::Project.Properties.Resources.เข้าสู่ระบบ;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(634, 429);
            this.Controls.Add(this.forgotpw);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.phone);
            this.DoubleBuffered = true;
            this.Name = "logins";
            this.Text = "logins";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton phone;
        private System.Windows.Forms.RadioButton passport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label forgotpw;
    }
}