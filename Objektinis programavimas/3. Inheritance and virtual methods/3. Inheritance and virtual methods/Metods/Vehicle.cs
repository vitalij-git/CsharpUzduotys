using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Inheritance_and_virtual_methods.Metods
{
    internal class Vehicle
    {
        public Vehicle()
        {
        }

        public Vehicle(int speed)
        {
            Speed = speed;
        }
        public int Speed { get; set; }
    }
}
