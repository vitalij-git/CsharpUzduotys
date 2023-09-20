using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarpinis_atsikaitymas.Models;

namespace Tarpinis_atsikaitymas.Interface
{
    public interface ILectureRepository
    {
        public void AddLecture(Lecture lecture);
    }
}
