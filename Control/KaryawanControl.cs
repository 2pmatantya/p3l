using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kouvee_Pet_Shop.DAO;
using Kouvee_Pet_Shop.Entity;
using MySql.Data.MySqlClient;

namespace Kouvee_Pet_Shop.Control
{
    class KaryawanControl
    {
        public MySqlDataAdapter showKaryawan()
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM karyawans";
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                //if (conn.State == ConnectionState.Open)
                conn.Close();
            }
        }

        public bool insertKaryawan(Karyawan input)
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO karyawans (Nama_Karyawan, Alamat, Nomor_Telp, Email, Username, Password) " +
                    "VALUE (@nama_karyawan, @alamat, @nomor_telp, @jabatan, @email, @username, @password)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nama_karyawan", input.Nama_Karyawan);
                cmd.Parameters.AddWithValue("@alamat", input.Alamat);
                cmd.Parameters.AddWithValue("@nomor_telp", input.Nomor_Telp);
                cmd.Parameters.AddWithValue("@jabatan", " ");
                cmd.Parameters.AddWithValue("@email", input.Email);
                cmd.Parameters.AddWithValue("@username", input.Username);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }
    }
}
