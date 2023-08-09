using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._YieldAndIEnumerable.Models
{
    internal class StringPrinter : IEnumerable<string>
    {
        public StringPrinter() { }  
        public StringPrinter(List<string> lines)
        {
            Lines = lines;
        }

       private List<string> Lines { get; set; } = new List<string>();

        public void AddLine(string line)
        {
            Lines.Add(line);
        }
        public IEnumerator<string> GetEnumerator()
        {
            foreach (string line in Lines)
            {
                yield return line;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
           return Lines.GetEnumerator();
        }
    }
}
