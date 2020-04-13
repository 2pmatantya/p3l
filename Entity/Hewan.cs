using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouvee_Pet_Shop.Entity
{
    class Hewan
    {
        string nama_hewan, nama_customer;

        public enum jenis_hewan
        {
            Anjing = 0,
            Kucing = 1,
            Reptil = 2,
            Burung = 3,
            Hewan_Kecil = 4
        }

        public enum ukuran_hewan
        {
            Sangat_Besar = 0,
            Besar = 1,
            Biasa = 2,
            Kecil = 3,
            Sangat_Kecil = 4
        }


        public Hewan(string nama_hewan, string nama_customer)
        {
            this.nama_hewan = nama_hewan;
            this.nama_customer = nama_customer;
        }

        public String Nama_Hewan
        {
            get { return nama_hewan; }
            set { nama_hewan = value; }
        }
        public String Nama_Customer
        {
            get { return nama_customer; }
            set { nama_customer = value; }
        }
    }
}
