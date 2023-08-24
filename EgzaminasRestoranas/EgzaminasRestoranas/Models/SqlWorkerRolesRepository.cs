
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EgzaminasRestoranas.Models
{
    public class SqlWorkerRolesRepository : IDatabaseRepository<WorkerRoles>
    {
        private ConnectToDatabase Connection { get; set; } = new ConnectToDatabase();
        private SqlCommand Command { get; set; } = new SqlCommand();
        private SqlConnection SqlConnection { get; set; } = new SqlConnection();
        public void Add(WorkerRoles item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, List<WorkerRoles>> GetAll()
        {
            Dictionary<int, List<WorkerRoles>> workersRolesDictionary = new Dictionary<int, List<WorkerRoles>>();
            try
            {
                SqlConnection = Connection.Connection();
                string query = "Select * from WorkerRoles";
                Command = new SqlCommand(query, SqlConnection);
                using (SqlDataReader reader = Command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["ID"]);
                        WorkerRoles workerRoles = new WorkerRoles()
                        {
                            Name = reader["Name"].ToString(), 
                        };
                        if (!workersRolesDictionary.ContainsKey(id))
                        {
                            workersRolesDictionary[id] = new List<WorkerRoles> ();
                        }
                        workersRolesDictionary[id].Add(workerRoles);
                    }
                }
                Connection.CloseConnection();
                return workersRolesDictionary;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public WorkerRoles GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(WorkerRoles item, int id)
        {
            throw new NotImplementedException();
        }
    }
}