using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace QuickBitePOS.Database
{
    public class KoneksiDB
    {
        // Mengarah langsung ke direktori Database di dalam folder output
        private static string dbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Database", "DbPemesananMakanan.db");
        private static string connectionString = "Data Source=" + dbPath + ";Version=3;";

        // membuka jalur koneksi dari project C# ke file database 
        public static SQLiteConnection GetConnection()
        {
            // Mencegah SQLite membuat file .db kosong baru jika file asli belum tersalin
            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException("File database tidak ditemukan pada lokasi:\n" + dbPath);
            }

            SQLiteConnection conn = new SQLiteConnection(connectionString);
            conn.Open();
            using (SQLiteCommand cmd = new SQLiteCommand("PRAGMA foreign_keys = ON;", conn))
            {
                cmd.ExecuteNonQuery();
            }
            return conn;
        }

        // untuk menampilkan data dari database ke layar dan digunakan ketika aplikasi menginginkannya
        public static DataTable AmbilData(string query, SQLiteParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SQLiteConnection conn = GetConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    using (SQLiteDataAdapter da = new SQLiteDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }
        
        // digunakan setiap kali aplikasi ingin mengubah / memanipulasi isi database tanpa perlu mengambil tabel hasil
        public static int EksekusiQuery(string query, SQLiteParameter[] parameters = null)
        {
            using (SQLiteConnection conn = GetConnection())
            {
                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}