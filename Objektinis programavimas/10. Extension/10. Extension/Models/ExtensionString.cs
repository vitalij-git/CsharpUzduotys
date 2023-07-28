using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Extension.Models
{
   public static class ExtensionString
    {
        public static bool CheckSpaceInString(this string str)
        {
            if(str.Contains(" ")) return true; return false;
        }

        public static string BuildEmail(this string fullname, string yearOfBirth, string domain)
        {
            return fullname + yearOfBirth + domain;
        }
    }
}
