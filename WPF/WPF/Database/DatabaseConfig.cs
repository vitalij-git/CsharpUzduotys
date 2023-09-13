using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Database
{
    public class DatabaseConfig
    {
        public DatabaseConfig() 
        {
            ConnString = "Data Source=DESKTOP-O7DTL46;Initial Catalog=PhoneBook;Integrated Security=True";
        }
        public string ConnString { get; }
        
    }
}
