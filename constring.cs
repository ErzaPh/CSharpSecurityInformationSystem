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

        private static string MysqlConnString = "SERVER=localhost; DATABASE= dbsecifnosystem; UID=root; PASSWORD=fastspeed";

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
