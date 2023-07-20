using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Abstrakcijos.models
{
    internal abstract class GeometricShape
    {
        public GeometricShape(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }  
        public double Width { get; set; }

        public abstract double GetPerimeter();

        public abstract double GetArea();
      
    }
}
