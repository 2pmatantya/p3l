﻿using System;
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
            MySqlDataAdapter adapter = pc.showPesan();
            adapter.Fill(dt);
            DG.DataSource = dt;

            DG.Columns[0].HeaderText = "ID";
            DG.Columns[1].HeaderText = "Nama Produk";
            DG.Columns[2].HeaderText = "Jumlah Produk";
            DG.Columns[3].HeaderText = "Supplier";

        }



        private void btnInput_Click(object sender, EventArgs e)
        {
            PesanUC pmuc = new PesanUC();
            pmuc.Parent = this;
            pmuc.Show();
            pmuc.BringToFront();
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
        DataTable table = new DataTable();

        private void Remove_DataGridView_Selected_Row_Load(object sender, EventArgs e)
        {
            setDataGridView(this.dataGridView1);
            RefreshGridView();
            table.Columns.Add("Id", typeof(int));
            table.Columns.Add("Nama Produk", typeof(string));
            table.Columns.Add("Jumlah Produk", typeof(int));
            table.Columns.Add("Supplier", typeof(string));
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            PesanUC pmuc = new PesanUC();
            pmuc.Parent = this;
            pmuc.Show();
            pmuc.BringToFront();
        }
    }
}
