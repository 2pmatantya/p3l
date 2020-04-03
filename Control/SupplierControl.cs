using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using Kouvee_Pet_Shop.DAO;

namespace Kouvee_Pet_Shop.Control
{
    class SupplierControl
    {
        public MySqlDataAdapter showSupplier()
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM suppliers";
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
    }
}
