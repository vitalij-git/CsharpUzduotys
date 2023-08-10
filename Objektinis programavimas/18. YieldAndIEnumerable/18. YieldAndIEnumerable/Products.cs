
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace _18._YieldAndIEnumerable
{
    internal class Products
    {
        public void ReadFromDataBase()
        {
            string connectionString = "Data Source=DESKTOP-O7DTL46;Initial Catalog=Vitalij;Integrated Security=True;";
            string query = "SELECT * FROM Products Where Price<=3";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            string column1Value = reader.GetString(0); 
                            int column2Value = reader.GetInt32(1);    

                            Console.WriteLine($"Name: {column1Value}, price: {column2Value}");
                        }
                    }
                }
            }
        }
        
    }
}