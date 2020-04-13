using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kouvee_Pet_Shop.DAO;
using Kouvee_Pet_Shop.Entity;
using MySql.Data.MySqlClient;

namespace Kouvee_Pet_Shop.Control
{
    class HewanControl
    {
        public MySqlDataAdapter showHewan()
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT * FROM hewans";
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

        internal bool insertHewan(Hewan input)
        {
            throw new NotImplementedException();
        }
    }
}
