using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpinis_atsikaitymas.Interface
{
    public interface IManyToManyRepository<T>
    {
        public void Add(T entity);
        public IEnumerable<T> GetAll();
    }
}
