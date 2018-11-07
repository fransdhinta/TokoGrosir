using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GrosirSpwd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //SidePanel.Height = toko.Height;
            //SidePanel.Top = toko.Height;
            dashboard1.BringToFront();
        }

        int mouseX = MousePosition.X, mouseY = MousePosition.Y;
        bool mouseDown;


        private void toko_Click(object sender, EventArgs e)
        {
            SidePanel.Height = toko.Height;
            SidePanel.Top = toko.Top;
            dashboard1.BringToFront();
        }
        
        private void lihatBarang_Click(object sender, EventArgs e)
        {
            SidePanel.Height = dataBarang.Height;
            SidePanel.Top = dataBarang.Top;
            lhtBarang1.BringToFront();
        }

        private void transaksi_Click(object sender, EventArgs e)
        {
            SidePanel.Height = transaksi.Height;
            SidePanel.Top = transaksi.Top;
            transaksi1.BringToFront();
        }

        private void riwayatTransaksi_Click(object sender, EventArgs e)
        {
            SidePanel.Height = riwayatTransaksi.Height;
            SidePanel.Top = riwayatTransaksi.Top;
        }
        
        private void pengaturan_Click(object sender, EventArgs e)
        {
            SidePanel.Height = pengaturan.Height;
            SidePanel.Top = pengaturan.Top;
        }

        private void keluar_Click(object sender, EventArgs e)
        {
            SidePanel.Height = keluar.Height;
            SidePanel.Top = keluar.Top;
            Close();
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSembunyi_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 0;
                mouseY = MousePosition.Y - 0;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            tanggal.Text = DateTime.Now.ToLongDateString();
            waktu.Text = DateTime.Now.ToLongTimeString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            waktu.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }
    }
}
