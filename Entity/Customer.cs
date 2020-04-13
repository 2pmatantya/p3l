using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouvee_Pet_Shop.Entity
{
    class Customer
    {
        string nama_customer, alamat, nomor_telp;


        public Customer(string nama_customer, string alamat, string nomor_telp)
        {
            this.nama_customer = nama_customer;
            this.alamat = alamat;
            this.nomor_telp = nomor_telp;
        }

        public String Nama_Customer
        {
            get { return nama_customer; }
            set { nama_customer = value; }
        }
        public String Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }
        public String Nomor_Telp
        {
            get { return nomor_telp; }
            set { nomor_telp = value; }
        }
    }
}
