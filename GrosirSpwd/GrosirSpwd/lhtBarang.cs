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
    public partial class lhtBarang : UserControl
    {
        string MySqlConnectionString = "server=localhost;username=root;pasword=;database=testing";
        
        public lhtBarang()
        {
            InitializeComponent();
        }

        private void lhtBarang_Load(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection con = new MySqlConnection(MySqlConnectionString))
                {
                    con.Open();

                    string query = "SELECT * FROM databarang";
                    MySqlCommand command = new MySqlCommand(query, con);
                    MySqlDataAdapter adapter = new MySqlDataAdapter();
                    adapter.SelectCommand = command;
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadData()
        {
            using (MySqlConnection con = new MySqlConnection(MySqlConnectionString))
            {
                con.Open();
                dataGridView1.DataSource = null;
                string query = "SELECT * FROM databarang";
                MySqlCommand command = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                adapter.SelectCommand = command;
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }

        }

        private void tambahBtn_Click(object sender, EventArgs e)
        {
            if (tb1.Text == "")
            {
                MessageBox.Show("Ada Data yang belum diisi, \n Silahkan Periksa Kembali", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb2.Text == "")
            {
                MessageBox.Show("Ada Data yang belum diisi, \n Silahkan Periksa Kembali", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb3.Text == "")
            {
                MessageBox.Show("Ada Data yang belum diisi, \n Silahkan Periksa Kembali", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb4.Text == "")
            {
                MessageBox.Show("Ada Data yang belum diisi, \n Silahkan Periksa Kembali", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb5.Text == "")
            {
                MessageBox.Show("Ada Data yang belum diisi, \n Silahkan Periksa Kembali", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (tb6.Text == "")
            {
                MessageBox.Show("Ada Data yang belum diisi, \n Silahkan Periksa Kembali", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (MySqlConnection con = new MySqlConnection(MySqlConnectionString))
                    {
                        con.Open();
                        string query1 = "INSERT INTO databarang (kdBrg, nmBrg, spl, tglMsk, hrgMsk, hrgJual, Stok) VALUES ('" + tb1.Text + "', '" + tb2.Text + "', '" + tb3.Text + "', '" + timePick.Value.ToString("dd-MM-yyyy") + "', '" + tb4.Text + "', '" + tb6.Text + "', '" + tb5.Text + "' )";
                        MySqlCommand command1 = new MySqlCommand(query1, con);
                        MySqlDataReader reader = command1.ExecuteReader();
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //MessageBox.Show("Berhasil Tambah Data", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
                tb1.Clear();
                tb2.Clear();
                tb3.Clear();
                tb4.Clear();
                tb5.Clear();
                tb6.Clear();
                timePick.ResetText();
            }
        }

        private void cariBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(MySqlConnectionString))
            {
                if (string.IsNullOrEmpty(tb7.Text))
                {
                    loadData();
                }
                else
                {
                    con.Open();
                    MySqlCommand command1 = con.CreateCommand();
                    command1.CommandType = CommandType.Text;
                    command1.CommandText = ("SELECT * FROM databarang WHERE kdBrg = '" + tb7.Text + "' OR nmBrg = '" + tb7.Text + "' OR spl = '" + tb7.Text + "' OR tglMsk = '" + tb7.Text + "' OR hrgMsk = '" + tb7.Text + "' OR hrgJual = '" + tb7.Text + "' OR Stok = '" + tb7.Text + "'");
                    command1.ExecuteNonQuery();
                    DataTable dataTable1 = new DataTable();
                    MySqlDataAdapter adapter1 = new MySqlDataAdapter(command1);
                    adapter1.Fill(dataTable1);
                    dataGridView1.DataSource = dataTable1;
                    con.Close();
                }
            }
        }

        private void batalBtn_Click(object sender, EventArgs e)
        {
            tb1.Clear();
            tb2.Clear();
            tb3.Clear();
            tb4.Clear();
            tb5.Clear();
            tb6.Clear();
            timePick.ResetText();
        }

        private void hapusBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(MySqlConnectionString))
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    con.Open();
                    int selectedIndex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedIndex];
                    string nomor = Convert.ToString(selectedRow.Cells["No"].Value);
                    string querydel = "DELETE FROM databarang WHERE No = " + nomor;
                    MySqlCommand commandDel = new MySqlCommand(querydel, con);
                    commandDel.ExecuteNonQuery();
                    MessageBox.Show("Data Sudah Terhapus :D");
                    loadData();
                }
                else
                {
                    MessageBox.Show("Pilih Data Dulu");
                }
            }
        }
    }
}
