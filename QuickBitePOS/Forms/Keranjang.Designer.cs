namespace QuickBitePOS
{
    partial class Keranjang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblKeranjangBelanja = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalHarga = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnDaftarMenu = new System.Windows.Forms.Button();
            this.btnKeranjang = new System.Windows.Forms.Button();
            this.btnBeranda = new System.Windows.Forms.Button();
            this.lblFoodie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblKeranjangBelanja
            // 
            this.lblKeranjangBelanja.AutoSize = true;
            this.lblKeranjangBelanja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeranjangBelanja.Location = new System.Drawing.Point(229, 38);
            this.lblKeranjangBelanja.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKeranjangBelanja.Name = "lblKeranjangBelanja";
            this.lblKeranjangBelanja.Size = new System.Drawing.Size(143, 18);
            this.lblKeranjangBelanja.TabIndex = 2;
            this.lblKeranjangBelanja.Text = "Keranjang Belanja";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.colNo, this.Column2, this.Column3, this.Column4, this.Column5, this.Column6 });
            this.dataGridView1.Location = new System.Drawing.Point(232, 68);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(558, 259);
            this.dataGridView1.TabIndex = 3;
            // 
            // colNo
            // 
            this.colNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNo.HeaderText = "No";
            this.colNo.MinimumWidth = 8;
            this.colNo.Name = "colNo";
            this.colNo.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nama Menu";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Jumlah";
            this.Column4.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Subtotal";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column6.HeaderText = "";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 60;
            // 
            // lblTotalHarga
            // 
            this.lblTotalHarga.AutoSize = true;
            this.lblTotalHarga.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.lblTotalHarga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHarga.Location = new System.Drawing.Point(229, 355);
            this.lblTotalHarga.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalHarga.Name = "lblTotalHarga";
            this.lblTotalHarga.Size = new System.Drawing.Size(104, 17);
            this.lblTotalHarga.TabIndex = 4;
            this.lblTotalHarga.Text = "Total Harga: ";
            // 
            // btnCheckout
            // 
            this.btnCheckout.BackColor = System.Drawing.Color.Tomato;
            this.btnCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckout.Location = new System.Drawing.Point(688, 351);
            this.btnCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(102, 24);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnDaftarMenu);
            this.panel1.Controls.Add(this.btnKeranjang);
            this.panel1.Controls.Add(this.btnBeranda);
            this.panel1.Controls.Add(this.lblFoodie);
            this.panel1.Location = new System.Drawing.Point(8, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 373);
            this.panel1.TabIndex = 6;
            // 
            // btnKategori
            // 
            this.btnKategori.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKategori.ForeColor = System.Drawing.Color.Tomato;
            this.btnKategori.Location = new System.Drawing.Point(24, 312);
            this.btnKategori.Margin = new System.Windows.Forms.Padding(2);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(134, 31);
            this.btnKategori.TabIndex = 4;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = false;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnDaftarMenu
            // 
            this.btnDaftarMenu.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnDaftarMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDaftarMenu.ForeColor = System.Drawing.Color.Tomato;
            this.btnDaftarMenu.Location = new System.Drawing.Point(24, 258);
            this.btnDaftarMenu.Margin = new System.Windows.Forms.Padding(2);
            this.btnDaftarMenu.Name = "btnDaftarMenu";
            this.btnDaftarMenu.Size = new System.Drawing.Size(134, 31);
            this.btnDaftarMenu.TabIndex = 3;
            this.btnDaftarMenu.Text = "Daftar Menu";
            this.btnDaftarMenu.UseVisualStyleBackColor = false;
            this.btnDaftarMenu.Click += new System.EventHandler(this.btnDaftarMenu_Click);
            // 
            // btnKeranjang
            // 
            this.btnKeranjang.BackColor = System.Drawing.Color.Khaki;
            this.btnKeranjang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKeranjang.ForeColor = System.Drawing.Color.Tomato;
            this.btnKeranjang.Location = new System.Drawing.Point(24, 201);
            this.btnKeranjang.Margin = new System.Windows.Forms.Padding(2);
            this.btnKeranjang.Name = "btnKeranjang";
            this.btnKeranjang.Size = new System.Drawing.Size(134, 31);
            this.btnKeranjang.TabIndex = 2;
            this.btnKeranjang.Text = "Keranjang";
            this.btnKeranjang.UseVisualStyleBackColor = false;
            // 
            // btnBeranda
            // 
            this.btnBeranda.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBeranda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeranda.ForeColor = System.Drawing.Color.Tomato;
            this.btnBeranda.Location = new System.Drawing.Point(24, 143);
            this.btnBeranda.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeranda.Name = "btnBeranda";
            this.btnBeranda.Size = new System.Drawing.Size(134, 32);
            this.btnBeranda.TabIndex = 1;
            this.btnBeranda.Text = "Beranda";
            this.btnBeranda.UseVisualStyleBackColor = false;
            this.btnBeranda.Click += new System.EventHandler(this.btnBeranda_Click);
            // 
            // lblFoodie
            // 
            this.lblFoodie.AutoSize = true;
            this.lblFoodie.BackColor = System.Drawing.Color.Tomato;
            this.lblFoodie.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFoodie.Location = new System.Drawing.Point(43, 50);
            this.lblFoodie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoodie.Name = "lblFoodie";
            this.lblFoodie.Size = new System.Drawing.Size(98, 52);
            this.lblFoodie.TabIndex = 0;
            this.lblFoodie.Text = "Foodie\r\nExpress";
            // 
            // Keranjang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 402);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.lblTotalHarga);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblKeranjangBelanja);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Keranjang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keranjang";
            this.Load += new System.EventHandler(this.Keranjang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label lblKeranjangBelanja;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotalHarga;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnDaftarMenu;
        private System.Windows.Forms.Button btnKeranjang;
        private System.Windows.Forms.Button btnBeranda;
        private System.Windows.Forms.Label lblFoodie;
    }
}