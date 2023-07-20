using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Abstrakcijos.models
{
    internal class Square : GeometricShape
    {
        public Square(double height, double width) : base(height, width)
        {
        }

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
