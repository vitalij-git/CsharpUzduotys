﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods
{
    internal class Human
    {
        public string FirstName { get; set; }
        public string LastName{ get; set; }
        public int Age { get; set; }

        public Human(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public string GetFullName()
        {
            return FirstName + " " + LastName; ;
        }
    }
}
