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
    public partial class FormKaryawan : Form
    {
        public FormKaryawan()
        {
            InitializeComponent();
        }
        KaryawanControl kc = new KaryawanControl();
        DataTable dt = new DataTable();

        public void setDataGridView(DataGridView DG)
        {
            dt.Clear();
            MySqlDataAdapter adapter = kc.showKaryawan();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama Lengkap";
            DG.Columns[2].HeaderText = "Tanggal Lahir";
            DG.Columns[3].HeaderText = "Alamat";
            DG.Columns[4].HeaderText = "Nomor Telp";
            DG.Columns[5].HeaderText = "Jabatan";
            DG.Columns[6].HeaderText = "Email";
            DG.Columns[7].HeaderText = "Username"; 
            DG.Columns[8].HeaderText = "Password";

        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            KaryawanUC kuc = new KaryawanUC();
            kuc.Parent = this;
            kuc.Show();
            kuc.BringToFront();
        }

        public void RefreshGridView()
        {
            setDataGridView(dataGridView1);
        }
        private void FormKaryawan_Load(object sender, EventArgs e)
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
            table.Columns.Add("Nama Lengkap", typeof(string));
            table.Columns.Add("Tanggal Lahir", typeof(string));
            table.Columns.Add("Alamat", typeof(string));
            table.Columns.Add("Nomor Telp", typeof(string));
            table.Columns.Add("Jabatan", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Username", typeof(string));
            table.Columns.Add("Password", typeof(string));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }
}
