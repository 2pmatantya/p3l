using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Kouvee_Pet_Shop.Control;
using Kouvee_Pet_Shop.DAO;
using System.Data;

namespace Kouvee_Pet_Shop.Control
{
    class Login
    {
        DAOLogin Id = new DAOLogin();

        public bool Valid(string user, string pass)
        {
            return Id.validate_login(user, pass);
        }

        public int GetRole(string user, string pass)
        {
            return Id.GetRole(user, pass);
        }
        public bool validate_user(string user, string notelp)
        {
            return Id.validate_user(user, notelp);


        }

        public bool updatePass(string user, string pass)
        { return Id.updatePass(user, pass); }
    }
}
