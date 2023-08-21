
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Models
{
    public class SqlWorkerRepository : IWorkerRepository
    {
        private ConnectToDatabase Connection { get; set; } = new ConnectToDatabase();

        public void Add(Worker worker)
        {
            try
            {
                SqlConnection connection = Connection.Connection();
                string query = $"Insert into Workers(FirstName,LastName,Role,Username,Password) " +
                    $"Values({worker.FirstName},{worker.LastName},{worker.Role},{worker.Username},{worker.Password})";
                SqlCommand command = new SqlCommand(query, connection);
                var rowsAfected = command.ExecuteNonQuery();
                if (rowsAfected > 0)
                {

                }
                Connection.CloseConnection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        public void Delete(int id)
        {
            string query =$"delete form Workers where ID ='{id}'";
        }

        public void GetAll()
        {
            string query = "Select * from Workers";
            
        }

        public void GetById(int id)
        {
            string query = $"Select * from Workers where ID  = '{id}'";
        }

        public void Update(Worker worker,int id)
        {
            string query = $"Update Workers Set FirstName = {worker.FirstName}, LastName = {worker.LastName}, " +
                 $"Role = {worker.Role}, Username = {worker.Username}, Password = {worker.Password}" +
                 $"Where ID = {id}";
        }

        private void Database()
        {
            
        }
    }
}