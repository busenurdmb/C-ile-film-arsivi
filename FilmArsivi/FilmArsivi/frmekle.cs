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
    public partial class frmekle : Form
    {
        public frmekle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-493DFJA\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True");

        private void FİLMLER()
        {
            SqlDataAdapter dt = new SqlDataAdapter("select * from TBLFİLMLER", baglanti);
            DataTable da = new DataTable();
            dt.Fill(da);
            dataGridView1.DataSource = da;

        }

        private void frmekle_Load(object sender, EventArgs e)
        {
            FİLMLER();
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TBLFİLMLER(AD,KATEGORİ,LINK) values (@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", textad.Text);
            komut.Parameters.AddWithValue("@p2", textkategori.Text);
            komut.Parameters.AddWithValue("@p3", textlink.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            FİLMLER();
            MessageBox.Show("FİLM EKLENDİ :)");
        }
    }
}
