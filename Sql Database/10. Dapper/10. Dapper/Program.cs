
using Dapper;
using System.Data.SqlClient;

namespace _10._Dapper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=DESKTOP-O7DTL46; Initial Catalog=Practice;Integrated Security=True";
            using var connection = new SqlConnection(connectionString);
            connection.Execute(@"
                CREATE TABLE Product(
                ProductId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
                Name NVARCHAR(100) NOT NULL,
                Description NVARCHAR(1000) NULL
                );
            ");
        }
    }
}