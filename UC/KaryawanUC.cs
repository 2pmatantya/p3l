using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Kouvee_Pet_Shop.Control;
using MySql.Data.MySqlClient;
using Kouvee_Pet_Shop.Entity;
using Kouvee_Pet_Shop.Boundary;

namespace Kouvee_Pet_Shop.Control
{
    public partial class KaryawanUC : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=9340;port=3306;username=root;");

        MySqlCommand command;
        public KaryawanUC()
        {
            InitializeComponent();
        }
        KaryawanControl kc = new KaryawanControl();

        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public void executeQuery(String query)
        {
            try
            {
                openConnection();
                command = new MySqlCommand(query, connection);

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Query Executed");
                }
                else
                {
                    MessageBox.Show("Query Not Executed");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                closeConnection();
            }
        }
       
        private void KaryawanControl_Load(object sender, EventArgs e)
        {

        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            // string insertQuery = "INSERT INTO products(Nama Produk ,Harga ,Jumlah, Jenis Produk, Supplier) VALUES ('" + txtNama.Text + "','" + txtHarga.Text + "','" +
            //                     txtHarga.Text + "','" + cmbJenis.Text + "','" + txtSupplier.Text + "')";
            // executeQuery(insertQuery);
            Karyawan input = new Karyawan(txtNama.Text, txtAlamat.Text, txtTelp.Text, txtEmail.Text, txtUser.Text, txtPassword.Text);
            bool check = kc.insertKaryawan(input);
            if (check)
            {
                MessageBox.Show("sukses");
            }
            else
            {
                MessageBox.Show(input.Nama_Karyawan + " " + input.Alamat + " " + input.Nomor_Telp, "gagal");
            }
            this.Hide();
            FormKaryawan myparent = (FormKaryawan)this.Parent;
            myparent.RefreshGridView();
        }
    }
}
