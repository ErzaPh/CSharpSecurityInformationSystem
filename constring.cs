using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace CSharpSecurityInformationSystem
{
    class constring
    {

        public static string MysqlConnString = "SERVER=localhost; DATABASE= dbsecinfosystem; USERID=root; PASSWORD=password@123";

        public static string connect
        {
            get
            {
                return MysqlConnString;
            }
            set
            {
                MysqlConnString = value;
            }
        }
    
      }
}
