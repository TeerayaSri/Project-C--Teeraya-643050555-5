namespace Project
{
    partial class choosest
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.arrivaltime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numberst = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.departuretime = new System.Windows.Forms.TextBox();
            this.ยอนกลบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(309, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(419, 310);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataChoose_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(78, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "เวลาออก";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH Kodchasal", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(87, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 44);
            this.label2.TabIndex = 4;
            this.label2.Text = "เวลาถึง";
            // 
            // arrivaltime
            // 
            this.arrivaltime.Font = new System.Drawing.Font("TH Kodchasal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.arrivaltime.Location = new System.Drawing.Point(37, 219);
            this.arrivaltime.Name = "arrivaltime";
            this.arrivaltime.Size = new System.Drawing.Size(217, 47);
            this.arrivaltime.TabIndex = 5;
            this.arrivaltime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("TH Kodchasal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(88, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 42);
            this.label3.TabIndex = 6;
            this.label3.Text = "ขบวนที่";
            // 
            // numberst
            // 
            this.numberst.Font = new System.Drawing.Font("TH Kodchasal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.numberst.Location = new System.Drawing.Point(37, 323);
            this.numberst.Name = "numberst";
            this.numberst.Size = new System.Drawing.Size(217, 47);
            this.numberst.TabIndex = 7;
            this.numberst.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.SteelBlue;
            this.submit.Font = new System.Drawing.Font("TH Kodchasal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.submit.ForeColor = System.Drawing.Color.Transparent;
            this.submit.Location = new System.Drawing.Point(60, 379);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(156, 43);
            this.submit.TabIndex = 8;
            this.submit.Text = "เลือก";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // departuretime
            // 
            this.departuretime.Font = new System.Drawing.Font("TH Kodchasal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.departuretime.Location = new System.Drawing.Point(37, 134);
            this.departuretime.Name = "departuretime";
            this.departuretime.Size = new System.Drawing.Size(217, 47);
            this.departuretime.TabIndex = 12;
            this.departuretime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      
            // 
            // ยอนกลบToolStripMenuItem
            // 
            this.ยอนกลบToolStripMenuItem.Name = "ยอนกลบToolStripMenuItem";
            this.ยอนกลบToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.ยอนกลบToolStripMenuItem.Text = "ย้อนกลับ";
            this.ยอนกลบToolStripMenuItem.Click += new System.EventHandler(this.backhome_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ยอนกลบToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(740, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // choosest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.เลือกขบวนโดยสาร__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.departuretime);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.numberst);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrivaltime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "choosest";
            this.Text = "choosest";
            this.Load += new System.EventHandler(this.choosest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox arrivaltime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numberst;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox departuretime;
        private System.Windows.Forms.ToolStripMenuItem ยอนกลบToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}