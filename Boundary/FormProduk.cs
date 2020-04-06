using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Kouvee_Pet_Shop.Control;
using MySql.Data.MySqlClient;


namespace Kouvee_Pet_Shop.Boundary
{
    public partial class FormProduk : Form
    {
        public FormProduk()
        {
            InitializeComponent();
        }

        ProdukControl pc = new ProdukControl();
        DataTable dt = new DataTable();
        
        public void setDataGridView(DataGridView DG)
        {
            dt.Clear();
            MySqlDataAdapter adapter = pc.showProduk();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama Produk";
            DG.Columns[2].HeaderText = "Harga";
            DG.Columns[3].HeaderText = "Jumlah";
            DG.Columns[3].HeaderText = "Jenis Produk";
            DG.Columns[3].HeaderText = "Supplier";
           


        }



        private void btnInput_Click(object sender, EventArgs e)
        {
            ProdukUC puc = new ProdukUC();
            puc.Parent = this;
            puc.Show();
            puc.BringToFront();
        }

        public void RefreshGridView()
        {
            setDataGridView(dataGridView1);
        }
        private void FormProduk_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
            RefreshGridView();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
          
        }
        DataTable table = new DataTable();

        private void Remove_DataGridView_Selected_Row_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
            RefreshGridView();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Produk", typeof(string));
            table.Columns.Add("Harga", typeof(int));
            table.Columns.Add("Jumlah", typeof(int));
            table.Columns.Add("Jenis Produk", typeof(string));
            table.Columns.Add("Supplier", typeof(string));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
       
        }
    }
}
