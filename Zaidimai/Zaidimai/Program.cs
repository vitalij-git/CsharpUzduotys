namespace Zaidimai
{
    using System;
    internal class Program
    {   static Random random = new Random();    
        static void Main(string[] args)
        {
            DiceMeniu();
        }
        static void DiceMeniu()
        {
            Console.WriteLine("Kiauliuku zaidimas. Spauskite enter kad pradeti zaisti pries bota");
            ConsoleKeyInfo info = Console.ReadKey();
            while (true)
            {
                if (ConsoleKey.Enter == info.Key)
                {
                    DiceGame();
                }
                Console.WriteLine("Norite pabandyti dar? Spauskite Enter jei norite suzaisti dar arba Escape jei norite iseiti");
                 info = Console.ReadKey();
                if (ConsoleKey.Enter == info.Key)
                {
                    continue;
                }
                else if (ConsoleKey.Escape == info.Key)
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("\nIvyko klaida, badykite dar karta");
                    continue;
                }
            }
            //Console.ReadKey();
        }
        static void DiceGame()
        {
            int botDiceRoll = random.Next(7);
            int yourDiceRoll = random.Next(7);
            if (botDiceRoll > yourDiceRoll) 
            {
                Console.WriteLine($"Jusu metimas: {yourDiceRoll} boto metimas: {botDiceRoll} pralaimejote");
            }
            else if (botDiceRoll <yourDiceRoll)
            {
                Console.WriteLine($"Jusu metimas: {yourDiceRoll} boto metimas: {botDiceRoll} laimejote");
            }
            else if (botDiceRoll == yourDiceRoll)
            {
                Console.WriteLine($"Jusu metimas: {yourDiceRoll} boto metimas: {botDiceRoll} lygiosos");
            }
        }
    }
}