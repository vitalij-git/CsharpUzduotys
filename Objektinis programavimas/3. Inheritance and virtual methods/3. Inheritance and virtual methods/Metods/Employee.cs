using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Inheritance_and_virtual_methods.Metods
{
    internal class Employee
    {
        public Employee() 
        {

        }

        public Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; set; } 
        public double Salary { get; set; }

      
    }
}
