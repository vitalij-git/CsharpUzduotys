using Microsoft.EntityFrameworkCore;
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
        public void Add(Department department)
        {
            using var context = new DatabaseConfig();
            context.Departaments.Add(department);
            context.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            using var context = new DatabaseConfig();
            return context.Departaments.ToList();
        }

        public Department GetDeparmentById(Guid departmentId)
        {
            using var context = new DatabaseConfig();
            return context.Departaments.Include(d => d.Students).FirstOrDefault(d => d.DepartmentId == departmentId);
        }

        public void Update(Guid deparmentId, Department department)
        {
            using var context = new DatabaseConfig();
            var result = context.Departaments.SingleOrDefault(l => l.DepartmentId == deparmentId);
            if (result != null)
            {
                result.Title = department.Title;
                result.DepartmentHead = department.DepartmentHead;
                context.SaveChanges();
            }

        }


       
    }
}
