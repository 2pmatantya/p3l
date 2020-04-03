using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kouvee_Pet_Shop.Control;
using Kouvee_Pet_Shop.DAO;
using System.Data;


namespace Kouvee_Pet_Shop.DAO
{
    class DAOLogin
    {
        public bool validate_login(string user, string password)
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT nama FROM tbl_pegawai WHERE username = @user AND password = @password";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", password);
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
                {
                    conn.Close();
                }
            }
        }

        public bool validate_user(string user, string notelp)
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT nama FROM tbl_pegawai WHERE username = @user AND no_telepon = @no_telepon";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@no_telepon", notelp);
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
                {
                    conn.Close();
                }
            }
        }

        public int GetRole(string user, string pass)
        {
            int id = 0;
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT id from tbl_pegawai WHERE username = @user, password = @password";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", pass);
                cmd.ExecuteNonQuery();
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public bool updatePass(string user, string password)
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "UPDATE tbl_pegawai SET username = @user, password = @password WHERE username = @user";
                cmd.Parameters.AddWithValue("@user", user);
                cmd.Parameters.AddWithValue("@password", password);
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
                {
                    conn.Close();
                }
            }
        }
    }
}
