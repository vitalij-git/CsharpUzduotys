using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Abstrakcijos.models
{
    internal class Bus : Vehicle
    {
        public Bus() { }
        public Bus(int seatingAreas)
        {
            SeatingAreas = seatingAreas;
        }

        public Bus(int speed, double weight, double friction) : this(speed)
        {
            Weight = weight;
            Friction = friction;
        }

        public int SeatingAreas { get; set; }
        public override int Speed { get; set; }
        public override double Weight { get; set; }
        public override double Friction { get; set; }

        public override double BrakingDistance()
        {
            return (Weight * Math.Pow(Speed, 2)) / (2 * Friction);
        }
    }
}
