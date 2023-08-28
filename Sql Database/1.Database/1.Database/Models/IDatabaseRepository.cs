using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Database.Models
{
    public interface  IDatabaseRepository<T>
    {
        public void Add(T entity);  
        public void Update(int id);   
        public void Delete(int id);   
        public Dictionary<int,List<T>> GetAll();
        public T GetById (int id);
    }
}
