using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Kouvee_Pet_Shop.Boundary;

namespace Kouvee_Pet_Shop.Boundary
{
    public partial class FormUtama : Form
    {
        public FormUtama()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_produk(object sender, EventArgs e)
        {
            FormProduk fp = new FormProduk();
            fp.MdiParent = this;
            fp.Show();
            fp.BringToFront();
        }

        private void btnLayanan_Click(object sender, EventArgs e)
        {
            FormLayanan fp = new FormLayanan();
            fp.MdiParent = this;
            fp.Show();
            fp.BringToFront();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            FormKaryawan fp = new FormKaryawan();
            fp.MdiParent = this;
            fp.Show();
            fp.BringToFront();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FormCustomer fp = new FormCustomer();
            fp.MdiParent = this;
            fp.Show();
            fp.BringToFront();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            FormSupplier fp = new FormSupplier();
            fp.MdiParent = this;
            fp.Show();
            fp.BringToFront();
        }

        private void btnHewan_Click(object sender, EventArgs e)
        {
            FormHewan fp = new FormHewan();
            fp.MdiParent = this;
            fp.Show();
            fp.BringToFront();
        }

        private void btnPesan_Click(object sender, EventArgs e)
        {
            FormHewan fp = new FormHewan();
            fp.MdiParent = this;
            fp.Show();
            fp.BringToFront();
        }
    }
}
