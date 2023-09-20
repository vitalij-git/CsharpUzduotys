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
    public class LectureRepository : ILectureRepository
    {
        public void AddLecture(Lecture lecture)
        {
            using var context = new DatabaseConfig();
            context.Lectures.Add(lecture);
            context.SaveChanges();
        }
    }
}
