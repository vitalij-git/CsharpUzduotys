using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods.Metods
{
    internal class Circle
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public double CircleArea()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
