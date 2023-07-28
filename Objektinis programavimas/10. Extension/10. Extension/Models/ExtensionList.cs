using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._Extension.Models
{
    internal static class ExtensionList
    {
        public static T FindAndReturnIfEqualList<T>(this List<T> checkList, T str )
        { 
            return checkList.Contains(str)? str : default;
        }

        public static List<T> EveryOrherWordList<T>( this List<T> list)
        {
            var newList = new List<T>();
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    newList.Add(list[i]);
                }
            }
            return newList;
        }

    }
}
