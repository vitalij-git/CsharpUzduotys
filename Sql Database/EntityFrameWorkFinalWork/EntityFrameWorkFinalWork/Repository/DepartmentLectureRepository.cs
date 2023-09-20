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
    internal class DepartmentLectureRepository : IManyToManyRepository<DepartmentLecture>
    {
        public void Add(DepartmentLecture departmentLecture)
        {
            using var context = new DatabaseConfig();
            context.Add(departmentLecture);
            context.SaveChanges();
        }

        public IEnumerable<DepartmentLecture> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
