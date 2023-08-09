﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._YieldAndIEnumerable.Models
{
    internal class Person
    {
        public Person()
        {
            
        }
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }
}
