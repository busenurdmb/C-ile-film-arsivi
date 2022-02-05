
namespace FilmArsivi
{
    partial class frmekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmekle));
            this.label1 = new System.Windows.Forms.Label();
            this.textad = new System.Windows.Forms.TextBox();
            this.textkategori = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textlink = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // textad
            // 
            this.textad.Location = new System.Drawing.Point(200, 41);
            this.textad.Name = "textad";
            this.textad.Size = new System.Drawing.Size(100, 34);
            this.textad.TabIndex = 1;
            // 
            // textkategori
            // 
            this.textkategori.Location = new System.Drawing.Point(200, 104);
            this.textkategori.Name = "textkategori";
            this.textkategori.Size = new System.Drawing.Size(100, 34);
            this.textkategori.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kategori:";
            // 
            // textlink
            // 
            this.textlink.Location = new System.Drawing.Point(200, 169);
            this.textlink.Name = "textlink";
            this.textlink.Size = new System.Drawing.Size(100, 34);
            this.textlink.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lınk:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(496, 184);
            this.dataGridView1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(358, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "EKLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(535, 472);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textlink);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textkategori);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textad);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmekle";
            this.Text = "frmekle";
            this.Load += new System.EventHandler(this.frmekle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textad;
        private System.Windows.Forms.TextBox textkategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textlink;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}