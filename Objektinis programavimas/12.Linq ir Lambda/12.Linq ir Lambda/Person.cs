using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Linq_ir_Lambda
{
    internal class Person
    {
        public Person(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public int Age { get; set; }
        public string Name { get; set; }
    }
    
}
