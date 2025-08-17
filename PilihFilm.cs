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
    public partial class PilihFilm : Form
    {
        Koneksi con = new Koneksi();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        public static string id, nama_film, genre, durasi, harga_tiket;
    
        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            CariData(txtcari.Text);
        }

        public string getId()
        {
            return id;
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

        

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        public PilihFilm()
        {
            InitializeComponent();
        }

        private void PilihFilm_Load(object sender, EventArgs e)
        {
            CariData("");
            //TampilData();
           
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
        //void TampilData()
        //{
        //    try
        //    {
        //        Koneksi.conn.Open();
        //        MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT * FROM products", Koneksi.conn);
        //        DataTable data = new DataTable();
        //        Tampil.SelectCommand.ExecuteNonQuery();
        //        Tampil.Fill(data);
        //        dg_film.DataSource = data;
        //        Koneksi.conn.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Koneksi Gagal \n Error" + ex.Message,
        //       "Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }


        //}
    }
}
