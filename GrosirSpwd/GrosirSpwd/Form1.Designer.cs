namespace GrosirSpwd
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.keluar = new System.Windows.Forms.Button();
            this.pengaturan = new System.Windows.Forms.Button();
            this.riwayatTransaksi = new System.Windows.Forms.Button();
            this.transaksi = new System.Windows.Forms.Button();
            this.dataBarang = new System.Windows.Forms.Button();
            this.toko = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.waktu = new System.Windows.Forms.Label();
            this.tanggal = new System.Windows.Forms.Label();
            this.labelWaktu = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.btnSembunyi = new System.Windows.Forms.Button();
            this.btnKeluar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.transaksi1 = new GrosirSpwd.transaksi();
            this.lhtBarang1 = new GrosirSpwd.lhtBarang();
            this.dashboard1 = new GrosirSpwd.dashboard();
            this.tbhBarang1 = new GrosirSpwd.tbhBarang();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.keluar);
            this.panel1.Controls.Add(this.pengaturan);
            this.panel1.Controls.Add(this.riwayatTransaksi);
            this.panel1.Controls.Add(this.transaksi);
            this.panel1.Controls.Add(this.dataBarang);
            this.panel1.Controls.Add(this.toko);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 773);
            this.panel1.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 31);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(11, 85);
            this.SidePanel.TabIndex = 2;
            // 
            // keluar
            // 
            this.keluar.FlatAppearance.BorderSize = 0;
            this.keluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keluar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluar.ForeColor = System.Drawing.Color.White;
            this.keluar.Image = ((System.Drawing.Image)(resources.GetObject("keluar.Image")));
            this.keluar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.keluar.Location = new System.Drawing.Point(12, 682);
            this.keluar.Name = "keluar";
            this.keluar.Size = new System.Drawing.Size(172, 85);
            this.keluar.TabIndex = 9;
            this.keluar.Text = "      Keluar";
            this.keluar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.keluar.UseVisualStyleBackColor = true;
            this.keluar.Click += new System.EventHandler(this.keluar_Click);
            // 
            // pengaturan
            // 
            this.pengaturan.FlatAppearance.BorderSize = 0;
            this.pengaturan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pengaturan.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengaturan.ForeColor = System.Drawing.Color.White;
            this.pengaturan.Image = ((System.Drawing.Image)(resources.GetObject("pengaturan.Image")));
            this.pengaturan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pengaturan.Location = new System.Drawing.Point(12, 404);
            this.pengaturan.Name = "pengaturan";
            this.pengaturan.Size = new System.Drawing.Size(172, 85);
            this.pengaturan.TabIndex = 8;
            this.pengaturan.Text = "      Pengaturan";
            this.pengaturan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.pengaturan.UseVisualStyleBackColor = true;
            this.pengaturan.Click += new System.EventHandler(this.pengaturan_Click);
            // 
            // riwayatTransaksi
            // 
            this.riwayatTransaksi.FlatAppearance.BorderSize = 0;
            this.riwayatTransaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.riwayatTransaksi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riwayatTransaksi.ForeColor = System.Drawing.Color.White;
            this.riwayatTransaksi.Image = ((System.Drawing.Image)(resources.GetObject("riwayatTransaksi.Image")));
            this.riwayatTransaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.riwayatTransaksi.Location = new System.Drawing.Point(12, 313);
            this.riwayatTransaksi.Name = "riwayatTransaksi";
            this.riwayatTransaksi.Size = new System.Drawing.Size(172, 85);
            this.riwayatTransaksi.TabIndex = 7;
            this.riwayatTransaksi.Text = "      Riwayat         Transaksi";
            this.riwayatTransaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.riwayatTransaksi.UseVisualStyleBackColor = true;
            this.riwayatTransaksi.Click += new System.EventHandler(this.riwayatTransaksi_Click);
            // 
            // transaksi
            // 
            this.transaksi.FlatAppearance.BorderSize = 0;
            this.transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.transaksi.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transaksi.ForeColor = System.Drawing.Color.White;
            this.transaksi.Image = ((System.Drawing.Image)(resources.GetObject("transaksi.Image")));
            this.transaksi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.transaksi.Location = new System.Drawing.Point(12, 222);
            this.transaksi.Name = "transaksi";
            this.transaksi.Size = new System.Drawing.Size(172, 85);
            this.transaksi.TabIndex = 6;
            this.transaksi.Text = "      Transaksi";
            this.transaksi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.transaksi.UseVisualStyleBackColor = true;
            this.transaksi.Click += new System.EventHandler(this.transaksi_Click);
            // 
            // dataBarang
            // 
            this.dataBarang.FlatAppearance.BorderSize = 0;
            this.dataBarang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dataBarang.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBarang.ForeColor = System.Drawing.Color.White;
            this.dataBarang.Image = ((System.Drawing.Image)(resources.GetObject("dataBarang.Image")));
            this.dataBarang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBarang.Location = new System.Drawing.Point(12, 131);
            this.dataBarang.Name = "dataBarang";
            this.dataBarang.Size = new System.Drawing.Size(172, 85);
            this.dataBarang.TabIndex = 5;
            this.dataBarang.Text = "      Data Barang";
            this.dataBarang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.dataBarang.UseVisualStyleBackColor = true;
            this.dataBarang.Click += new System.EventHandler(this.lihatBarang_Click);
            // 
            // toko
            // 
            this.toko.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.toko.FlatAppearance.BorderSize = 0;
            this.toko.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toko.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toko.ForeColor = System.Drawing.Color.White;
            this.toko.Image = ((System.Drawing.Image)(resources.GetObject("toko.Image")));
            this.toko.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toko.Location = new System.Drawing.Point(12, 31);
            this.toko.Name = "toko";
            this.toko.Size = new System.Drawing.Size(172, 85);
            this.toko.TabIndex = 3;
            this.toko.Text = "      Toko Grosir";
            this.toko.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toko.UseVisualStyleBackColor = true;
            this.toko.Click += new System.EventHandler(this.toko_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Controls.Add(this.waktu);
            this.panel2.Controls.Add(this.tanggal);
            this.panel2.Controls.Add(this.labelWaktu);
            this.panel2.Controls.Add(this.labelTanggal);
            this.panel2.Controls.Add(this.btnSembunyi);
            this.panel2.Controls.Add(this.btnKeluar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(184, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1111, 25);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // waktu
            // 
            this.waktu.AutoSize = true;
            this.waktu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.waktu.Location = new System.Drawing.Point(415, 2);
            this.waktu.Name = "waktu";
            this.waktu.Size = new System.Drawing.Size(50, 19);
            this.waktu.TabIndex = 5;
            this.waktu.Text = "waktu";
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tanggal.Location = new System.Drawing.Point(84, 2);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(57, 19);
            this.tanggal.TabIndex = 3;
            this.tanggal.Text = "tanggal";
            // 
            // labelWaktu
            // 
            this.labelWaktu.AutoSize = true;
            this.labelWaktu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWaktu.Location = new System.Drawing.Point(346, 2);
            this.labelWaktu.Name = "labelWaktu";
            this.labelWaktu.Size = new System.Drawing.Size(63, 19);
            this.labelWaktu.TabIndex = 4;
            this.labelWaktu.Text = "Waktu :";
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTanggal.Location = new System.Drawing.Point(6, 2);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(72, 19);
            this.labelTanggal.TabIndex = 3;
            this.labelTanggal.Text = "Tanggal :";
            // 
            // btnSembunyi
            // 
            this.btnSembunyi.FlatAppearance.BorderSize = 0;
            this.btnSembunyi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSembunyi.Image = ((System.Drawing.Image)(resources.GetObject("btnSembunyi.Image")));
            this.btnSembunyi.Location = new System.Drawing.Point(1032, 2);
            this.btnSembunyi.Name = "btnSembunyi";
            this.btnSembunyi.Size = new System.Drawing.Size(34, 20);
            this.btnSembunyi.TabIndex = 3;
            this.btnSembunyi.UseVisualStyleBackColor = true;
            this.btnSembunyi.Click += new System.EventHandler(this.btnSembunyi_Click);
            // 
            // btnKeluar
            // 
            this.btnKeluar.FlatAppearance.BorderSize = 0;
            this.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKeluar.Image = ((System.Drawing.Image)(resources.GetObject("btnKeluar.Image")));
            this.btnKeluar.Location = new System.Drawing.Point(1072, 2);
            this.btnKeluar.Name = "btnKeluar";
            this.btnKeluar.Size = new System.Drawing.Size(34, 20);
            this.btnKeluar.TabIndex = 2;
            this.btnKeluar.UseVisualStyleBackColor = true;
            this.btnKeluar.Click += new System.EventHandler(this.btnKeluar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // transaksi1
            // 
            this.transaksi1.Location = new System.Drawing.Point(184, 25);
            this.transaksi1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.transaksi1.Name = "transaksi1";
            this.transaksi1.Size = new System.Drawing.Size(1111, 742);
            this.transaksi1.TabIndex = 6;
            // 
            // lhtBarang1
            // 
            this.lhtBarang1.Location = new System.Drawing.Point(184, 25);
            this.lhtBarang1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lhtBarang1.Name = "lhtBarang1";
            this.lhtBarang1.Size = new System.Drawing.Size(1111, 742);
            this.lhtBarang1.TabIndex = 5;
            // 
            // dashboard1
            // 
            this.dashboard1.Location = new System.Drawing.Point(184, 25);
            this.dashboard1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dashboard1.Name = "dashboard1";
            this.dashboard1.Size = new System.Drawing.Size(1111, 742);
            this.dashboard1.TabIndex = 4;
            // 
            // tbhBarang1
            // 
            this.tbhBarang1.Location = new System.Drawing.Point(184, 25);
            this.tbhBarang1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbhBarang1.Name = "tbhBarang1";
            this.tbhBarang1.Size = new System.Drawing.Size(1111, 742);
            this.tbhBarang1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1295, 773);
            this.Controls.Add(this.transaksi1);
            this.Controls.Add(this.lhtBarang1);
            this.Controls.Add(this.dashboard1);
            this.Controls.Add(this.tbhBarang1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Imprint MT Shadow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button toko;
        private System.Windows.Forms.Button riwayatTransaksi;
        private System.Windows.Forms.Button transaksi;
        private System.Windows.Forms.Button dataBarang;
        private System.Windows.Forms.Button pengaturan;
        private System.Windows.Forms.Button keluar;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnSembunyi;
        private System.Windows.Forms.Button btnKeluar;
        private System.Windows.Forms.Label waktu;
        private System.Windows.Forms.Label tanggal;
        private System.Windows.Forms.Label labelWaktu;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.Timer timer1;
        private tbhBarang tbhBarang1;
        private dashboard dashboard1;
        private lhtBarang lhtBarang1;
        private transaksi transaksi1;
    }
}

