using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Generics.Models
{
    internal  class FourSideGeometricFigure
    {
        public FourSideGeometricFigure(string name, double width, double height)
        {
            Name = name;
            Width = width;
            Height = height;
        }

        public string Name { get; set; }
        public double Width { get; set; }
        public double Height { get; set; }

        public  double GetArea()
        {
            return Width * Height;
        }

        public override string ToString()
        {
            return $"{Name} area is {GetArea()}";
        }
    }
}
