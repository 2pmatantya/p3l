using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouvee_Pet_Shop.Entity
{
    class Supplier
    {
        string nama_supplier, alamat, nomor_telp;


        public Supplier(string nama_supplier, string alamat, string nomor_telp)
        {
            this.Nama_Supplier = nama_supplier;
            this.Alamat = alamat;
            this.Nomor_telp = nomor_telp;
        }

        public String Nama_supplier
        {
            get { return nama_supplier; }
            set { nama_supplier = value; }
        }

        public string Nama_Supplier { get; }

        public String Alamat
        {
            get { return alamat; }
            set { alamat = value; }
        }

        public String Nomor_telp
        {
            get { return nomor_telp; }
            set { nomor_telp = value; }
        }
    }

   

}
