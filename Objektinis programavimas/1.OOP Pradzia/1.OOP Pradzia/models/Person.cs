using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OOP_Pradzia.models
{
    internal class Person
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public Person(string name, int age, double height)
        {
            Name = name;
            Age = age;
            Height = height;
        }


        public string Name { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }    

        public void ShowPerson()
        {
            Console.WriteLine($"Name is {Name} Age is {Age}");
        }

        public void ShowPersonWithHeight()
        {
            Console.WriteLine($"Name is {Name} Age is {Age} Height is {Height} m.");
        }
    }
}
