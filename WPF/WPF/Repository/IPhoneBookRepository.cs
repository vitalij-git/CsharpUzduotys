using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Models;

namespace WPF.Repository
{
    public interface IPhoneBookRepository
    {
        public void AddContact();
        public void UpdateContact(int id);
        public IEnumerable<PhoneBook> GetAllContacts();
        public void DeleteContact(int id);
        public PhoneBook GetContact(int id);
    }
}
