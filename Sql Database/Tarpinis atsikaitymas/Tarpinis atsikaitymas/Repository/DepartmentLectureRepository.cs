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
            using var context = new DatabaseConfig();
            return context.DepartmentLectures.ToList();
        }

        public IEnumerable<Lecture> GetLecturesByDepartmentId(Guid departmentId)
        {
            using var context = new DatabaseConfig();
            return context.DepartmentLectures.Where(d => d.DepartmentId == departmentId).Select(l => l.Lecture).ToList();
            
            
        }
        public IEnumerable<Department> GetDeparmtmentsByLectureId(Guid lectureId)
        {
            using var context = new DatabaseConfig();
            return context.DepartmentLectures.Where(l => l.LectureId == lectureId).Select(d => d.Lecture).ToList(); ;
        }
    }
}
