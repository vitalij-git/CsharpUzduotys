using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods.Metods
{
    internal class ListOfNumbers
    {
        public List<int> Numbers { get; set; }

        public ListOfNumbers(List<int> numbers)
        {
            this.Numbers = numbers;
            
            
        }

        public List<int> AddNumberToList(int number)
        {
            Numbers.Add(number);
            return Numbers;
        }

        public void PrintNumbers()
        {
            foreach (int number in Numbers)
            {
                Console.Write(number + " ");
            }
        }
    }



}
