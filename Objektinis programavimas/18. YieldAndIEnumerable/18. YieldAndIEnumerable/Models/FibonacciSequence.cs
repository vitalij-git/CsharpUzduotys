using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._YieldAndIEnumerable.Models
{
    internal class FibonacciSequence : IEnumerable<int>
    {
        public FibonacciSequence() { }

        public FibonacciSequence(int number)
        {
           Number = number;

        }
        public int Number { get; set; }

        public IEnumerator<int> GetEnumerator()
        {
            int result = 0;
            int previous = 1;
            for (int i = 0; i <= Number; i+=result)
            {
                int temp = result;
                result = previous;
                previous += temp;
                yield return result;
                
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
