using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._Abstrakcijos.models
{
    internal class Cat : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
