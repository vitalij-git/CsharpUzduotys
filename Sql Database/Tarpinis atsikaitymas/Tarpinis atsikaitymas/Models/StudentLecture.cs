using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpinis_atsikaitymas.Models
{
    public class StudentLecture
    {
        public Guid LectureId { get; set; }
        public Lecture Lecture { get; set; }
        public Guid StudentId { get; set; }
        public Student Student { get; set; }
    }
}
