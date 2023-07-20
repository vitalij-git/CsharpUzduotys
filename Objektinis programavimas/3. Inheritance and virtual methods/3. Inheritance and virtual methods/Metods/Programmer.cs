using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Inheritance_and_virtual_methods.Metods
{
    internal class Programmer : Employee
    {
        public Programmer()
        {

        }

        public Programmer(string name, double salary) 
        {
            
            Name=name;
            Salary=salary;
        }

        public string ProgramingLanguage{ get; set; }

        public void ProgrammerOutput()
        {
            Console.WriteLine($"Programmer name: {Name}\nProgrammer salary: {Salary}\nProgrammer language: {ProgramingLanguage}");
        }
    }
}
