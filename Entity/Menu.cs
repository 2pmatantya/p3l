using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kouvee_Pet_Shop.Entity
{
    class Menu
    {
        string nama_produk, supplier;
        double harga;
        int jumlah, jenis_produk;

        public Menu(string nama_produk, double harga, int jumlah, int jenis_produk, string supplier)
        {
            this.nama_produk = nama_produk;
            this.harga = harga;
            this.jumlah = jumlah;
            this.jenis_produk = jenis_produk;
            this.supplier = supplier;
        }

        public string Nama_produk
        {
            get { return nama_produk; }
            set { nama_produk = value; }
        }

        public string Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }

        public double Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public int Jumlah
        {
            get { return jumlah; }
            set { jumlah = value; }
        }

        public int Jenis_produk
        {
            get { return jenis_produk; }
            set { jenis_produk = value; }
        }
    }
}