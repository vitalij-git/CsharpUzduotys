using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods.Metods
{
    internal class Circle
    {
        public double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double CircleArea()
        {
            return radius * radius * Math.PI;
        }
    }
}
