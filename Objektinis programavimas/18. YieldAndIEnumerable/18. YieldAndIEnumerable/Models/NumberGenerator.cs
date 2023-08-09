using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._YieldAndIEnumerable.Models
{
    internal class NumberGenerator : IEnumerable<int>
    {
        public NumberGenerator() { }

        public NumberGenerator(int startOfNumber, int endOfNumber)
        {
            StartOfNumber = startOfNumber;
            EndOfNumber = endOfNumber;
        }

        public int StartOfNumber { get; set; }
        public int EndOfNumber { get; set;}

        public IEnumerator<int> GetEnumerator()
        {
           for(int i = StartOfNumber;i<= EndOfNumber;i++)
            {
                yield return i;
            }
                
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
