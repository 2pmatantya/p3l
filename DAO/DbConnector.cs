using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kouvee_Pet_Shop.DAO
{
    class DbConnector
    {
        private string server, database, uid, password;

        public string connectionString()
        {
            //server = "192.168.19.140";
            //database = "9340";
            //uid = "9340";
            //password = "pp9340";
            //string connectionString = "SERVER=" + server + "; USER ID=" + uid + "; DATABASE=" + database + "; PASSWORD=" + password + ";";
            //return connectionString;

            server = "localhost";
            database = "p3l_ricky";
            uid = "root";
            password = "";
            string connectionString = "SERVER=" + server + "; USER ID=" + uid + "; DATABASE=" + database + "; PASSWORD=" + password + ";";
            return connectionString;
        }
    }
}
