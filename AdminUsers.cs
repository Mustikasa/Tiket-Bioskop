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
    public partial class AdminUsers : Form
    {
        Koneksi conn = new Koneksi();
        Koneksi con = new Koneksi();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;

        //untuk update delete
        int id;
        public AdminUsers()
        {
            InitializeComponent();
        }

        private void AdminUsers_Load(object sender, EventArgs e)
        {
            TampilData();
            CariData("");

        }

        void TampilData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT * FROM users", Koneksi.conn);
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dg_users.DataSource = data;
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
            txtuser.Text ="";
            txtpasswrd.Text ="";
            txtnama.Text ="";
            cbojenkel.Text ="";
            txtalamat.Text ="";
            txtphone.Text ="";
            cborole.Text ="";
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() == "" || txtpasswrd.Text.Trim() == "" || txtnama.Text.Trim() == "" || cbojenkel.Text.Trim() == "" || txtalamat.Text.Trim() == "" || txtphone.Text.Trim() == "" || cborole.Text.Trim() == "")

            {
                MessageBox.Show("Harap Isi Data Dengan Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                conn.Command("insert into users(username,password,nama,jenis_kelamin,alamat,nophone,role) values('" + txtuser.Text + "', '" + txtpasswrd.Text + "', '" + txtnama.Text + "', '" + cbojenkel.Text + "', '" + txtalamat.Text + "' , '" + txtphone.Text + "' , '" + cborole.Text + "')");
                conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Menambah Data Pengguna')");
                MessageBox.Show("Insert Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTxt();
                TampilData();
            }
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            if (txtuser.Text.Trim() == "" || txtpasswrd.Text.Trim() == "" || txtnama.Text.Trim() == "" || cbojenkel.Text.Trim() == "" || txtalamat.Text.Trim() == "" || txtphone.Text.Trim() == "" || cborole.Text.Trim() == "")

            {
                MessageBox.Show("Harap Isi Data Dengan Lengkap", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                conn.Command("update users set username='" + txtuser.Text + "', password='" + txtpasswrd.Text + "', nama='" + txtnama.Text + "', jenis_kelamin='" + cbojenkel.Text + "', alamat='" + txtalamat.Text + "', nophone='" + txtphone.Text + "', role='" + cborole.Text + "' where id = '" + id + "'");
                conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Mengubah Data Pengguna')");
                MessageBox.Show("Update Data Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearTxt();

            }
        }

        private void btnhapus_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda Yakin Ingin Menghapus Data: " + txtuser.Text + " ?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.Command("delete from users where id ='" + id + "'");
                conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Menghapus Data Pengguna')");
                MessageBox.Show(" Data:" + txtuser.Text + " Berhasil Dihapus", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TampilData();
                ClearTxt();
            }
        }

        private void dg_users_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dg_users.Rows[e.RowIndex];
                id = Convert.ToInt32(row.Cells[0].Value);
                txtuser.Text = row.Cells["username"].Value.ToString();
                txtpasswrd.Text = row.Cells["password"].Value.ToString();
                txtnama.Text = row.Cells["nama"].Value.ToString();
                cbojenkel.Text = row.Cells["jenis_kelamin"].Value.ToString();
                txtalamat.Text = row.Cells["alamat"].Value.ToString();
                txtphone.Text = row.Cells["nophone"].Value.ToString();
                cborole.Text = row.Cells["role"].Value.ToString();
            }
        }

        private void CariData(string cari)
        {
            Koneksi.conn.Open();
            if (txtcari.TextLength == 0)
            {
                cmd = new MySqlCommand("SELECT * FROM users", Koneksi.conn); ;
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM users where id like '%" + cari + "%' or username like '%" + cari + "%'", Koneksi.conn);
            }
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg_users.DataSource = dt;
            Koneksi.conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminProduct ap = new AdminProduct();
            ap.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            CariData(txtcari.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar ?", "Konfirmasi",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm lgn = new LoginForm();
                lgn.Show();
                this.Hide();
            }
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah Anda Yakin Ingin Keluar ?", "Konfirmasi",
  MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm lgn = new LoginForm();
                lgn.Show();
                this.Hide();
            }
        }

        private void btnproduk_Click(object sender, EventArgs e)
        {
            AdminProduct ap = new AdminProduct();
            ap.Show();
            this.Hide();
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
    }
}
