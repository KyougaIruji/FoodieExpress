using System;
using System.Windows.Forms;

namespace QuickBitePOS.UI
{
    /// <summary>
    /// Berpindah antar form dan menampilkan kembali form sebelumnya saat form tujuan ditutup.
    /// </summary>
    internal static class Navigator
    {
        internal static void Buka(Form dari, Form tujuan)
        {
            tujuan.FormClosed += delegate(object sender, FormClosedEventArgs e)
            {
                dari.Show();
            };
            dari.Hide();
            tujuan.Show();
        }
    }
}
