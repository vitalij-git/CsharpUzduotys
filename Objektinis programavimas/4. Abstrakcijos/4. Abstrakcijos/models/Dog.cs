using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Abstrakcijos.models
{
    internal class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Wooof wooof!!");
        }
    }
}
