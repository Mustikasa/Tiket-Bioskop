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
using DGVPrinterHelper;

namespace TiketBioskop
{
   
    public partial class OwnerDashboard : Form
    {
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        public OwnerDashboard()
        {
            InitializeComponent();
        }

        private void OwnerDashboard_Load(object sender, EventArgs e)
        {
            TampilData("");
        }

        void TampilData(string cari)
        {
            Koneksi.conn.Open();
            if (txtcari.TextLength == 0)
            {
                cmd = new MySqlCommand("SELECT * FROM transactions", Koneksi.conn);
            }
            else
            {
                cmd = new MySqlCommand("SELECT * FROM transactions where id_products like '%" + cari + "%' or nama_pelanggan like '%" + cari + "%' or nomor_unik like '%" + cari + "%' or tanggal_transaksi like '%" + cari + "%'", Koneksi.conn);
            }
            adapter = new MySqlDataAdapter();
            adapter.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dg_transaksi.DataSource = dt;
            Koneksi.conn.Close();

        }
        void Filter()
        {
            Koneksi.conn.Open();
            MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT * FROM `transactions` WHERE (tanggal_transaksi BETWEEN '"+dateTimePicker1.Text+"' AND '"+dateTimePicker2.Text+"')", Koneksi.conn);
            DataTable data = new DataTable();
            Tampil.SelectCommand.ExecuteNonQuery();
            Tampil.Fill(data);
            dg_transaksi.DataSource = data;
            Koneksi.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TampilData("");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtcari_TextChanged(object sender, EventArgs e)
        {
            TampilData(txtcari.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Laporan Data Transaksi";
            printer.SubTitle = string.Format("Tanggal {0}", DateTime.Now.Date.ToString("dd-MMMM-yyyy"));
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.FooterSpacing = 15;
            printer.PrintPreviewDataGridView(dg_transaksi);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ActivityTracking ap = new ActivityTracking();
            ap.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
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

        private void btnproduk_Click(object sender, EventArgs e)
        {
            ActivityTracking at = new ActivityTracking();
            at.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}