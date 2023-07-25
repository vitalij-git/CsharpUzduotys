using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._Generics.Models
{
    static class Validation
    {
       public static bool Validate<T>(T input)
        {
            if (typeof(T) == typeof(string))
            {
                return !string.IsNullOrEmpty(input as string);
            }
            else
            {
                if (input != null)
                {
                    return !string.IsNullOrEmpty(input.ToString() as string);
                }      
            }
            return false;
        }

        public static void ShowValue<T1,T2>(T1 input1, T2 input2)
        {
            Console.WriteLine($"{input1} type is {input1.GetType().Name} and {input2} type is {input2.GetType().Name}");
        }
        
    }
}
