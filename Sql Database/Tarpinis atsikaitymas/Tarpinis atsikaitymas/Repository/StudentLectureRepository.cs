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
    public class StudentLectureRepository : IManyToManyRepository<StudentLecture>
    {
        public void Add(StudentLecture studentLectures)
        {
            using var context = new DatabaseConfig();
            context.Add(studentLectures);
            context.SaveChanges();
        }

        public IEnumerable<StudentLecture> GetAll()
        {
            using var context = new DatabaseConfig();
            return context.StudentLectures.ToList();
        }

        public IEnumerable<Student> GetStudentsByLectureId(Guid lectureId)
        {
           using var context = new DatabaseConfig();
           return  context.StudentLectures.Where(l => l.LectureId == lectureId).Select(s => s.Student).ToList();
           

        }
        public IEnumerable<Lecture> GetLecturesByStudentId(Guid studentId)
        {
            using var context = new DatabaseConfig();
            return context.StudentLectures.Where(s => s.StudentId == studentId).Select(l => l.Lecture).ToList();
            
        }
    }
}
