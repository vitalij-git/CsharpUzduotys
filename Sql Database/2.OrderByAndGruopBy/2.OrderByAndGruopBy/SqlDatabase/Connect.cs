
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace _2.OrderByAndGruopBy.SqlDatabase
{
    internal class Connect
    {
        private SqlConnection SqlConnection = new SqlConnection();
        public SqlConnection ConnectToDatabase()
        {
            string connection = "Data Source=DESKTOP-O7DTL46;Initial Catalog=AdventureWorksDW2022;Integrated Security=True;";
            SqlConnection = new SqlConnection(connection);
            SqlConnection.Open();
            return SqlConnection;
        }

        public void CloseConection()
        {
            SqlConnection.Close();
        }
    }
}