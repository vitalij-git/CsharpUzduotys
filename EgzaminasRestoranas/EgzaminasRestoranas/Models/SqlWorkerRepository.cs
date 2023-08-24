
using EgzaminasRestoranas.Forms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Models
{
    public class SqlWorkerRepository : IDatabaseRepository<Worker>
    {

        private ConnectToDatabase Connection { get; set; } = new ConnectToDatabase();
        private SqlCommand Command { get; set; }= new SqlCommand();
        private SqlConnection SqlConnection { get; set; } = new SqlConnection();
        public void Add(Worker worker)
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"Insert into Workers(FirstName,LastName,Role,Username,Password) " +
                    $"Values(@FirstName,@LastName,@Role,@Username,@Password)";
                Command = new SqlCommand(query, SqlConnection);
                Command.Parameters.AddWithValue("@FirstName", worker.FirstName);
                Command.Parameters.AddWithValue("@LastName", worker.LastName);
                Command.Parameters.AddWithValue("@Role", worker.Role);
                Command.Parameters.AddWithValue("@Username", worker.Username);
                Command.Parameters.AddWithValue("@Password", worker.Password);
                Command.ExecuteNonQuery();
                Connection.CloseConnection();   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void Delete(int id)
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"delete from Workers where ID ='{id}'";
                Command = new SqlCommand(query, SqlConnection);
                Command.ExecuteNonQuery();
                Connection.CloseConnection();
                MessageBox.Show("Darbuotojas sėkmingai ištrintas");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public Dictionary<int,List<Worker>>  GetAll()
        {
            Dictionary<int, List<Worker>> workersDictionary = new Dictionary<int, List<Worker>>();
            try
            {
                SqlConnection = Connection.Connection();
                string query = "Select * from Workers";
                Command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                       int id = Convert.ToInt32(reader["ID"]);
                        Worker worker = new Worker()
                        {

                            FirstName = reader["FirstName"].ToString(),
                            LastName = reader["LastName"].ToString(),
                            Role = reader["Role"].ToString(),
                            Username = reader["username"].ToString()
                        };
                        if (!workersDictionary.ContainsKey(id))
                        {
                            workersDictionary[id] = new List<Worker>();
                        }
                        workersDictionary[id].Add(worker);  
                    }    
                }
                Connection.CloseConnection();
                return workersDictionary;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public Worker GetById(int id)
        {
            Worker worker = new Worker();
            try
            {
                SqlConnection = Connection.Connection();
                string query = $"Select * from Workers where ID  = '{id}'";
                Command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    reader.Read();  
                    worker.FirstName = reader["FirstName"].ToString();
                    worker.LastName = reader["LastName"].ToString();
                    worker.Role = reader["Role"].ToString();
                    worker.Username = reader["username"].ToString();
                    worker.Password = reader["password"].ToString();
                   
                }
                Connection.CloseConnection();
                return worker;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public void Update(Worker worker,int id)
        {
            try 
            {
                SqlConnection = Connection.Connection();
                string query = $"Update Workers Set FirstName = @FirstName, LastName = @LastName, " +
                     $"Role = @Role, Username = @Username, Password = @Password " +
                     $"Where ID = {id}";
                Command = new SqlCommand(query, SqlConnection);
                Command.Parameters.AddWithValue("@FirstName", worker.FirstName);
                Command.Parameters.AddWithValue("@LastName", worker.LastName);
                Command.Parameters.AddWithValue("@Role", worker.Role);
                Command.Parameters.AddWithValue("@Username", worker.Username);
                Command.Parameters.AddWithValue("@Password", worker.Password);
                Command.ExecuteNonQuery();
                Connection.CloseConnection();
                MessageBox.Show("Darbuotojas sėkmingai atnaujintas");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        public SqlDataReader CheckUsernameWithDatabase(string workerUsername)
        {
            try
            {
                SqlConnection = Connection.Connection();
                string query = "Select * From Workers where Username = '" + workerUsername + "'";
                SqlCommand command = new SqlCommand(query, SqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           return null;
        }
    }

}