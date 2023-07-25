using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Generics.Models
{
    internal class Type<T1,T2>
    {
        public void GetTypeOfFirstInput()
        {
            Console.WriteLine(typeof(T1));
        }

        public void GetTypeOfSecondInput()
        {
            Console.WriteLine(typeof(T2));
        }
    }
}
