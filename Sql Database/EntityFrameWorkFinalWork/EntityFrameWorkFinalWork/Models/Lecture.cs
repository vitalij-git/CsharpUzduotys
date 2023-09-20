using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpinis_atsikaitymas.Models
{
    [Table("Lecture")]
    public class Lecture
    {
        public Lecture()
        {
        }

        public Lecture(string title)
        {
            Title = title;
        }

        [Key]
        [Required]
        public Guid LectureId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public IList<StudentLecture> StudentLectures { get; set; } = new List<StudentLecture>();    
        public IList<DepartmentLecture> DepartamentLectures { get; set; } = new List<DepartmentLecture>();
    }
}
