using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kouvee_Pet_Shop.Entity
{
    class Role
    {
        string name;
        public Role(String name)
        {
            this.name = name;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
