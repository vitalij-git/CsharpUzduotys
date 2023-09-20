using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarpinis_atsikaitymas.Database;
using Tarpinis_atsikaitymas.Models;

namespace Tarpinis_atsikaitymas.Interface
{
    public interface IDepartmentRepository
    {
        public void Add(Department department);
        public void Update(Guid deparmentId, Department department);
        public Department GetDeparmentById(Guid departmentId);

        public IEnumerable<Department> GetAll();

    }
}
