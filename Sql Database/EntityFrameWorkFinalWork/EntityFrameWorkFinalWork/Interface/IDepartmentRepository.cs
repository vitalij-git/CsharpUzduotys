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
        public void AddDepartment(Department department);
        public void UpdateDepartment(Guid deparmentId, Department department);
        public void DeleteDepartment(Guid deparmentId);


    }
}
