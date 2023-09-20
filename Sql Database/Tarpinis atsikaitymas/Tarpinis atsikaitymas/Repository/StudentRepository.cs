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
        public void Add(Student student)
        {
            using var context = new DatabaseConfig();
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void Update(Guid studentId, Student student)
        {
            using var context = new DatabaseConfig();
            var result = context.Students.SingleOrDefault(l => l.StudentId == studentId);
            if (result != null)
            {
                result.FirstName = student.FirstName;
                result.LastName = student.LastName;
                result.Email = student.Email;
                result.PhoneNumber = student.PhoneNumber;
                context.SaveChanges();
            }
        }

        public void MoveStudentToNewDepartment(Guid studentId, Guid deparmentId)
        {
            using var context = new DatabaseConfig();
            var result = context.Students.SingleOrDefault(l => l.StudentId == studentId);
            if (result != null)
            {
                result.DepartmentId = deparmentId;
                context.SaveChanges();
            }
        }

        public void AddListOfStudents( IEnumerable<Student> students)
        {
            using var context = new DatabaseConfig();
            context.Students.AddRange(students);
            context.SaveChanges();
        }
    }
}
