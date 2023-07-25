using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Accessibility.Models
{
    internal class Student : Person
    {
        public Student() { }

        public Student(int studentId) 
        {
            StudentId = studentId;
        }
        public Student(int studentId,string name,int age)
        {
            StudentId = studentId;
            Name = name;
            Age = age;
        }
        private int _studendId;

        public int StudentId
        {
            get { return _studendId; }
           private set { _studendId = value; }
        }
       
        internal protected override void PrintInfo()
        {
            Console.WriteLine($"Student ID is {StudentId} student name is {Name} student age is {Age}");
            
        }
        public int GetStudentId()
        {
            return StudentId;
        }
    }
}
