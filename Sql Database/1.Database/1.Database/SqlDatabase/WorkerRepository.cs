using _1.Database.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace _1.Database.SqlDatabase
{
    internal class WorkerRepository : IDatabaseRepository<Worker>
    {
        private Connect Connect = new Connect(); 
        private SqlCommand SqlCommand = new SqlCommand();
        private SqlConnection SqlConnection;
        public void Add(Worker entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, List<Worker>> GetAll()
        {
            Dictionary<int , List<Worker>> workersDictionary = new Dictionary<int , List<Worker>>();
            SqlConnection = Connect.ConnectToDatabase();
            string query = "Select * from DimEmployee";
            SqlCommand = new SqlCommand(query, SqlConnection);
            using (SqlDataReader reader = SqlCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["EmployeeKey"]);
                    Worker worker = new Worker()
                    {

                        FirstName = reader["FirstName"].ToString(),
                        LastName = reader["LastName"].ToString(),
                        Role = reader["Title"].ToString(),
                        Department = reader["DepartmentName"].ToString(),
                        PersonalCode = Convert.ToInt32(reader["EmployeeNationalIDAlternateKey"]),
                        BirthDate = reader["BirthDate"].ToString()
                    };
                    if (!workersDictionary.ContainsKey(id))
                    {
                        workersDictionary[id] = new List<Worker>();
                    }
                    workersDictionary[id].Add(worker);
                }
            }
            Connect.CloseConection();
            return workersDictionary;
        }

        public Worker GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id)
        {
            throw new NotImplementedException();
        }

       

       
    }
}