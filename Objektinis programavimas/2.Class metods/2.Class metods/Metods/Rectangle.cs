using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods.Metods
{
    internal class Rectangle
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public Rectangle(int x, int y)
        {
            this.Height = x;
            this.Width = y;
        }
        public int RectangleArea()
        {
            return Height * Width;
        }
    }
}
