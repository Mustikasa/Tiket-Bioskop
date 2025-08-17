using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;
namespace TiketBioskop
{
   
    public partial class Pilih_Film : Form
    {
        Koneksi con = new Koneksi();

        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        public static string id, nama_film, genre, durasi, harga_tiket;

        public Pilih_Film()
        {
            InitializeComponent();
        }

        private void Sidebar_Load(object sender, EventArgs e)
        {
            CariData("");
        }

        void CariData(string cari)
        {
            Koneksi.conn.Open();
            if (txtcari.TextLength == 0)
            {
                cmd = new MySqlCommand("SELECT * FROM products", Koneksi.conn);
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM products where id like '%" + cari + "%' or nama_film like '%" + cari + "%'", Koneksi.conn);
            }
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            Koneksi.conn.Close();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow kp = dataGridView1.SelectedRows[0];


            id = kp.Cells[0].Value.ToString();
            nama_film = kp.Cells[1].Value.ToString();
            genre = kp.Cells[2].Value.ToString();
            durasi = kp.Cells[3].Value.ToString();
            harga_tiket = kp.Cells[4].Value.ToString();

            if (MessageBox.Show("Anda yakin ingin memilih film : "+ nama_film +" ?", "Konfirmasi",
    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                this.Hide();
            }
        }

        public string getId()
        {
            return id;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            CariData(txtcari.Text);
        }

        public string getNf()
        {
            return nama_film;
        }
        public string getGenre()
        {
            return genre;
        }
        public string getDurasi()
        {
            return durasi;
        }
        public string getHarga()
        {
            return harga_tiket;
        }
    }
}
