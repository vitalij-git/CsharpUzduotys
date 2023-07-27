using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genereic3.Models
{
    internal class Generic
    {
        public Generic(List<string> readOnly)
        {
            ReadOnly = readOnly;
        }

        public List<string> ReadOnly { get; init; }

        public void ShowList()
        {
            foreach (var item in ReadOnly)
            {
                Console.WriteLine(item);
            }
        }
        public Array[] NewArray()
        {
            return ReadOnly.ToArray();   
        }




    }
}
