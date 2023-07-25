using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Generics.Models
{
    internal abstract class FourSideGeometricFigure
    {
        public string Name { get; set; }
        public double Base { get; set; }
        public double Height { get; set; }

        public abstract void GetArea();
    }
}
