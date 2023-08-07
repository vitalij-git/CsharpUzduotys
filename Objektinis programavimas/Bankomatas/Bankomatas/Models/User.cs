using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas.Models
{
    internal  class User
    {
        public User(int pin, int cardID, double amountOfMoney)
        {
            Pin = pin;
            CardID = cardID;
            AmountOfMoney = amountOfMoney;
        }

        private int Pin { get; set; }
        private int CardID { get; set; }
        private double AmountOfMoney { get; set; }

        public bool CheckPin(int pin)
        {
            if (Pin == pin) return true;
            return false;
        }
        public bool UpdatePin(int pin)
        {
            if (Pin == pin)
            {
                Console.WriteLine("Iveskite nauja pin koda");
                var newPin = Console.ReadLine();
                if (int.TryParse(newPin, out int checkedPin))
                {
                    Pin = checkedPin;
                    return true;
                }
                return false;
            }
            return false;
        }
        public double AMoneyBalance()
        {
            return AmountOfMoney;
        }

        public bool Withdrawal(int chasSum)
        {
            if (chasSum < AmountOfMoney)
            {
                AmountOfMoney -= chasSum;
                return true;
            }
            return false;
        }
        
        public void DepositMoney(int money)
        {
             AmountOfMoney += money;
            Console.WriteLine($"Sekmingai pridejote pinigus");
        }
    }
}
