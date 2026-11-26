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
    public partial class Keranjang : Form
    {
        public Keranjang()
        {
            InitializeComponent();
            MuatDataKeranjang();
            HitungSemuaBarisDanTotal();
        }

        private void MuatDataKeranjang()
        {
            dataGridView1.Rows.Clear();

            if (dataGridView1.Columns.Count > 0)
            {
                dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView1.Columns[0].Width = 55;
            }

            if (dataGridView1.Columns.Count > 3 &&
                dataGridView1.Columns[3] is DataGridViewComboBoxColumn colJumlah)
            {
                colJumlah.Items.Clear();
                colJumlah.Items.AddRange("1", "2", "3", "4", "5", "6", "7", "8", "9", "10");
            }

            if (dataGridView1.Columns.Count >= 6)
            {
                dataGridView1.Rows.Add("1", "Sate Madura", "Rp33.000", "1", "Rp33.000", "Hapus");
                dataGridView1.Rows.Add("2", "Pisang Nugget", "Rp20.000", "2", "Rp40.000", "Hapus");
            }
        }

        private void HitungSemuaBarisDanTotal()
        {
            int total = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue;

                string teksHarga = row.Cells[2].Value?.ToString() ?? "0";
                string teksJumlah = row.Cells[3].Value?.ToString() ?? "1";

                int harga = int.Parse(teksHarga.Replace("Rp", "").Replace(".", "").Trim());
                int jumlah = int.Parse(teksJumlah.Trim());

                int subtotal = harga * jumlah;
                row.Cells[4].Value = "Rp" + subtotal.ToString("N0").Replace(",", ".");

                total += subtotal;
            }

            lblTotalHarga.Text = "Total Harga: Rp." + total.ToString("N0").Replace(",", ".");
        }

        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 3)
            {
                HitungSemuaBarisDanTotal();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 5 && !dataGridView1.Rows[e.RowIndex].IsNewRow)
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                NomorUlangBaris();
                HitungSemuaBarisDanTotal();
            }
        }

        private void NomorUlangBaris()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (!dataGridView1.Rows[i].IsNewRow)
                {
                    dataGridView1.Rows[i].Cells[0].Value = (i + 1).ToString();
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang masih kosong.", "Checkout",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show($"Pesanan diproses!\n{lblTotalHarga.Text}", "Checkout Berhasil",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Keranjang_Load(object sender, EventArgs e)
        {

        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new frmBeranda());
        }

        private void btnDaftarMenu_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new DaftarMenu());
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Navigator.Buka(this, new Kategori());
        }
    }
}