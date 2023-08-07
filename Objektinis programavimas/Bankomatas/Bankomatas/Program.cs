using Bankomatas.Models;

namespace Bankomatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var user = new User(1234, 1, 1000);
            if (CheckUserPin(user) == true)
            {
                MenuChoise(user);
            }
        }

        static bool CheckUserPin(User user)
        {
            var quantity = 0;
            while (quantity<3)
            {
                Console.WriteLine("Iveskite pin koda:");
                var userPin = Console.ReadLine();
                if (int.TryParse(userPin, out int userPinChecked))
                {
                    if (user.CheckPin(userPinChecked) == true)
                    {
                        return true;
                    }
                    quantity++;
                    if (quantity == 3)
                    {
                        System.Environment.Exit(0);
                    }
                    Console.WriteLine($"Blogai ivestas pin kodas, bandykite dar karta" +
                        $"\njums liko {3 - quantity}");
                    continue;
                } 
            }   
            return false;
        }

        static void Menu()
        {
            Console.WriteLine("Meniu:" +
                "\n1 - Balansas" +
                "\n2 - Pinigų išsiėmimas" +
                "\n3 - Pinigų įnešimas" +
                "\n4 - Istorija" +
                "\n5 - Pin kodo keitimas" +
                "\n6 - Atsijungti ir išeiti");
        }

        static void SecondMenu()
        {
            Console.WriteLine("Pasirinkimas:" +
                "\n1 - Grįžti į menių" +
                "\n2 - Atsijungti ir išeiti");
        }

        static void SecondMenuOption(User user)
        {
            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    MenuChoise(user);
                }
                else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Error, bandykite dar karta");
                    continue;
                }
            }
        }
        static void MenuChoise(User user)
        {
            Menu();
            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.D1 || key.Key == ConsoleKey.NumPad1)
                {
                    Balance(user);
                }
                else if (key.Key == ConsoleKey.D2 || key.Key == ConsoleKey.NumPad2)
                {
                    CashWithrawal(user);
                }
                else if (key.Key == ConsoleKey.D3 || key.Key == ConsoleKey.NumPad3)
                {
                    CashDeposit(user);
                }
                else if (key.Key == ConsoleKey.D4 || key.Key == ConsoleKey.NumPad4)
                {

                }
                else if (key.Key == ConsoleKey.D5 || key.Key == ConsoleKey.NumPad5)
                {
                    PinChange(user);
                }
                else if (key.Key == ConsoleKey.D6 || key.Key == ConsoleKey.NumPad6)
                {
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Error, bandykite dar karta");
                    continue;
                }
            }
        }

        static void Balance(User user)
        {
            Console.WriteLine($"\nBalanas...........................{user.AMoneyBalance()}");
            SecondMenu();
            SecondMenuOption(user);
        }

        static void PinChange(User user)
        {
            Console.WriteLine("Iveskite sena pin koda");
            var userPin = Console.ReadLine();
            if (int.TryParse(userPin, out int userPinChecked))
            {
                if (user.CheckPin(userPinChecked) == true) 
                {
                    if (user.UpdatePin(userPinChecked) == true)
                    {
                        Console.WriteLine("\nPin kodas sekmingai pakeistas");
                        SecondMenu();
                        SecondMenuOption(user);
                    }
                }
            }
            
        }

        static void CashWithrawal(User user)
        {
            Console.WriteLine("Parasykite norima suma:");
            var cashUserSum = Console.ReadLine();
            if (int.TryParse(cashUserSum, out int cashUserSumChecked))
            {
                if (cashUserSumChecked > 0 && cashUserSumChecked<1000) 
                {
                    if (user.Withdrawal(cashUserSumChecked) == true)
                    {
                        Console.WriteLine("Operacija Sekmingai atlikta, paimkite pinigus");
                    }
                    else
                    {
                        Console.WriteLine("Ivyko klaida");
                    }
                }
                else
                {
                    Console.WriteLine("Ivyko klaida");
                }
            }
            else
            {
                Console.WriteLine("Ivyko klaida");
            }
            SecondMenu();
            SecondMenuOption(user);
        }

        static void CashDeposit(User user)
        {
            Console.WriteLine("\nParasykite norima suma:");
            var cashUserSum = Console.ReadLine();
            if (int.TryParse(cashUserSum, out int cashUserSumChecked))
            {
                user.DepositMoney(cashUserSumChecked);
            }
            else
            {
                Console.WriteLine("Ivyko klaida");
            }
            SecondMenu();
            SecondMenuOption(user);

        }
    }
}