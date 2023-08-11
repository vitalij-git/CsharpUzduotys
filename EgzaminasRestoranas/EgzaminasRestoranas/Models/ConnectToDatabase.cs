using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models
{
    internal class ConnectToDatabase
    {
        public SqlConnection Connection()
        {
            var connection = "Data Source=DESKTOP-O7DTL46;Initial Catalog=Restoranas;Integrated Security=True;";
            var sql = new SqlConnection(connection);
            return sql;
        }
    }
}
