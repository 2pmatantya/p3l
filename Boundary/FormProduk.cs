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
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Stok";
            DG.Columns[3].HeaderText = "Harga";


        }



        private void btnInput_Click(object sender, EventArgs e)
        {
            ProdukPetControl ppc = new ProdukPetControl();
            ppc.Parent = this;
            ppc.Show();
            ppc.BringToFront();
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
    }
}
