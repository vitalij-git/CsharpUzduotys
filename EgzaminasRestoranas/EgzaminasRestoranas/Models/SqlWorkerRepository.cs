
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace EgzaminasRestoranas.Models
{
    internal class SqlWorkerRepository : IWorkerRepository
    {
        
        public void Add(Worker worker)
        {
            string query = $"Insert into Workers(FirstName,LastName,Role,Username,Password) " +
                $"Values({worker.FirstName},{worker.LastName},{worker.Role},{worker.Username},{worker.Password})";
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

       
    }
}