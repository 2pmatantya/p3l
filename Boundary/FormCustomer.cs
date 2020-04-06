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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
        {
            InitializeComponent();
        }

        CustomerControl cc = new CustomerControl();
        DataTable dt = new DataTable();

        public void setDataGridView(DataGridView DG)
        {
            dt.Clear();
            MySqlDataAdapter adapter = cc.showCustomer();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama";
            DG.Columns[2].HeaderText = "Alamat";
            DG.Columns[3].HeaderText = "Tanggal Lahir";
            DG.Columns[4].HeaderText = "Nomor Telp";


        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            CustomerUC cuc = new CustomerUC();
            cuc.Parent = this;
            cuc.Show();
            cuc.BringToFront();
        }

        public void RefreshGridView()
        {
            setDataGridView(dataGridView1);
        }
        private void FormCustomer_Load(object sender, EventArgs e)
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
            table.Columns.Add("Nama Customer", typeof(string));
            table.Columns.Add("Alamat", typeof(string));
            table.Columns.Add("Tanggal Lahir", typeof(string));
            table.Columns.Add("Nomor Telp", typeof(int));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }
    }

}
