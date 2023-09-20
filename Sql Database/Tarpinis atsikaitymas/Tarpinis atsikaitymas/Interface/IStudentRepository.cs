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
        public void Add(Student student);
        public void Update(Guid id, Student student);
        public void MoveStudentToNewDepartment(Guid studentId, Guid deparmentId);


    }
}
