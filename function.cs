using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace TiketBioskop
{
    internal class function
    {
        public static string con = "Server=localhost;Database=tiket_bioskop;user=root;Pwd= ;SslMode=none";

        MySqlConnection koneksi = new MySqlConnection(con);
        private Form activateForm;

        public object ShowData(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, koneksi);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            return ds.Tables[0];
        }

        public DataRowCollection GetData(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows;
        }

        public void Command(string query)
        {
            try
            {
                koneksi.Open();
                MySqlCommand com = new MySqlCommand(query, koneksi);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                koneksi.Close();
            }
        }

    }
}

