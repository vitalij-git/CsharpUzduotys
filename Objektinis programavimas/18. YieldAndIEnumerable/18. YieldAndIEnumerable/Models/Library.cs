
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;
using System.Collections;
using System.Reflection.PortableExecutable;

namespace _18._YieldAndIEnumerable.Models
{
    internal class Library
    {
        public SqlConnection Connection { get; set; }= new SqlConnection("Data Source=DESKTOP-O7DTL46;Initial Catalog=Vitalij;Integrated Security=True;");

       
        public void AddBook(Book book)
        {   
            string query = $@"Insert Into Books([Name],[Pages],[Author],[ISBN]) Values (@Name,@Pages,@Author,@ISBN)";
            using (Connection )
            {
                try
                {
                    Connection.Open();
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {

                        command.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar).Value = book.Name;
                        command.Parameters.Add("@Pages", System.Data.SqlDbType.NVarChar).Value = book.Pages;
                        command.Parameters.Add("@Author", System.Data.SqlDbType.NVarChar).Value = book.Author;
                        command.Parameters.Add("@ISBN", System.Data.SqlDbType.NVarChar).Value = book.ISBN;

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
            Connection.Close();
        }
        public void ReadFromDataBase()
        {
            
            string query = "SELECT * FROM Books";

            using (Connection)
            {
                Connection.Open();

                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string name = reader.GetString(0);
                            int pages = reader.GetInt32(1);
                            string author = reader.GetString(2);
                            string isbn = reader.GetString(3);

                            Console.WriteLine($"Name: {name}, pages: {pages}, author: {author}, ISBN: {isbn}");
                        }
                    }
                }
            }
            Connection.Close();
        }
        public void GetBooksByNameOrByAuthor(string type, string value)
        {

            string query = $"SELECT * FROM Books Where {type}='{value}'";

            using (Connection)
            {
                Connection.Open();

                using (SqlCommand command = new SqlCommand(query, Connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string name = reader.GetString(0);
                            int pages = reader.GetInt32(1);
                            string author = reader.GetString(2);
                            string isbn = reader.GetString(3);

                            Console.WriteLine($"Name: {name}, pages: {pages}, author: {author}, ISBN: {isbn}");
                        }
                    }
                }
            }
            Connection.Close();
        }
        public void GetBooksAveragePage()
        {

            string query = "SELECT * FROM Books";
            var pagesResult = 0;
            var booksCount = 0;
            int average = 0;
            using (Connection)
            {
                try
                {
                    Connection.Open();
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int pages = reader.GetInt32(1);
                                pagesResult += pages;
                                booksCount++;
                            }
                            average = (int)(pagesResult / booksCount);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message.ToString());
                }
            }
            Connection.Close();
            GetBooksByPagesCount(average);
        }
        public void GetBooksByPagesCount(int average)
        {
            var query = $"SELECT * FROM Books Where Pages>{average}";
            try
            {
                using (var connection = new SqlConnection("Data Source=DESKTOP-O7DTL46;Initial Catalog=Vitalij;Integrated Security=True;"))
                {
                    connection.Open();
                    using (SqlCommand commandPages = new SqlCommand(query, connection))
                    {

                        using (SqlDataReader reader = commandPages.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string name = reader.GetString(0);
                                int pages = reader.GetInt32(1);
                                string author = reader.GetString(2);
                                string isbn = reader.GetString(3);
                                Console.WriteLine($"Name: {name}, pages: {pages}, author: {author}, ISBN: {isbn}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

    }
}