using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpinis_atsikaitymas.Models
{
    [Table("Department")]
    public class Department
    {
        public Department()
        {
        }

        public Department(string title, string departmentHead)
        {
            Title = title;
            DepartmentHead = departmentHead;
        }

        [Key]
        [Required]
        public Guid DepartmentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(150)]
        public string DepartmentHead { get; set; }
        public IList<DepartmentLecture> DepartmentLectures { get; set; } = new List<DepartmentLecture>();
        public IList<Student> Students { get; set; } = new List<Student>();
    }
}
