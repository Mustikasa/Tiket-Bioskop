using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySqlConnector;

namespace TiketBioskop
{
    internal class Koneksi
    {
        public static MySqlConnection conn = new MySqlConnection
            ("server = localhost; uid = root; " + "password=''; database = tiket_bioskop; Convert Zero Datetime=True;");


        public DataRowCollection GetData(string query)
        {
            MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            return dt.Rows;
        }

        public void Command(string query)
        {
            try
            {
                Koneksi.conn.Open();
                MySqlCommand com = new MySqlCommand(query, conn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Koneksi.conn.Close();
            }
        }

        //public void ReadData(string query, DataGridView dgv)
        //{
        //    try
        //    {
        //        if (conn.State == ConnectionState.Closed) conn.Open();
        //        MySqlCommand command = new MySqlCommand(query, conn);
        //        MySqlDataAdapter sda = new MySqlDataAdapter(command);
        //        DataTable dt = new DataTable();
        //        sda.Fill(dt);
        //        dgv.DataSource = dt;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }

        //}
    }
}
