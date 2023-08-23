using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models
{
    public class Worker
    {
        public Worker()
        {
        }

        public Worker(string firstName, string lastName, string role, string username, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Username = username;
            Password = password;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

       

    }
}
