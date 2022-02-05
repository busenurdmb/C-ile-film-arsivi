using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FilmArsivi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-493DFJA\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True");
       public void FİLMLER()
        {
            SqlDataAdapter dt = new SqlDataAdapter("select * from TBLFİLMLER", baglanti);
            DataTable da = new DataTable();
            dt.Fill(da);
            dataGridView1.DataSource = da;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            FİLMLER();
           

           
          
        }

        

        

        private void hAKKINDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje BUSE NUR DEMİRBAŞ tarafından 4 şubat 2022 yılında hazırlanmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning); ;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void rENKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] renk = { "blue", "yellow", "red", "white","brown" };
             Random rn = new Random();
             int sayi = rn.Next(renk.Length);
             this.BackColor = Color.FromName(renk[sayi]);
       
          




        }

        private void tAMEKRANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.WindowState = FormWindowState.Maximized;
            groupBox2.Dock = DockStyle.Fill;
            groupBox1.Visible = false;
            linkLabel1.Visible = false;
           label2.Visible = false;

            


        }

        private void tAMEKRANDANÇIKToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
            groupBox2.Dock = DockStyle.None;
            groupBox1.Visible = true;
           linkLabel1.Visible = true;
           label2.Visible = false;
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secılen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secılen].Cells[3].Value.ToString();
            webBrowser1.Navigate(link);
        }
    }
}
