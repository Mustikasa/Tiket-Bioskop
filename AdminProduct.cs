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
using System.Drawing;
using System.IO;

namespace TiketBioskop
{
    public partial class AdminProduct : Form
    {
        Koneksi conn = new Koneksi();
        string gambar;
        string newName;
        Koneksi con = new Koneksi();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        // untuk update delete
        int id;
        public AdminProduct()
        {
            InitializeComponent();
        }

        private void AdminProduct_Load(object sender, EventArgs e)
        {
            //Show();
            //dg_produk.Columns[5].Visible = false;
            CariData("");
            TampilData();
            //label9.Text = LoginForm.user;
        }

        //new void Show()
        //{
        //    conn.ReadData("SELECT id No, nama_film Judul_Film, genre Genre, durasi Durasi, urlgambar Gambar, harga_tiket Harga FROM products", dg_produk);
        //}
        void TampilData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT * FROM products", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dg_produk.DataSource = data;
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal \n Error" + ex.Message,
               "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ClearTxt()
        {
            txtfilm.Text ="";
            txtgenre.Text ="";
            txtdurasi.Text ="";
            txtharga.Text ="";
         
            //pictureBox1.Image = null;
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtfilm.Text.Trim() == "" || txtgenre.Text.Trim() == "" || txtdurasi.Text.Trim() == "" || txtharga.Text.Trim() ==  "")

            {
                MessageBox.Show("Harap Isi Data Dengan Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                conn.Command("insert into products(nama_film,genre,durasi,harga_tiket) values('" + txtfilm.Text + "', '" + txtgenre.Text + "', '" + txtdurasi.Text + "', '" + txtharga.Text +  "')");
                conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Menambah Film')");
                MessageBox.Show("Insert Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTxt();
                //Show();
                TampilData();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtfilm.Text.Trim() == "" || txtgenre.Text.Trim() == "" || txtdurasi.Text.Trim() == "" || txtharga.Text.Trim() ==  "")

            {
                MessageBox.Show("Harap Isi Data Dengan Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                conn.Command("update products set nama_film='" + txtfilm.Text + "', genre='" + txtgenre.Text + "', durasi='" + txtdurasi.Text + "',  harga_tiket='" + txtharga.Text + "' where id = '" + id + "'");
                conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Merubah Data Film')");
                MessageBox.Show("Update Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearTxt();
                //Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Menghapus Data: " + txtfilm .Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Command("delete from products where id ='" + id + "'");
                //hapus gambar dari folder
                //gambar = dg_produk.Rows[4].Cells.ToString();
                //string newlocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\assets\\" + gambar + "";
                //pictureBox1.Image.Dispose();
                //File.Delete(newlocation);
                conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Menghapus Data Film')");
                MessageBox.Show(" Data:" + txtfilm.Text + " Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearTxt();
                //Show();
            }
        }

        private void dg_produk_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_produk.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                txtfilm.Text = row.Cells["nama_film"].Value.ToString();
                txtgenre.Text = row.Cells["genre"].Value.ToString();
                txtdurasi.Text = row.Cells["durasi"].Value.ToString();
                txtharga.Text = row.Cells["harga_tiket"].Value.ToString();

                //gambar = row.Cells["urlgambar"].Value.ToString();

                ////taking image from the folder using its path
                //string dir = Path.GetDirectoryName(Application.ExecutablePath);
                //Image image = Image.FromFile(dir + "\\assets\\" + gambar);
                //pictureBox1.Image = image;



            }
        }
        public class FileNotFoundException : System.IO.IOException
        { }




        private void CariData(string cari)
        {
            Koneksi.conn.Open();
            if (txtcari.TextLength == 0)
            {
                cmd = new MySqlCommand("SELECT * FROM products", Koneksi.conn); ;
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM products where id like '%" + cari + "%' or nama_film like '%" + cari + "%'", Koneksi.conn);
            }
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg_produk.DataSource = dt;
            Koneksi.conn.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminUsers au = new AdminUsers();
            au.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            CariData(txtcari.Text);
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar ?", "Konfirmasi",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm lgn = new LoginForm();
                lgn.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         


        }

        //private void button4_Click(object sender, EventArgs e)
        //{
           
        //    OpenFileDialog opf = new OpenFileDialog();
        //    opf.Filter = "Choose Image(*.jpg; *.png; *.gif; *.jpeg)|*.jpg; *.png; *.gif; *.jpeg";
        //    if (opf.ShowDialog() == DialogResult.OK)
        //    {

        //        //inserting image to a folder
        //        string newlocation = Path.GetDirectoryName(Application.ExecutablePath) + "\\assets\\" + txtfilm.Text + ".jpg";
        //        string filename = opf.FileName;
        //        if (pictureBox1.Image != null)
        //        {
        //            pictureBox1.Image.Dispose();
        //        }

        //        pictureBox1.Image = Image.FromFile(opf.FileName);
        //        File.Copy(filename, newlocation);

        //        newName = txtfilm.Text + ".jpg";
        //        gambar = newName;
        //    }
        //    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        //}

        private void dg_produk_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
           
        }

        private void txtgenre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdurasi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfilm_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
