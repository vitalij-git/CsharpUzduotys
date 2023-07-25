using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._Accessibility.Models
{
    internal class BankAccount
    {
        private double Balance { get; set; }

        protected void PrintBalance()
        {
            Console.WriteLine($"your balance is {Balance}");
        }
    }

  
}
