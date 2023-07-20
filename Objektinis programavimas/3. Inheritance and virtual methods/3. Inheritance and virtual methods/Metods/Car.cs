using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._Inheritance_and_virtual_methods.Metods
{
    internal class Car : Vehicle
    {
        public Car() {

        }    
        public Car(int speed) : base(speed)
        {
            Speed = speed;
        }
    }
}
