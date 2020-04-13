using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouvee_Pet_Shop.Entity
{
    class Produk
    {
        string nama_produk;
        int jumlah, harga;
        string supplier;
        
        public enum jenis
        {
            Anjing = 0,
            Kucing = 1,
            Reptil = 2,
            Burung = 3,
            Hewan_Kecil = 4
        }
        
        public Produk(string nama_produk, int harga, int jumlah, string supplier)
        {
            this.nama_produk = nama_produk;
            this.jumlah = jumlah;
            this.harga = harga;
            this.supplier = supplier;
        }

        public String Nama_produk
        {
            get { return nama_produk; }
            set { nama_produk = value; }
        }
        public int Jumlah
        {
            get { return jumlah; }
            set { jumlah = value; }
        }

        public int Harga
        {
            get { return harga; }
            set { harga = value; }
        }

        public String Supplier
        {
            get { return supplier; }
            set { supplier = value; }
        }
    }
}
