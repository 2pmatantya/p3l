using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouvee_Pet_Shop.Entity
{
    class Karyawan
    {
        string nama_karyawan, ttl, alamat, nomor_telp, role, email, username, password;

        public Karyawan(string text1, string text2, string text3, string text4, string text5, string text6)
        {

        }

        public Karyawan(string nama_karyawan, string ttl, string alamat, string nomor_telp, string role, string email, string username, string password )
        {
            this.nama_karyawan = nama_karyawan;
            this.ttl = ttl;
            this.alamat = alamat;
            this.nomor_telp = nomor_telp;
            this.role = role;
            this.email = email;
            this.username = username;

        }

        public String Nama_Karyawan
        {
            get { return nama_karyawan; }
            set { nama_karyawan = value; }
        }

        public String Ttl
        {
            get { return ttl; }
            set { ttl = value; }
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
        public String Role
        {
            get { return role; }
            set { role = value; }
        }
        public String Email
        {
            get { return email; }
            set { email = value; }
        }
        public String Username
        {
            get { return username; }
            set { username = value; }
        }
       
    }
}

