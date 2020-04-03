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
using MySql.Data.MySqlClient;

namespace Kouvee_Pet_Shop.Boundary
{
    public partial class FormPesan : Form
    {
        public FormPesan()
        {
            InitializeComponent();
        }
        PesanControl pc = new PesanControl();
        DataTable dt = new DataTable();

        public void setDataGridView(DataGridView DG)
        {
            dt.Clear();
            //MySqlDataAdapter adapter = pc.showPesan();
            //adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama Produk";
            DG.Columns[2].HeaderText = "Jumlah Produk";
            DG.Columns[3].HeaderText = "Supplier";

        }



        private void btnInput_Click(object sender, EventArgs e)
        {
            PesanControl pc = new PesanControl();
            pc.Parent = this;
            pc.Show();
            pc.BringToFront();
        }

        public void RefreshGridView()
        {
            setDataGridView(dataGridView1);
        }
        private void FormPesan_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
            RefreshGridView();
        }
    }
}
