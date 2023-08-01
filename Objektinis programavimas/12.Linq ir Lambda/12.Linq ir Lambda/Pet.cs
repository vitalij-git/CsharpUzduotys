using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Linq_ir_Lambda
{
    internal class Pet
    {
        public Pet(string name,int age)
        {
            Name = name;
            Age= age;
        }

        public string Name { get; set; }
        public int Age { get; set; }
    }
}
