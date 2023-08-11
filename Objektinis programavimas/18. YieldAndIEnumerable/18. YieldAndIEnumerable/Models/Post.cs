using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _18._YieldAndIEnumerable.Models
{
    internal class Post
    {
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }  

        public void AddPost()
        {
            var connection = new SqlConnection("Data Source=DESKTOP-O7DTL46;Initial Catalog=Vitalij;Integrated Security=True;");
            string query = @"Insert Into Post([Author,[Content],[Date]) Values (@Author,@Content,@Date)";
            using (connection)
            {
                try
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {

                        command.Parameters.Add("@Author", System.Data.SqlDbType.NVarChar).Value = Author;
                        command.Parameters.Add("@Content", System.Data.SqlDbType.NVarChar).Value = Content;
                        command.Parameters.Add("@Date", System.Data.SqlDbType.DateTime).Value = Date;                     

                        int rowsAdded = command.ExecuteNonQuery();
                        if (rowsAdded > 0)
                        {
                            Console.WriteLine("Book is added to database");
                        }
                        else
                        {
                            Console.WriteLine("Something wrong");
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }

            }
            connection.Close();
        }
    }
}