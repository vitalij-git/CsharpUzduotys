using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Abstrakcijos.models
{
    internal abstract class Vehicle
    {
        public abstract int Speed { get; set; }
        public abstract double Weight{ get; set; }
        public abstract double Friction { get; set; }
        public abstract double BrakingDistance();
    }
}
