using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Abstrakcijos.models
{
    internal class Square : GeometricShape
    {
        public Square(double height, double width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }
        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            
            return Width * 2 + Height * 2;
        }
    }
}
