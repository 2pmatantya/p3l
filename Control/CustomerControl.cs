using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kouvee_Pet_Shop.Entity;
using Kouvee_Pet_Shop.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kouvee_Pet_Shop.Control
{
    class CustomerControl
    {
        public MySqlDataAdapter showCustomer()
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM customers";
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

       public bool insertCustomer(Customer input)
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO customers (Nama, Alamat, Nomor_Telp) VALUE (@nama_customer, @alamat, @nomor_telp)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nama_customer", input.Nama_Customer);
                cmd.Parameters.AddWithValue("@alamat", input.Alamat);
                cmd.Parameters.AddWithValue("@nomor_telp", input.Nomor_Telp);
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
