using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GrosirSpwd
{
    public partial class transaksi : UserControl
    {
        string MySqlConnectionString = "server=localhost;username=root;pasword=;database=testing";

        public transaksi()
        {
            InitializeComponent();
        }

        DataTable table = new DataTable();

        private void transaksi_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Nama Pembeli", typeof(string));
            table.Columns.Add("Kode Barang", typeof(string));
            table.Columns.Add("Nama Barang", typeof(string));
            table.Columns.Add("Tanggal", typeof(string));
            table.Columns.Add("Harga Satuan", typeof(float));
            table.Columns.Add("Jumlah", typeof(float));
            table.Columns.Add("Total", typeof(float));

            dataGridView1.DataSource = table;

            using (MySqlConnection con = new MySqlConnection(MySqlConnectionString))
            {
                con.Open();
                string query = "SELECT kdBrg FROM databarang";
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataReader reader1 = command.ExecuteReader();

                AutoCompleteStringCollection kodeBarang = new AutoCompleteStringCollection();

                while (reader1.Read())
                {
                    kodeBarang.Add(reader1.GetString(0));
                }

                tKode.AutoCompleteCustomSource = kodeBarang;
                con.Close();
            }
        }

        

        private void btnTambah_Click(object sender, EventArgs e)
        {
            float total = float.Parse(tJumlah.Text) * float.Parse(tSatuan.Text);

            table.Rows.Add(tNama.Text, tKode.Text, tBarang.Text, DateTime.Now.ToString("dd-MM-yyyy"), tSatuan.Text, tJumlah.Text, total);
            dataGridView1.DataSource = table;


            int[] jumlahData = (from DataGridViewRow row in dataGridView1.Rows
                                where row.Cells[6].FormattedValue.ToString() != string.Empty
                                select Convert.ToInt32(row.Cells[6].FormattedValue)).ToArray();

            tTotal.Text = jumlahData.Sum().ToString();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(MySqlConnectionString))
            {
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    con.Open();
                    string query1 = "INSERT INTO transaksi (Nama_Pembeli, Kode_Barang, Nama_Barang, Tanggal_Transaksi, Harga_Satuan, Jumlah, Harga_Total) VALUES ('" + dataGridView1.Rows[i].Cells[0].Value + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[2].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "','" + dataGridView1.Rows[i].Cells[4].Value + "','" + dataGridView1.Rows[i].Cells[5].Value + "','" + dataGridView1.Rows[i].Cells[6].Value + "')";
                    MySqlCommand command1 = new MySqlCommand(query1, con);
                    MySqlDataReader reader1 = command1.ExecuteReader();
                    con.Close();
                }
            }
            dataGridView1.DataSource = null;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            tNama.Text = null;
            tKode.Text = null;
            tBarang.Text = null;
            tJumlah.Text = null;
            tSatuan.Text = null;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }

        private void tKode_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(MySqlConnectionString))
            {
                con.Open();
                string query2 = "SELECT * FROM databarang WHERE kdBrg = '"+ tKode.Text +"'";
                MySqlCommand command2 = new MySqlCommand(query2, con);
                MySqlDataReader reader2 = command2.ExecuteReader();
                
                while (reader2.Read())
                {
                    tBarang.Text = reader2.GetString("nmBrg");
                    tSatuan.Text = reader2.GetString("hrgJual");
                }
                
                con.Close();
            }
        }

        private void tTotalSatuan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tJumlah_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tTotalSatuan.Text = (float.Parse(tSatuan.Text) * float.Parse(tJumlah.Text)).ToString();
            }
            catch
            {

            }
        }

        private void tKembali_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBayar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tKembali.Text = (float.Parse(tBayar.Text) - float.Parse(tTotal.Text)).ToString();
            }
            catch
            {

            }
        }
    }
}
