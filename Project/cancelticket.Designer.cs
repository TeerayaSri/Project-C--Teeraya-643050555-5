namespace Project
{
    partial class cancelticket
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
            this.dataticketmember = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ยอนกลบToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ticketnumber = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataticketmember)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataticketmember
            // 
            this.dataticketmember.AllowUserToAddRows = false;
            this.dataticketmember.AllowUserToDeleteRows = false;
            this.dataticketmember.BackgroundColor = System.Drawing.Color.White;
            this.dataticketmember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataticketmember.Location = new System.Drawing.Point(105, 129);
            this.dataticketmember.Name = "dataticketmember";
            this.dataticketmember.ReadOnly = true;
            this.dataticketmember.RowHeadersWidth = 51;
            this.dataticketmember.RowTemplate.Height = 24;
            this.dataticketmember.Size = new System.Drawing.Size(599, 223);
            this.dataticketmember.TabIndex = 1;
            this.dataticketmember.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataticketmember_CellClick);
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ยอนกลบToolStripMenuItem
            // 
            this.ยอนกลบToolStripMenuItem.Name = "ยอนกลบToolStripMenuItem";
            this.ยอนกลบToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.ยอนกลบToolStripMenuItem.Text = "ย้อนกลับ";
            this.ยอนกลบToolStripMenuItem.Click += new System.EventHandler(this.backhome_click);
            // 
            // ticketnumber
            // 
            this.ticketnumber.Location = new System.Drawing.Point(531, 62);
            this.ticketnumber.Name = "ticketnumber";
            this.ticketnumber.Size = new System.Drawing.Size(242, 61);
            this.ticketnumber.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ticketnumber.StateCommon.Border.Rounding = 30;
            this.ticketnumber.StateCommon.Content.Font = new System.Drawing.Font("TH Kodchasal", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ticketnumber.TabIndex = 3;
            this.ticketnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ticketnumber.TextChanged += new System.EventHandler(this.ticketnumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("TH Kodchasal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(616, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 42);
            this.label2.TabIndex = 4;
            this.label2.Text = "รหัสตั๋ว";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Font = new System.Drawing.Font("TH Kodchasal", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(504, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 43);
            this.button1.TabIndex = 5;
            this.button1.Text = "ยกเลิก";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::Project.Properties.Resources.ยกเลิก_การจองตั๋ว__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketnumber);
            this.Controls.Add(this.dataticketmember);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "cancelticket";
            this.Text = "cancelticket";
            this.Load += new System.EventHandler(this.cancelticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataticketmember)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataticketmember;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ยอนกลบToolStripMenuItem;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox ticketnumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}