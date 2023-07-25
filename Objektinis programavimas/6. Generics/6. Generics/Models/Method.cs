using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Generics.Models
{
    internal class Method<T1,T2>
    {
        public Method()
        {
        }

        public Method(T1 firstValue, T2 secondValue)
        {
            FirstValue = firstValue;
            SecondValue = secondValue;
        }

        public T1 FirstValue { get; set; }
        public T2 SecondValue { get; set;}

        public void ShowFirstValue()
        {
            Console.WriteLine(FirstValue);
        }

        public void ShowSecondValue()
        {
            Console.WriteLine(SecondValue);
        }

        public void UpdateFirstValue(T1 value)
        {
            FirstValue = value;
        }

        public void UpdateSecondValue(T2 value)
        {
            SecondValue = value;
        }
    }
}
