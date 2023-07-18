using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods.Metods
{
    internal class Rectangle
    {
        public int x { get; set; }
        public int y { get; set; }
        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public int RectangleArea()
        {
            return x * y;
        }
    }
}
