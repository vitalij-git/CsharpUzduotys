using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Extension.Models
{
    public static class ExtensionInteger
    {
        public static bool PositiveOrNegativeInteger(this int value)
        {
            if (value>0) return true; return false;
        }

        public static bool CheckEvenInteger(this int value)
        {
            if (value%2==0) return true; return false;
        }

        public static bool ComparisonOfNumbers(this int firstInteger, int secondInteger)
        {
            if(firstInteger>secondInteger) return true; return false;
        }


    }
}
