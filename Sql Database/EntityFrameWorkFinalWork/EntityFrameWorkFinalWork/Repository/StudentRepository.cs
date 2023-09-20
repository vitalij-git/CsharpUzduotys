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
    public class StudentRepository : IStudentRepository
    {
        public void AddStudent(Student student)
        {
            using var context = new DatabaseConfig();
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void DeleteStudent(Guid id)
        {
            using var context = new DatabaseConfig();
            
        }

        public void UpdateStudent(Guid id, Student student)
        {
            throw new NotImplementedException();
        }
    }
}
