using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Kouvee_Pet_Shop.Entity;
using Kouvee_Pet_Shop.DAO;
using MySql.Data.MySqlClient;
using System.Data;

namespace Kouvee_Pet_Shop.Control
{
    class ProdukControl
    {
        public MySqlDataAdapter showProduk()
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM products";
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
                if (conn.State == ConnectionState.Open)
                conn.Close();
            }
        }
        
        public bool insertProduk(Produk input)
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "INSERT INTO products (Nama_Produk, Jumlah, Harga, Jenis_Produk, Supplier)" +
                    "VALUE (@nama_produk, @jumlah, @harga, @jenis, @supplier)";
                cmd.Prepare();
                cmd.Parameters.AddWithValue("@nama_produk", input.Nama_produk);
                cmd.Parameters.AddWithValue("@jumlah", input.Jumlah);
                cmd.Parameters.AddWithValue("@harga", input.Harga);
                cmd.Parameters.AddWithValue("@jenis", "Anjing");
                cmd.Parameters.AddWithValue("@supplier", input.Supplier);
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
