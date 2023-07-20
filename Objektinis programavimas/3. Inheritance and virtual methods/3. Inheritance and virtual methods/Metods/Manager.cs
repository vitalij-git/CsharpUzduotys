using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Inheritance_and_virtual_methods.Metods
{
    internal class Manager : Employee
    {
        public Manager() 
        { 

        }

        public Manager(List<Employee> employees)
        {
            Employees = employees;
        }

        public List<Employee> Employees { get; set; }
        public void OutputEmployees()
        {
            foreach (var employee in Employees) 
            {
                Console.WriteLine($"{employee.Name} {employee.Salary}");
            }
        }
    }
}
