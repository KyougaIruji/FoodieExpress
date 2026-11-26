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
    public partial class frmBeranda : Form
    {
        public frmBeranda()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {

        }

        private void txtCariMenu_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCari_Click(object sender, EventArgs e)
        {
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new Keranjang());
        }
        
        private void btnKategori_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new Kategori());
        }

        private void btnDaftarMenu_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new DaftarMenu());
        }
    }
}
