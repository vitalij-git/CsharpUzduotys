using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpinis_atsikaitymas.Models
{
    public class DepartmentLecture
    {
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }    
        public Guid LectureId { get; set; }
        public Lecture Lecture { get; set;}
    }
}
