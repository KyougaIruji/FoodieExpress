using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuickBitePOS.Database;
using QuickBitePOS.UI;

namespace QuickBitePOS
{
    public partial class DaftarMenu : Form
    {
        public DaftarMenu()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new frmBeranda());
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new Keranjang());
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new Kategori());
        }
    }
}
