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
    public partial class ActivityTracking : Form
    {
        public ActivityTracking()
        {
            InitializeComponent();
        }

        private void ActivityTracking_Load(object sender, EventArgs e)
        {
            TampilData();
        }

        void TampilData()
        {
            try
            {
                Koneksi.conn.Open();
                MySqlDataAdapter Tampil = new MySqlDataAdapter("SELECT l.id, l.id_users, u.username, l.activity, l.created_at FROM log l INNER JOIN users u ON l.id_users = u.id;", Koneksi.conn) ;
                DataTable data = new DataTable();
                Tampil.SelectCommand.ExecuteNonQuery();
                Tampil.Fill(data);
                dg_aktivitas.DataSource = data;
                Koneksi.conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal \n Error" + ex.Message,
               "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            OwnerDashboard od = new OwnerDashboard();
            od.Show();
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

        private void dg_aktivitas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
