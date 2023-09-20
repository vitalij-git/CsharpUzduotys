using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarpinis_atsikaitymas.Models;

namespace Tarpinis_atsikaitymas.Interface
{
    public interface IStudentRepository
    {
        public void AddStudent(Student student);
        public void UpdateStudent(Guid id, Student student);
        public void DeleteStudent(Guid id);
    }
}
