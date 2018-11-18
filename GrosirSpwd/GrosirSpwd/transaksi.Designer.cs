namespace GrosirSpwd
{
    partial class transaksi
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTransaksi = new System.Windows.Forms.Label();
            this.labelKodeBarang = new System.Windows.Forms.Label();
            this.labelPembeli = new System.Windows.Forms.Label();
            this.tNama = new System.Windows.Forms.TextBox();
            this.tKode = new System.Windows.Forms.TextBox();
            this.tBarang = new System.Windows.Forms.TextBox();
            this.labelNamaBarang = new System.Windows.Forms.Label();
            this.tJumlah = new System.Windows.Forms.TextBox();
            this.labelJumlah = new System.Windows.Forms.Label();
            this.tSatuan = new System.Windows.Forms.TextBox();
            this.labelHargaSatuan = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tBayar = new System.Windows.Forms.TextBox();
            this.labelBayar = new System.Windows.Forms.Label();
            this.tKembali = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnFinish = new System.Windows.Forms.Button();
            this.tTotal = new System.Windows.Forms.TextBox();
            this.tTotalSatuan = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTransaksi
            // 
            this.labelTransaksi.AutoSize = true;
            this.labelTransaksi.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTransaksi.Location = new System.Drawing.Point(3, 0);
            this.labelTransaksi.Name = "labelTransaksi";
            this.labelTransaksi.Size = new System.Drawing.Size(310, 77);
            this.labelTransaksi.TabIndex = 0;
            this.labelTransaksi.Text = "Transaksi";
            // 
            // labelKodeBarang
            // 
            this.labelKodeBarang.AutoSize = true;
            this.labelKodeBarang.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKodeBarang.Location = new System.Drawing.Point(170, 72);
            this.labelKodeBarang.Name = "labelKodeBarang";
            this.labelKodeBarang.Size = new System.Drawing.Size(131, 22);
            this.labelKodeBarang.TabIndex = 1;
            this.labelKodeBarang.Text = "Kode Barang";
            // 
            // labelPembeli
            // 
            this.labelPembeli.AutoSize = true;
            this.labelPembeli.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPembeli.Location = new System.Drawing.Point(12, 72);
            this.labelPembeli.Name = "labelPembeli";
            this.labelPembeli.Size = new System.Drawing.Size(143, 22);
            this.labelPembeli.TabIndex = 2;
            this.labelPembeli.Text = "Nama Pembeli";
            // 
            // tNama
            // 
            this.tNama.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNama.Location = new System.Drawing.Point(16, 92);
            this.tNama.Name = "tNama";
            this.tNama.Size = new System.Drawing.Size(148, 31);
            this.tNama.TabIndex = 3;
            // 
            // tKode
            // 
            this.tKode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tKode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tKode.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKode.Location = new System.Drawing.Point(174, 92);
            this.tKode.Name = "tKode";
            this.tKode.Size = new System.Drawing.Size(148, 31);
            this.tKode.TabIndex = 4;
            this.tKode.TextChanged += new System.EventHandler(this.tKode_TextChanged);
            // 
            // tBarang
            // 
            this.tBarang.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBarang.Location = new System.Drawing.Point(332, 92);
            this.tBarang.Name = "tBarang";
            this.tBarang.Size = new System.Drawing.Size(148, 31);
            this.tBarang.TabIndex = 6;
            // 
            // labelNamaBarang
            // 
            this.labelNamaBarang.AutoSize = true;
            this.labelNamaBarang.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaBarang.Location = new System.Drawing.Point(328, 72);
            this.labelNamaBarang.Name = "labelNamaBarang";
            this.labelNamaBarang.Size = new System.Drawing.Size(140, 22);
            this.labelNamaBarang.TabIndex = 5;
            this.labelNamaBarang.Text = "Nama Barang";
            // 
            // tJumlah
            // 
            this.tJumlah.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tJumlah.Location = new System.Drawing.Point(16, 133);
            this.tJumlah.Name = "tJumlah";
            this.tJumlah.Size = new System.Drawing.Size(148, 31);
            this.tJumlah.TabIndex = 8;
            this.tJumlah.TextChanged += new System.EventHandler(this.tJumlah_TextChanged);
            // 
            // labelJumlah
            // 
            this.labelJumlah.AutoSize = true;
            this.labelJumlah.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJumlah.Location = new System.Drawing.Point(12, 113);
            this.labelJumlah.Name = "labelJumlah";
            this.labelJumlah.Size = new System.Drawing.Size(76, 22);
            this.labelJumlah.TabIndex = 7;
            this.labelJumlah.Text = "Jumlah";
            // 
            // tSatuan
            // 
            this.tSatuan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSatuan.Location = new System.Drawing.Point(490, 92);
            this.tSatuan.Name = "tSatuan";
            this.tSatuan.Size = new System.Drawing.Size(148, 31);
            this.tSatuan.TabIndex = 10;
            // 
            // labelHargaSatuan
            // 
            this.labelHargaSatuan.AutoSize = true;
            this.labelHargaSatuan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaSatuan.Location = new System.Drawing.Point(486, 72);
            this.labelHargaSatuan.Name = "labelHargaSatuan";
            this.labelHargaSatuan.Size = new System.Drawing.Size(139, 22);
            this.labelHargaSatuan.TabIndex = 9;
            this.labelHargaSatuan.Text = "Harga Satuan";
            // 
            // btnBatal
            // 
            this.btnBatal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBatal.Location = new System.Drawing.Point(332, 136);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(148, 23);
            this.btnBatal.TabIndex = 11;
            this.btnBatal.Text = "BATAL";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTambah.FlatAppearance.BorderSize = 0;
            this.btnTambah.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTambah.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Location = new System.Drawing.Point(490, 136);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(148, 23);
            this.btnTambah.TabIndex = 12;
            this.btnTambah.Text = "TAMBAH";
            this.btnTambah.UseVisualStyleBackColor = false;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 234);
            this.dataGridView1.TabIndex = 13;
            // 
            // tBayar
            // 
            this.tBayar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBayar.Location = new System.Drawing.Point(16, 427);
            this.tBayar.Name = "tBayar";
            this.tBayar.Size = new System.Drawing.Size(148, 31);
            this.tBayar.TabIndex = 15;
            this.tBayar.TextChanged += new System.EventHandler(this.tBayar_TextChanged);
            // 
            // labelBayar
            // 
            this.labelBayar.AutoSize = true;
            this.labelBayar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBayar.Location = new System.Drawing.Point(12, 407);
            this.labelBayar.Name = "labelBayar";
            this.labelBayar.Size = new System.Drawing.Size(64, 22);
            this.labelBayar.TabIndex = 14;
            this.labelBayar.Text = "Bayar";
            // 
            // tKembali
            // 
            this.tKembali.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tKembali.Location = new System.Drawing.Point(174, 427);
            this.tKembali.Name = "tKembali";
            this.tKembali.Size = new System.Drawing.Size(148, 31);
            this.tKembali.TabIndex = 17;
            this.tKembali.TextChanged += new System.EventHandler(this.tKembali_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 16;
            this.label1.Text = "Kembali";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(16, 454);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 3);
            this.panel1.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 44);
            this.label2.TabIndex = 20;
            this.label2.Text = "Total : ";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(332, 480);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(148, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "BATAL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFinish.FlatAppearance.BorderSize = 0;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(490, 480);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(148, 23);
            this.btnFinish.TabIndex = 23;
            this.btnFinish.Text = "TAMBAH";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // tTotal
            // 
            this.tTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTotal.Location = new System.Drawing.Point(90, 480);
            this.tTotal.Name = "tTotal";
            this.tTotal.ReadOnly = true;
            this.tTotal.Size = new System.Drawing.Size(232, 31);
            this.tTotal.TabIndex = 24;
            // 
            // tTotalSatuan
            // 
            this.tTotalSatuan.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tTotalSatuan.Location = new System.Drawing.Point(174, 133);
            this.tTotalSatuan.Name = "tTotalSatuan";
            this.tTotalSatuan.Size = new System.Drawing.Size(148, 31);
            this.tTotalSatuan.TabIndex = 26;
            this.tTotalSatuan.TextChanged += new System.EventHandler(this.tTotalSatuan_TextChanged);
            // 
            // Total
            // 
            this.Total.AutoSize = true;
            this.Total.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.Location = new System.Drawing.Point(170, 113);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(76, 22);
            this.Total.TabIndex = 25;
            this.Total.Text = "Jumlah";
            // 
            // transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tTotalSatuan);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.tTotal);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tKembali);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBayar);
            this.Controls.Add(this.labelBayar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.tSatuan);
            this.Controls.Add(this.labelHargaSatuan);
            this.Controls.Add(this.tJumlah);
            this.Controls.Add(this.labelJumlah);
            this.Controls.Add(this.tBarang);
            this.Controls.Add(this.labelNamaBarang);
            this.Controls.Add(this.tKode);
            this.Controls.Add(this.tNama);
            this.Controls.Add(this.labelPembeli);
            this.Controls.Add(this.labelKodeBarang);
            this.Controls.Add(this.labelTransaksi);
            this.Name = "transaksi";
            this.Size = new System.Drawing.Size(1111, 742);
            this.Load += new System.EventHandler(this.transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTransaksi;
        private System.Windows.Forms.Label labelKodeBarang;
        private System.Windows.Forms.Label labelPembeli;
        private System.Windows.Forms.TextBox tNama;
        private System.Windows.Forms.TextBox tKode;
        private System.Windows.Forms.TextBox tBarang;
        private System.Windows.Forms.Label labelNamaBarang;
        private System.Windows.Forms.TextBox tJumlah;
        private System.Windows.Forms.Label labelJumlah;
        private System.Windows.Forms.TextBox tSatuan;
        private System.Windows.Forms.Label labelHargaSatuan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tBayar;
        private System.Windows.Forms.Label labelBayar;
        private System.Windows.Forms.TextBox tKembali;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnFinish;
        private System.Windows.Forms.TextBox tTotal;
        private System.Windows.Forms.TextBox tTotalSatuan;
        private System.Windows.Forms.Label Total;
    }
}
