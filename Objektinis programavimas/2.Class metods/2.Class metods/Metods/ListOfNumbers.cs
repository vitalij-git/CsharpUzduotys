using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods.Metods
{
    internal class ListOfNumbers
    {
        public List<int> numbers { get; set; }

        public ListOfNumbers(List<int> numbers)
        {
            this.numbers = numbers;
            
            
        }

        public List<int> AddNumberToList(int number)
        {
            numbers.Add(number);
            return numbers;
        }

        public void PrintNumbers()
        {
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }
    }



}
