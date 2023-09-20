using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarpinis_atsikaitymas.Models
{
    [Table("Student")]
    public class Student
    {
        public Student()
        {
        }

        public Student(string firstName, string lastName, string email, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
        }

        public Student(string firstName, string lastName, string email, string phoneNumber, Guid departmentId)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            DepartmentId = departmentId;
        }

        [Key]
        [Required]
        public Guid StudentId { get; set; }
        [Required]
        [MaxLength(100)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
        [Required]
        [MaxLength(100)]
        public string PhoneNumber { get; set; }
        public IList<StudentLecture> StudentLectures { get; set; } = new List<StudentLecture>();
        public Guid DepartmentId { get; set; }
        public Department Departament { get; set; }    
    }
}
