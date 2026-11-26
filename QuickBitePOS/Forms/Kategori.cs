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
    public partial class Kategori : Form
    {
        public Kategori()
        {
            InitializeComponent();
        }

        private void BukaKategori(string namaKategori)
        {
            MessageBox.Show($"Kategori dipilih: {namaKategori}", "Kategori Menu",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Navigator.Buka(this, new DaftarMenu());
        }

        // Event klik 6 kartu/label/gambar kategori di area kanan
        private void btnMakanan_Click(object sender, EventArgs e) => BukaKategori("Makanan");
        private void btnMinuman_Click(object sender, EventArgs e) => BukaKategori("Minuman");
        private void btnSnack_Click(object sender, EventArgs e) => BukaKategori("Snack");
        private void btnDessert_Click(object sender, EventArgs e) => BukaKategori("Dessert");
        private void btnFastFood_Click(object sender, EventArgs e) => BukaKategori("Fast Food");
        private void btnHealty_Click(object sender, EventArgs e) => BukaKategori("Healthy");

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        // Navigasi sidebar kiri
        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new frmBeranda());
        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new Keranjang());
        }

        private void btnDaftarMenu_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new DaftarMenu());
        }
    }
}