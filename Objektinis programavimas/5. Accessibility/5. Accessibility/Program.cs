using _5._Accessibility.Models;

namespace _5._Accessibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new Person("Tomas",25);
            var student = new Student(1,"Jonas",26);
            person.PrintInfo();
            student.PrintInfo();
            var teacher = new Teacher("Physic", "Simas", 36);
            teacher.PrintInfo();
        }
    }
}