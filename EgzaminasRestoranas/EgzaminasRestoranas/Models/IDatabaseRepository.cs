using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models
{
    public interface IDatabaseRepository<T>
    {
        T GetById (int id);
        Dictionary<int, List<T>> GetAll();
        void Add(T item);
        void Update(T item, int id);
        void Delete(int id);

    }
}
