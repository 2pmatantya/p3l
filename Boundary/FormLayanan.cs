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
    public partial class FormLayanan : Form
    {
        public FormLayanan()
        {
            InitializeComponent();
        }

        LayananControl lc = new LayananControl();
        DataTable dt = new DataTable();

        public void setDataGridView(DataGridView DG)
        {
            dt.Clear();
            //MySqlDataAdapter adapter = lc.showLayanan();
            //adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama Layanan";
            DG.Columns[2].HeaderText = "Harga";


        }



        private void btnInput_Click(object sender, EventArgs e)
        {
            LayananUC luc = new LayananUC();
            luc.Parent = this;
            luc.Show();
            luc.BringToFront();
        }

        public void RefreshGridView()
        {
            setDataGridView(dataGridView1);
        }
        private void FormLayanan_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
            RefreshGridView();
        }
    }
}
