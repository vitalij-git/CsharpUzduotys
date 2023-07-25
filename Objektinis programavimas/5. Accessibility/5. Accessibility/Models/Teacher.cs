using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Accessibility.Models
{
    internal class Teacher : Person
    {

        private string _subject;

        public Teacher()
        {
        }

        public Teacher(string subject, string name, int age)
        {
            Subject = subject;
            Name = name;
            Age = age;
        }

        public string Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        internal protected override void PrintInfo()
        {
            Console.WriteLine($"Subject is {Subject} Name is {Name} and age is {Age}");
        }
        public string GetSubject()
        { 
            return Subject;
        }
    }
}
