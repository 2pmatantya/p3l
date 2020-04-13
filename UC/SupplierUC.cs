using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kouvee_Pet_Shop.Control;
using MySql.Data.MySqlClient;
using Kouvee_Pet_Shop.Entity;
using Kouvee_Pet_Shop.Boundary;

namespace Kouvee_Pet_Shop.UC
{
    public partial class SupplierUC : UserControl
    {

        MySqlConnection connection = new MySqlConnection("datasource=localhost;Database=9340;port=3306;username=root;");

        MySqlCommand command;
        public SupplierUC()
        {
            InitializeComponent();
        }
        SupplierControl sc = new SupplierControl();

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
        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            // string insertQuery = "INSERT INTO products(Nama Produk ,Harga ,Jumlah, Jenis Produk, Supplier) VALUES ('" + txtNama.Text + "','" + txtHarga.Text + "','" +
            //                     txtHarga.Text + "','" + cmbJenis.Text + "','" + txtSupplier.Text + "')";
            // executeQuery(insertQuery);
            Supplier input = new Supplier(txtNamaSupplier.Text, txtAlamat.Text, txtTelp.Text);
            bool check = sc.insertSupplier(input);
            if (check)
            {
                MessageBox.Show("sukses");
            }
            else
            {
                MessageBox.Show(input.Nama_supplier + " " + input.Alamat + " " + input.Nomor_telp + " ", "gagal");
            }
            this.Hide();
            FormSupplier myparent = (FormSupplier)this.Parent;
            myparent.RefreshGridView();
        }

        private void txtNamaSupplier_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
