using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace _6._Generics.Models
{
    static class Generator<T>
    {

        public static void Show(T figure)
        {
            Console.WriteLine(figure);
        }

    }
}
