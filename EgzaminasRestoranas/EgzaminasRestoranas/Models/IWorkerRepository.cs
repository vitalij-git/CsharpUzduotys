using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models
{
    public interface IWorkerRepository
    {
        void GetById (int id);
        void GetAll();
        void Add(Worker worker);
        void Update(Worker worker, int id);
        void Delete(int id);

    }
}
