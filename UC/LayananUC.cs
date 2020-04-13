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
    public partial class LayananUC : UserControl
    {
        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=9340;port=3306;username=root;");

        MySqlCommand command;
        public LayananUC()
        {
            InitializeComponent();
        }
        LayananControl lc = new LayananControl();

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

        private void LayananControl_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // string insertQuery = "INSERT INTO products(Nama Produk ,Harga ,Jumlah, Jenis Produk, Supplier) VALUES ('" + txtNama.Text + "','" + txtHarga.Text + "','" +
            //                     txtHarga.Text + "','" + cmbJenis.Text + "','" + txtSupplier.Text + "')";
            // executeQuery(insertQuery);
            Layanan input = new Layanan(txtLayanan.Text, int.Parse(txtHarga.Text));
            bool check = lc.insertLayanan(input);
            if (check)
            {
                MessageBox.Show("sukses");
            }
            else
            {
                MessageBox.Show(input.Nama_layanan + " " + input.Harga + " ", "gagal");
            }
            this.Hide();
            FormLayanan myparent = (FormLayanan)this.Parent;
            myparent.RefreshGridView();
        }
    }
}
