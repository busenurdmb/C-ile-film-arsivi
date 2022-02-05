
namespace FilmArsivi
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.öZELLİKLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAMEKRANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rENKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKINDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAMEKRANDANÇIKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(370, 405);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "FİLMLİSTESİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(364, 384);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.webBrowser1);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(403, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(706, 402);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "EKRAN";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 18);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(700, 381);
            this.webBrowser1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(1061, 489);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(65, 25);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ÇIKIŞ";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öZELLİKLERToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1151, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // öZELLİKLERToolStripMenuItem
            // 
            this.öZELLİKLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAMEKRANToolStripMenuItem,
            this.rENKToolStripMenuItem,
            this.hAKKINDAToolStripMenuItem,
            this.tAMEKRANDANÇIKToolStripMenuItem});
            this.öZELLİKLERToolStripMenuItem.Name = "öZELLİKLERToolStripMenuItem";
            this.öZELLİKLERToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.öZELLİKLERToolStripMenuItem.Text = "ÖZELLİKLER";
            // 
            // tAMEKRANToolStripMenuItem
            // 
            this.tAMEKRANToolStripMenuItem.Name = "tAMEKRANToolStripMenuItem";
            this.tAMEKRANToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.tAMEKRANToolStripMenuItem.Text = "TAM EKRAN";
            this.tAMEKRANToolStripMenuItem.Click += new System.EventHandler(this.tAMEKRANToolStripMenuItem_Click);
            // 
            // rENKToolStripMenuItem
            // 
            this.rENKToolStripMenuItem.Name = "rENKToolStripMenuItem";
            this.rENKToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.rENKToolStripMenuItem.Text = " RENK DEĞİŞTİR";
            this.rENKToolStripMenuItem.Click += new System.EventHandler(this.rENKToolStripMenuItem_Click);
            // 
            // hAKKINDAToolStripMenuItem
            // 
            this.hAKKINDAToolStripMenuItem.Name = "hAKKINDAToolStripMenuItem";
            this.hAKKINDAToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.hAKKINDAToolStripMenuItem.Text = "HAKKINDA";
            this.hAKKINDAToolStripMenuItem.Click += new System.EventHandler(this.hAKKINDAToolStripMenuItem_Click);
            // 
            // tAMEKRANDANÇIKToolStripMenuItem
            // 
            this.tAMEKRANDANÇIKToolStripMenuItem.Name = "tAMEKRANDANÇIKToolStripMenuItem";
            this.tAMEKRANDANÇIKToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.tAMEKRANDANÇIKToolStripMenuItem.Text = "TAM EKRANDAN ÇIK ";
            this.tAMEKRANDANÇIKToolStripMenuItem.Click += new System.EventHandler(this.tAMEKRANDANÇIKToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Ravie", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(636, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 38);
            this.label2.TabIndex = 1;
            this.label2.Text = "DEMIRBAS";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1151, 525);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem öZELLİKLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAMEKRANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rENKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKKINDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAMEKRANDANÇIKToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

