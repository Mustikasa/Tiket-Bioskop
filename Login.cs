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

namespace TiketBioskop
{
    public partial class LoginForm : Form
    {

        public static string user;
        public LoginForm()
        {
            InitializeComponent();
        }
        Koneksi conn = new Koneksi();

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            user = txtusername.Text;
            string query = "SELECT id, username, password, role FROM users WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text + "'";
            int count = conn.GetData(query).Count;
            
            if (txtusername.Text == "" || txtpassword.Text == "")
            {
                MessageBox.Show(" Masukan Username dan Password");
            }
            try
            {
                if (count > 0)
                {
                    foreach (DataRow dr in conn.GetData(query))
                    {
                        Data.id_users = Convert.ToInt32(dr["id"]);
                        Data.nama = dr["username"].ToString();

                        if (dr["role"].ToString().Equals("admin"))
                        {
                            MessageBox.Show("Login Berhasil! Selamat Datang " + txtusername.Text + " (Admin) !");
                            new AdminUsers().Show();
                            this.Hide();
                            conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Login')");
                        }
                        else if (dr["role"].ToString().Equals("kasir"))
                        {
                            MessageBox.Show("Login Berhasil! Selamat Datang " + txtusername.Text + " (Kasir)!");
                            new KasirDashboard().Show();
                            this.Hide();
                            conn.Command("INSERT INTO log (`id_users`, `activity`) VALUES ('" + Data.id_users + "','Login')");
                        }
                        else if (dr["role"].ToString().Equals("owner"))
                        {
                            MessageBox.Show("Login Berhasil! Selamat Datang " + txtusername.Text + " (Owner)!");
                            new OwnerDashboard().Show();
                            this.Hide();

                        }
                       
                    }
                }
                else
                {
                    MessageBox.Show("Username atau Password Salah");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtusername.Text="";
            txtpassword.Text="";
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
