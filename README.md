# Foodie Express — Aplikasi Pemesanan & Pengantaran Makanan Berbasis Desktop

![C#](https://img.shields.io/badge/Language-C%23-239120?style=flat-square&logo=c-sharp&logoColor=white)
![.NET Framework](https://img.shields.io/badge/.NET%20Framework-WinForms-512BD4?style=flat-square&logo=.net&logoColor=white)
![SQLite](https://img.shields.io/badge/Database-SQLite-003B57?style=flat-square&logo=sqlite&logoColor=white)
![IDE](https://img.shields.io/badge/IDE-JetBrains%20Rider%20%7C%20Visual%20Studio-000000?style=flat-square&logo=rider&logoColor=white)

---

## 👥 Anggota Kelompok

| 1 | **Irji' Mahyadinu** | `25.11.6429` |
| 2 | **Muhammad Reyhan Puham** | `25.11.6434` |
| 3 | **Desca Pratiwi** | `25.11.6430` |
| 3 | **Nurul Azmi Kinanggi** | `25.11.6425` |

---

## 📂 Struktur Direktori Proyek

```text
QuickBitePOS/
└── QuickBitePOS/
    ├── Database/
    │   ├── connectDB.cs               # Class pusat koneksi & eksekusi query SQLite
    │   └── DbPemesananMakanan.db      # File database SQLite
    ├── Forms/
    │   ├── Beranda.cs         # layar utama yang menampilkan promo dan menu rang di rekomendasikan
    │   ├── DaftarMenu.cs           # layar yang berisi daftar semu secara keseluruhan
    │   ├── Kategori.cs            # layar yang berisi kategori tiap makanan/minuman agar lebih gampang mencari apa yang diinginkan user
    │   └── Keranjang.cs      # layar pengelolaan keranjang belanja
    ├── UI/
    │   ├── Navigator.cs         # Class untuk menghubungkan windows form satu ke form yang lain
    └── Program.cs                     # Entry point aplikasi
