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
    public partial class FormHewan : Form
    {
        public FormHewan()
        {
            InitializeComponent();
        }
        HewanControl hc = new HewanControl();
        DataTable dt = new DataTable();

        public void setDataGridView(DataGridView DG)
        {
            dt.Clear();
            MySqlDataAdapter adapter = hc.showHewan();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama Hewan";
            DG.Columns[2].HeaderText = "Nama Customer";
            DG.Columns[3].HeaderText = "Jenis Hewan";
            DG.Columns[4].HeaderText = "Ukuran Hewan";


        }
        private void btnInput_Click(object sender, EventArgs e)
        {
            HewanUC huc = new HewanUC();
            huc.Parent = this;
            huc.Show();
            huc.BringToFront();
        }

        public void RefreshGridView()
        {
            setDataGridView(dataGridView1);
        }
        private void FormHewan_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
            RefreshGridView();
        }

        DataTable table = new DataTable();

        private void Remove_DataGridView_Selected_Row_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
            RefreshGridView();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Hewan", typeof(string));
            table.Columns.Add("Nama Customer", typeof(string));
            table.Columns.Add("Jenis Hewan", typeof(string));
            table.Columns.Add("Ukuran Hewan", typeof(string));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
