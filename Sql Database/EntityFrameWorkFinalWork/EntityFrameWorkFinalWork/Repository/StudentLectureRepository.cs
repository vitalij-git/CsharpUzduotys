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
            return 
        }
    }
}
