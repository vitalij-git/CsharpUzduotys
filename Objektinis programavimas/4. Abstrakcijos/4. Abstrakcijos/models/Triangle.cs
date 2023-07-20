﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Abstrakcijos.models
{
    internal class Triangle : GeometricShape
    {
        

        public Triangle(double height, double width, double rightSide, double leftSide) : base(height, width)
        {
            RightSide = rightSide;
            LeftSide = leftSide;
        }

        public double RightSide { get; set; }
        public double LeftSide { get; set; }
        public override double GetArea()
        {
            return Height * Width/2;
        }
        public override double GetPerimeter()
        {
            return Width + RightSide + LeftSide;
        }
    }
}
