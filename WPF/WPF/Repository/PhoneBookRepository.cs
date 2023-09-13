using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Database;
using WPF.Models;
using Dapper;
using System.Data;

namespace WPF.Repository
{
    public class PhoneBookRepository : IPhoneBookRepository
    {
        private readonly DatabaseConfig _databaseConfig;
        public void AddContact()
        {
            throw new NotImplementedException();
        }

        public void DeleteContact(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PhoneBook> GetAllContacts()
        {
            using SqlConnection connection = new SqlConnection(_databaseConfig.ConnString);
            var procedure = "spContacts_GetALL";
            var data = connection.Query<PhoneBook>(procedure, commandType: CommandType.StoredProcedure);
            return data;
        }

        public PhoneBook GetContact(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateContact(int id)
        {
            throw new NotImplementedException();
        }
    }
}
