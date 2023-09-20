using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarpinis_atsikaitymas.Database;
using Tarpinis_atsikaitymas.Interface;
using Tarpinis_atsikaitymas.Models;

namespace Tarpinis_atsikaitymas.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        public void AddDepartment(Department department)
        {
            using var context = new DatabaseConfig();
            context.Departaments.Add(department);
            context.SaveChanges();
        }
        public void DeleteDepartment(Guid deparmentId)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(Guid deparmentId, Department department)
        {
            throw new NotImplementedException();
        }
    }
}
