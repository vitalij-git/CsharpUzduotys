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
        public void Add(Lecture lecture)
        {
            using var context = new DatabaseConfig();
            context.Lectures.Add(lecture);
            context.SaveChanges();
        }

        public IEnumerable<Lecture> GetAll()
        {
            using var context = new DatabaseConfig();
            return context.Lectures.ToList();
        }

        public void Update(Lecture lecture, Guid lectureId)
        {
            using var context = new DatabaseConfig();
            var result = context.Lectures.SingleOrDefault(l => l.LectureId == lectureId);   
            if (result != null)
            {
                result.Title = lecture.Title;   
                context.SaveChanges();
            }
        }

        public void AddListOfLectures(IEnumerable<Lecture> lectures)
        {
            using var context = new DatabaseConfig();
            context.Lectures.AddRange(lectures);    
            context.SaveChanges();
        }
    }
}
