using Tarpinis_atsikaitymas.Database;
using Tarpinis_atsikaitymas.Interface;
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

            //AddStudent();

            //MoveStudentToNewDepartment();

            //GetAllDeparmentSudents();

            //GetAllDepartamentLectures();

            GetAllLecturesByStudent();
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

            AddDepartment(department);
            AddLectures(lectures);
            AddDepartmentsAndLectures(department, lectures);
        }
        static void AddDepartment(Department department)
        {
            DepartmentRepository departmentRepository = new DepartmentRepository();
            departmentRepository.Add(department);
        }
        static void AddLectures(List<Lecture> lectures)
        {
            LectureRepository lectureRepository = new LectureRepository();
            lectureRepository.AddListOfLectures(lectures);
        }
        static void AddDepartmentsAndLectures(Department department, List<Lecture> lectures)
        {
            DepartmentLectureRepository departmentLectureRepository = new DepartmentLectureRepository();
            foreach (var lecture in lectures)
            {
                departmentLectureRepository.Add(new DepartmentLecture { DepartmentId = department.DepartmentId, LectureId = lecture.LectureId });
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
        //4
        static void AddStudent()
        {
            Guid guid = Guid.Parse("07CCCCC8-75B3-453B-0E7C-08DBB945DC75");
            Student student = new Student("Arunas", "ss", "Arunas@gmail.com", "+37033452", guid);
            StudentRepository studentRepository = new StudentRepository();
            studentRepository.Add(student);
            LectureRepository lectureRepository = new LectureRepository();
            var lectures = lectureRepository.GetAll();
            StudentLectureRepository studentLectureRepository = new StudentLectureRepository();
            foreach(var lecture in lectures)
            {
                studentLectureRepository.Add(new StudentLecture { StudentId =student.StudentId, LectureId=lecture.LectureId });
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
            var students = deparmentRepository.GetDeparmentById(departmentId);
            StudentsOutput(students);
        }

        static void StudentsOutput(Department students)
        {
            var i = 1;
            foreach (var student in students.Students)
            {
                Console.WriteLine($"{i}.First name is {student.FirstName} \nLast name is {student.LastName} \nPhone number is {student.PhoneNumber} \nEmail is {student.Email}");
                i++;
            }
        }

        //7
        static void GetAllDepartamentLectures()
        {
            Guid departmentId = Guid.Parse("07CCCCC8-75B3-453B-0E7C-08DBB945DC75");
            DepartmentLectureRepository departmentLectureRepository = new DepartmentLectureRepository();
            var lectures = departmentLectureRepository.GetLecturesByDepartmentId(departmentId);
            LecturesOutput(lectures);

        }
        static void LecturesOutput(IEnumerable<Lecture> lectures)
        {
            foreach (var lecture in lectures)
            {
                Console.WriteLine(lecture.Title);
            }
        }
       
        static void GetAllLecturesByStudent()
        {
            Guid studentId = Guid.Parse("1DA032D1-EACF-4E64-74B3-08DBB9E88742");
            StudentLectureRepository studentLectureRepository= new StudentLectureRepository();  
            var lectures = studentLectureRepository.GetLecturesByStudentId(studentId);
            OutputLectores(lectures);

        }
        static void OutputLectores(IEnumerable<Lecture> lectures)
        {
            foreach(var lecture in lectures) 
            { 
                Console.WriteLine(lecture.Title);
            }
        }
        
    }
}