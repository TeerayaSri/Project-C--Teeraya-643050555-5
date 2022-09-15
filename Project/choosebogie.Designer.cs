namespace Project
{
    partial class choosebogie
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
            this.dataChoosebogie = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.statusbokie = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backchoosestation = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.seat_1 = new System.Windows.Forms.Button();
            this.seat_6 = new System.Windows.Forms.Button();
            this.seat_2 = new System.Windows.Forms.Button();
            this.seat_7 = new System.Windows.Forms.Button();
            this.seat_3 = new System.Windows.Forms.Button();
            this.seat_8 = new System.Windows.Forms.Button();
            this.seat_9 = new System.Windows.Forms.Button();
            this.seat_5 = new System.Windows.Forms.Button();
            this.seat_10 = new System.Windows.Forms.Button();
            this.comfirm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.statusseat = new System.Windows.Forms.TextBox();
            this.seat_4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataChoosebogie)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataChoosebogie
            // 
            this.dataChoosebogie.AllowUserToAddRows = false;
            this.dataChoosebogie.AllowUserToDeleteRows = false;
            this.dataChoosebogie.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataChoosebogie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataChoosebogie.Location = new System.Drawing.Point(64, 103);
            this.dataChoosebogie.Name = "dataChoosebogie";
            this.dataChoosebogie.ReadOnly = true;
            this.dataChoosebogie.RowHeadersWidth = 51;
            this.dataChoosebogie.RowTemplate.Height = 24;
            this.dataChoosebogie.Size = new System.Drawing.Size(303, 142);
            this.dataChoosebogie.TabIndex = 1;
            this.dataChoosebogie.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.databogie);

            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(393, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "สถานะรถโบกี้นั่ง";
            // 
            // statusbokie
            // 
            this.statusbokie.BackColor = System.Drawing.SystemColors.HighlightText;
            this.statusbokie.Font = new System.Drawing.Font("TH Kodchasal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusbokie.Location = new System.Drawing.Point(398, 103);
            this.statusbokie.Name = "statusbokie";
            this.statusbokie.Size = new System.Drawing.Size(235, 32);
            this.statusbokie.TabIndex = 3;
            this.statusbokie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(393, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "ราคา";
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.SystemColors.HighlightText;
            this.price.Font = new System.Drawing.Font("TH Kodchasal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.price.Location = new System.Drawing.Point(400, 156);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(235, 32);
            this.price.TabIndex = 5;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.DarkMagenta;
            this.submit.Enabled = false;
            this.submit.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.submit.ForeColor = System.Drawing.Color.White;
            this.submit.Location = new System.Drawing.Point(470, 201);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(99, 44);
            this.submit.TabIndex = 6;
            this.submit.Text = "เลือก";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.choose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backchoosestation});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
           
            // backchoosestation
            // 
            this.backchoosestation.Font = new System.Drawing.Font("TH Kodchasal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backchoosestation.ForeColor = System.Drawing.Color.Black;
            this.backchoosestation.Name = "backchoosestation";
            this.backchoosestation.Size = new System.Drawing.Size(81, 29);
            this.backchoosestation.Text = "ย้อนกลับ";
            this.backchoosestation.Click += new System.EventHandler(this.backchoosestation_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(659, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "บาท";
            // 
            // seat_1
            // 
            this.seat_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_1.Location = new System.Drawing.Point(125, 324);
            this.seat_1.Name = "seat_1";
            this.seat_1.Size = new System.Drawing.Size(48, 39);
            this.seat_1.TabIndex = 10;
            this.seat_1.Text = "1";
            this.seat_1.UseVisualStyleBackColor = true;
            this.seat_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_6
            // 
            this.seat_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_6.Location = new System.Drawing.Point(125, 369);
            this.seat_6.Name = "seat_6";
            this.seat_6.Size = new System.Drawing.Size(48, 39);
            this.seat_6.TabIndex = 11;
            this.seat_6.Text = "6";
            this.seat_6.UseVisualStyleBackColor = true;
            this.seat_6.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_2
            // 
            this.seat_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_2.Location = new System.Drawing.Point(197, 324);
            this.seat_2.Name = "seat_2";
            this.seat_2.Size = new System.Drawing.Size(48, 39);
            this.seat_2.TabIndex = 12;
            this.seat_2.Text = "2";
            this.seat_2.UseVisualStyleBackColor = true;
            this.seat_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_7
            // 
            this.seat_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_7.Location = new System.Drawing.Point(197, 369);
            this.seat_7.Name = "seat_7";
            this.seat_7.Size = new System.Drawing.Size(48, 39);
            this.seat_7.TabIndex = 13;
            this.seat_7.Text = "7";
            this.seat_7.UseVisualStyleBackColor = true;
            this.seat_7.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_3
            // 
            this.seat_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_3.Location = new System.Drawing.Point(273, 324);
            this.seat_3.Name = "seat_3";
            this.seat_3.Size = new System.Drawing.Size(48, 39);
            this.seat_3.TabIndex = 14;
            this.seat_3.Text = "3";
            this.seat_3.UseVisualStyleBackColor = true;
            this.seat_3.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_8
            // 
            this.seat_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_8.Location = new System.Drawing.Point(273, 369);
            this.seat_8.Name = "seat_8";
            this.seat_8.Size = new System.Drawing.Size(48, 39);
            this.seat_8.TabIndex = 15;
            this.seat_8.Text = "8";
            this.seat_8.UseVisualStyleBackColor = true;
            this.seat_8.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_9
            // 
            this.seat_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_9.Location = new System.Drawing.Point(353, 369);
            this.seat_9.Name = "seat_9";
            this.seat_9.Size = new System.Drawing.Size(48, 39);
            this.seat_9.TabIndex = 17;
            this.seat_9.Text = "9";
            this.seat_9.UseVisualStyleBackColor = true;
            this.seat_9.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_5
            // 
            this.seat_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_5.Location = new System.Drawing.Point(436, 324);
            this.seat_5.Name = "seat_5";
            this.seat_5.Size = new System.Drawing.Size(48, 39);
            this.seat_5.TabIndex = 18;
            this.seat_5.Text = "5";
            this.seat_5.UseVisualStyleBackColor = true;
            this.seat_5.Click += new System.EventHandler(this.button1_Click);
            // 
            // seat_10
            // 
            this.seat_10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_10.Location = new System.Drawing.Point(436, 369);
            this.seat_10.Name = "seat_10";
            this.seat_10.Size = new System.Drawing.Size(56, 39);
            this.seat_10.TabIndex = 19;
            this.seat_10.Text = "10";
            this.seat_10.UseVisualStyleBackColor = true;
            this.seat_10.Click += new System.EventHandler(this.button1_Click);
            // 
            // comfirm
            // 
            this.comfirm.BackColor = System.Drawing.Color.DarkMagenta;
            this.comfirm.Enabled = false;
            this.comfirm.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comfirm.ForeColor = System.Drawing.Color.White;
            this.comfirm.Location = new System.Drawing.Point(595, 371);
            this.comfirm.Name = "comfirm";
            this.comfirm.Size = new System.Drawing.Size(99, 44);
            this.comfirm.TabIndex = 22;
            this.comfirm.Text = "ยืนยัน";
            this.comfirm.UseVisualStyleBackColor = false;
            this.comfirm.Click += new System.EventHandler(this.comfirm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("TH Kodchasal", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(552, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 30);
            this.label6.TabIndex = 23;
            this.label6.Text = "สถานะที่นั่ง";
            // 
            // statusseat
            // 
            this.statusseat.BackColor = System.Drawing.SystemColors.HighlightText;
            this.statusseat.Font = new System.Drawing.Font("TH Kodchasal", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.statusseat.Location = new System.Drawing.Point(535, 333);
            this.statusseat.Name = "statusseat";
            this.statusseat.Size = new System.Drawing.Size(235, 32);
            this.statusseat.TabIndex = 24;
            this.statusseat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // seat_4
            // 
            this.seat_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.seat_4.Location = new System.Drawing.Point(353, 324);
            this.seat_4.Name = "seat_4";
            this.seat_4.Size = new System.Drawing.Size(48, 39);
            this.seat_4.TabIndex = 16;
            this.seat_4.Text = "4";
            this.seat_4.UseVisualStyleBackColor = true;
            this.seat_4.Click += new System.EventHandler(this.button1_Click);
            // 
            // choosebogie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.เลือกตู้_ที่นั่ง;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusseat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comfirm);
            this.Controls.Add(this.seat_10);
            this.Controls.Add(this.seat_5);
            this.Controls.Add(this.seat_9);
            this.Controls.Add(this.seat_4);
            this.Controls.Add(this.seat_8);
            this.Controls.Add(this.seat_3);
            this.Controls.Add(this.seat_7);
            this.Controls.Add(this.seat_2);
            this.Controls.Add(this.seat_6);
            this.Controls.Add(this.seat_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusbokie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataChoosebogie);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "choosebogie";
            this.Text = "choosebogie";
            this.Load += new System.EventHandler(this.choosebogie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataChoosebogie)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataChoosebogie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusbokie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backchoosestation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button seat_1;
        private System.Windows.Forms.Button seat_6;
        private System.Windows.Forms.Button seat_2;
        private System.Windows.Forms.Button seat_7;
        private System.Windows.Forms.Button seat_3;
        private System.Windows.Forms.Button seat_8;
        private System.Windows.Forms.Button seat_4;
        private System.Windows.Forms.Button seat_9;
        private System.Windows.Forms.Button seat_5;
        private System.Windows.Forms.Button comfirm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox statusseat;
        private System.Windows.Forms.Button seat_10;
    }
}