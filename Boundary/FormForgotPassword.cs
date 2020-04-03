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
using Kouvee_Pet_Shop.Entity;
using Kouvee_Pet_Shop.DAO;
using Kouvee_Pet_Shop.Control;
using Kouvee_Pet_Shop.UC;

namespace Kouvee_Pet_Shop.Boundary
{
    public partial class FormForgotPassword : Form
    {
        public FormForgotPassword()
        {
            InitializeComponent();
        }
        Login LC = new Login();

        public bool IsPasswordEqual(string pass1, string pass2)
        {
            if (pass1.Equals(pass2))
            {
                return true;
            }
            return false;
        }

        private bool checktxt()
        {
            bool temp = true;

            if (txtnotelp.Text == "")
            {
                //errorProvider1.SetError(txtnotelp, "Masukkan nomor telepon anda!");
                txtnotelp.Focus();
                temp = false;
            }
            if (txtuser.Text == "")
            {
                //errorProvider1.SetError(txtuser, "Masukkan username anda!");
                txtuser.Focus();
                temp = false;
            }
            if (txtpassword.Text == "")
            {
                //errorProvider1.SetError(txtpassword, "Masukkan password!!");
                txtpassword.Focus();
                temp = false;
            }
            if (txtkonfirm.Text == "")
            {
                //errorProvider1.SetError(txtkonfirm, "Ulangi password!");
                txtkonfirm.Focus();
                temp = false;
            }
            return temp;
        }



        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (checktxt() == true)
            {
                if (!IsPasswordEqual(txtpassword.Text, txtkonfirm.Text))
                {
                    MessageBox.Show("Masukkan password yang sama!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Forgotpass(txtuser.Text, txtnotelp.Text);
                }
            }
        }



        private void Forgotpass(string username, string notelp)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter adapter = Lupas(username, notelp);
            adapter.Fill(dt);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show("Username atau nomor pegawai tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtuser.Focus();
            }
            else
            {
               
                DbConnector db = new DbConnector();
                MySqlConnection conn = new MySqlConnection(db.connectionString());
                conn.Open();
                try
                {
                    MySqlCommand cmd = conn.CreateCommand();
                    cmd.CommandText = "UPDATE tbl_pegawai SET tbl_pegawai.password = @pwd WHERE (tbl_pegawai.username LIKE @username AND tbl_pegawai.no_telepon LIKE @notelp)";
                    cmd.Parameters.AddWithValue("@pwd", txtpassword.Text);
                    cmd.Parameters.AddWithValue("@username", txtuser.Text);
                    cmd.Parameters.AddWithValue("@notelp", txtnotelp.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Login fr = new Login();
                    fr.Show();
                    this.Close();


                }
                catch (MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
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

        public MySqlDataAdapter Lupas(String username, String notelp)
        {
            DbConnector db = new DbConnector();
            MySqlConnection conn = new MySqlConnection(db.connectionString());
            MySqlCommand cmd;
            conn.Open();
            try
            {
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT tbl_pegawai.username, tbl_pegawai.password, tbl_pegawai.no_telepon FROM tbl_pegawai  WHERE (tbl_pegawai.username LIKE @user AND tbl_pegawai.no_telepon LIKE @notelp)";
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@notelp", notelp);
                cmd.ExecuteNonQuery();
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                return adapter;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Login fl = new Login();
            fl.Show();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
            Login fr = new Login();
            fr.Show();
        }

        private void txtuser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
        }

        private void txtnotelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 39)
                e.Handled = true;
            if (e.KeyChar == 13)
            {

            }
        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnotelp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtkonfirm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
