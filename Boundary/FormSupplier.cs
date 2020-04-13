using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Kouvee_Pet_Shop.Control;
using Kouvee_Pet_Shop.UC;
using MySql.Data.MySqlClient;

namespace Kouvee_Pet_Shop.Boundary
{
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
        }

        SupplierControl sc = new SupplierControl();
        DataTable dt = new DataTable();

        public void setDataGridView(DataGridView DG)
        {
            dt.Clear();
            MySqlDataAdapter adapter = sc.showSupplier();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama Supplier";
            DG.Columns[2].HeaderText = "Alamat";
            DG.Columns[3].HeaderText = "Nomor Telp";


        }



        private void btnInput_Click(object sender, EventArgs e)
        {
            SupplierUC suc = new SupplierUC();
            suc.Parent = this;
            suc.Show();
            suc.BringToFront();
        }

        public void RefreshGridView()
        {
            setDataGridView(dataGridView1);
        }
        private void FormSupplier_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
            RefreshGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            SupplierUC suc = new SupplierUC();
            suc.Parent = this;
            suc.Show();
            suc.BringToFront();
        }
    }
}
