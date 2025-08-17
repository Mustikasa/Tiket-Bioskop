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
    public partial class KasirDashboard : Form
    {
        Koneksi conn = new Koneksi();
        
        MySqlCommand cmd;
      
        

        MySqlDataReader rd;

        DataTable dt = new DataTable();
        public KasirDashboard()
        {
            InitializeComponent();

           
           
        }

        private void KasirDashboard_Load(object sender, EventArgs e)
        {
            NoUnik();
            
        }

        private void NoUnik()
        {
            long itung;
            string urut;
            MySqlDataReader dr;
            Koneksi.conn.Open();

            cmd = new MySqlCommand("select nomor_unik from transactions where nomor_unik in(select max(nomor_unik) from transactions) order by nomor_unik desc", Koneksi.conn);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                itung = Convert.ToInt64(dr[0].ToString().Substring(dr["nomor_unik"].ToString().Length - 3, 3)) + 1;
                string idurut = "000" + itung;
                urut = "TKT" + idurut.Substring(idurut.Length - 3, 3);
            }
            else
            {
                urut = "TKT001";
            }
            dr.Close();
            txtnomorunik.Text = urut;
            Koneksi.conn.Close();

        }

        private void clearTxts()
        {
            txtid.Text = "";
            txtnama.Text ="";
            txtfilm.Text ="";
            txtgenre.Text = "";
            txtdurasi.Text = "";
            txtbayar.Text ="";
            txtkmbali.Text ="";
            txttotal.Text = "";
            txtharga.Text = "";
            cbostudio.Text="";
            cbokursi.Text="";
            txtresult.Text="";

        }

        private void Hitung()
        {
            int total, harga, bayar, kembali;
            harga = int.Parse(txtharga.Text.Trim() != string.Empty ? txtharga.Text.Trim() : "0");
            bayar = int.Parse(txtbayar.Text.Trim() != string.Empty ? txtbayar.Text.Trim() : "0");
            total = int.Parse(txttotal.Text.Trim() != string.Empty ? txttotal.Text.Trim() : "0");
            kembali = bayar - total;
            total = harga;
            txttotal.Text = total.ToString();
            txtkmbali.Text = kembali.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pilih_Film kp = new Pilih_Film();
            kp.ShowDialog();
            txtid.Text = kp.getId();
            txtfilm.Text = kp.getNf();
            txtgenre.Text = kp.getGenre();
            txtdurasi.Text = kp.getDurasi();
            txtharga.Text = kp.getHarga();

          

        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void txtbayar_TextChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void txtkmbali_TextChanged(object sender, EventArgs e)
        {
            Hitung();
        }

        private void btnsimpan_Click(object sender, EventArgs e)
        {
            conn.Command("insert into transactions(id_products,nama_pelanggan,nomor_unik,nama_studio,no_kursi,total,uang_bayar,uang_kembali) values('" + txtid.Text + "', '" + txtnama.Text + "', '" + txtnomorunik.Text + "', '" + cbostudio.Text + "', '" + cbokursi.Text + "','" + txttotal.Text + "',  '" + txtbayar.Text + "',  '" + txtkmbali.Text + "')");
            conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Menyimpan Data Transaksi')");
            MessageBox.Show("Berhasil Disimpan", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
            clearTxts();
            NoUnik();
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

        private void btngenerate_Click(object sender, EventArgs e)
        {
            txtresult.Clear();
            txtresult.Text += "==================================================\n";
            txtresult.Text += "==============                  Cinesas             ===============\n";
            txtresult.Text += "===============================================\n";
            txtresult.Text += " Date :"+ DateTime.Now+"\n\n";

            txtresult.Text += "Kode Transaksi : " + txtnomorunik.Text + "\n\n";
            txtresult.Text += "Nama Customer : " + txtnama.Text + "\n\n";
            txtresult.Text += "Studio : " + cbostudio.Text + "\n\n";
            txtresult.Text += "Nomor Kursi : " + cbokursi.Text + "\n\n";

            txtresult.Text += "==================================================\n";

            txtresult.Text += "Judul Film : " + txtfilm.Text + "\n\n";
            txtresult.Text += "Harga : " + txtharga.Text + "\n\n";
            txtresult.Text += "Total : " + txttotal.Text + "\n\n";
            txtresult.Text += "Tunai : " + txtbayar.Text + "\n\n";
            txtresult.Text += "Kembalian : " + txtkmbali.Text + "\n\n";


            txtresult.Text += "\n                         Terimakasih Silahkan Datang Kembali\n";



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(txtresult.Text, new System.Drawing.Font("Microsoft Sans Serif ", 18,FontStyle.Bold),Brushes.Black, new Point(10, 10));
        }

        private void btncetak_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Mencetak Nota Transaksi')");
        }

        private void txtfilm_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
