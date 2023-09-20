using Tarpinis_atsikaitymas.Database;
using Tarpinis_atsikaitymas.Models;
using Tarpinis_atsikaitymas.Repository;

namespace Tarpinis_atsikaitymas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AddDepartment();

            //AddDeparmentLecture();

            //AddStudentToDepartment();

            //AddStudentsToDepartment();

            //AddListOfLecturesToDepartment();

            //MoveStudentToNewDepartment();

            //GetAllDeparmentSudents();

            GetAllDepartamentLectures();
        }

        //1 Sukurti departamentą ir pridėti studentus
        private static void AddDepartment()
        {
            DepartmentRepository departmentRepository = new DepartmentRepository();
            Department department = new Department();
            department.Title = "Energetika";
            department.DepartmentHead = "Simas Morkus";
            department.Students = new List<Student>() { new Student("Tomas","Tomaitis","tomas@gmail,com","+37551551"), new Student("Arnas", "Arnaitis", "arnas@gmail,com", "+37485414") };
            departmentRepository.Add(department);
        }

        //1 Sukurti departamentą ir pridėti paskaitas.
        static void AddDeparmentLecture()
        {
            
            Department department = new Department();
            department.Title = "Saule";
            department.DepartmentHead = "Tomas Tom";
            var lectures = new List<Lecture>()
            {
                new Lecture { Title = "Filosofija"},
                new Lecture { Title = "Gamta"},
                new Lecture { Title = "Istorija"},
                new Lecture { Title = "Fizika"}
            };
            DepartmentRepository departmentRepository = new DepartmentRepository();
            departmentRepository.Add(department);

            LectureRepository lectureRepository = new LectureRepository();
            lectureRepository.AddListOfLectures(lectures);

            DepartmentLectureRepository departmentLectureRepository = new DepartmentLectureRepository();
            foreach (var lecture in lectures)
            {
                departmentLectureRepository.Add(new DepartmentLecture { DepartmentId = department.DepartmentId, LectureId= lecture.LectureId });
            }
            
        }

        //2
        static void AddStudentToDepartment()
        {
            Guid guid = Guid.Parse("7084CE29-BABC-4E66-47D4-08DBB9498933");
            Student student = new Student("Tomas", "Vasilis", "Tomas@gmail.com", "+370365812", guid);
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Add(student);
        }
        
        static void AddStudentsToDepartment()
        {
            Guid guid = Guid.Parse("7084CE29-BABC-4E66-47D4-08DBB9498933");
            var students = new List<Student>()
            {
                new Student("Saule", "Saule", "Saule@gmail.com", "+3703546", guid),
                new Student("Saule1", "Saule1", "Saule1@gmail.com", "+3706456", guid),
                new Student("Saule2", "Saule2", "Saule2@gmail.com", "+3754663", guid),
                new Student("Saule3", "Saule3", "Saule3@gmail.com", "+3705646", guid)
            };
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.AddListOfStudents(students);
        }

        static void AddListOfLecturesToDepartment()
        {
            Guid departmentGuid = Guid.Parse("07CCCCC8-75B3-453B-0E7C-08DBB945DC75");
            var lectures = new List<Lecture>()
            {
                new Lecture { Title = "Pamoka1"},
                new Lecture { Title = "Pamoka2"},
                new Lecture { Title = "Pamoka3"},
                new Lecture { Title = "Pamoka4"}
            };
            LectureRepository lectureRepository = new LectureRepository();
            lectureRepository.AddListOfLectures(lectures);
            DepartmentLectureRepository departmentLectureRepository = new DepartmentLectureRepository();
            foreach (var lecture in lectures)
            {
                departmentLectureRepository.Add(new DepartmentLecture { DepartmentId = departmentGuid, LectureId = lecture.LectureId });
            }
        }
        //5
        static void MoveStudentToNewDepartment()
        {
            Guid newDepartmentId = Guid.Parse("7084CE29-BABC-4E66-47D4-08DBB9498933");
            Guid studentGuid = Guid.Parse("79B945A6-2740-4FFB-5E83-08DBB945DC7A");
            var studentRepository = new StudentRepository();
            studentRepository.MoveStudentToNewDepartment(studentGuid,newDepartmentId);
        }
        //6
        static void GetAllDeparmentSudents()
        {
            Guid departmentId = Guid.Parse("7084CE29-BABC-4E66-47D4-08DBB9498933");
            var deparmentRepository = new DepartmentRepository();
            var result = deparmentRepository.GetDeparmentById(departmentId);

           
        }

        //7
        static void GetAllDepartamentLectures()
        {
            Guid departmentId = Guid.Parse("07CCCCC8-75B3-453B-0E7C-08DBB945DC75");
            //DepartmentLectureRepository departmentLectureRepository = new DepartmentLectureRepository();
            //var departmentLectures = departmentLectureRepository.GetLecturesByDepartmentId(departmentId);
            //foreach(var result in departmentLectures)
            //{
                
            //}
            using var context = new DatabaseConfig();
            var result = context.DepartmentLectures.Where(d => d.DepartmentId == departmentId).Select(l => l.Lecture).ToList();
            foreach (var department in result)
            {
                Console.WriteLine(department.Title);
            }
        }
        static void random()
        {
            Guid lectureId = Guid.Parse("CD076515-D6F0-4919-78A5-08DBB8665F36");
            Guid studendId = Guid.Parse("C58984DA-7B9A-4DAD-248E-08DBB489DD18");
            StudentLectureRepository studentLectureRepository = new StudentLectureRepository();
            studentLectureRepository.Add(new StudentLecture() { LectureId = lectureId, StudentId = studendId });
        }

        
    }
}