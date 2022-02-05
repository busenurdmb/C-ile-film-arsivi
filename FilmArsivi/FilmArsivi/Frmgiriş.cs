using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilmArsivi
{
    public partial class Frmgiriş : Form
    {
        public Frmgiriş()
        {
            InitializeComponent();
        }

        private void Frmgiriş_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Form1 frm = new Form1();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmekle fr = new frmekle();
            fr.Show();
        }

        
    }
}
