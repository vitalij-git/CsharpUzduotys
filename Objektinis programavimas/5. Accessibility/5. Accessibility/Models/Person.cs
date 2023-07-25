using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Accessibility.Models
{
    internal class Person
    {
        public Person() { }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        private string _name;

        protected string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _age;

        protected int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        internal protected virtual void PrintInfo()
        {
            Console.WriteLine($"Name is {Name} and age is {Age}");
        }
    }
}
