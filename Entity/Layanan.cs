using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouvee_Pet_Shop.Entity
{
    class Layanan
    {
        string nama_layanan;
        int harga;

        public Layanan(string nama_layanan, int harga)
        {
            this.Nama_layanan = nama_layanan;
            this.Harga = harga;
        }

        public String Nama_layanan
        {
            get { return nama_layanan; }
            set { nama_layanan = value; }
        }
   
        public int Harga
        {
            get { return harga; }
            set { harga = value; }
        }

    }
}

