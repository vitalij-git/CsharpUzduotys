namespace _15.Random
{
    using System;
    using System.Runtime;
    using System.Runtime.CompilerServices;
    using System.Globalization;
    using System.Diagnostics.Contracts;

    internal class Program
    {
        static Random random =new Random();
        static void Main(string[] args)
        {
            //Random random = new Random();
            // RandomNumbers1_10(random);
            //RandomBoolean(random);
            //RandomChar(random);
            //RandomPassword(random);
            //GenSum(random);
            RandomNumberGame(random);
            Console.ReadKey();
        }

        static void RandomNumbers1_10(Random random)
        {
            int numberGen= random.Next(0, 11);
            Console.WriteLine(numberGen);
        }

        static void RandomBoolean(Random random)
        {
            bool randomBool = random.Next(2) == 1;
            Console.WriteLine(randomBool);
        }

        static char RandomChar(Random random)
        {
            int num = random.Next(0, 26); // Zero to 25
            char let = (char)('a' + num);
            return let;
        }

        static void RandomPassword(Random random)
        {
            for(int i = 0;i < 10; i++)
            {
                Console.Write(RandomChar(random));
            }
        }

        static void GenSum(Random random)
        {
            int randomSum = 0;
            for(int i = 0; i <= 100; i++)
            {
                int random1_6 = random.Next(7);
                Console.Write(random1_6 + ",");
                randomSum += random1_6;
            }
            Console.WriteLine("\n" + randomSum);
        }

        static void RandomNumberGame(Random random)
        {
            int random1_100 = random.Next(101);
            Console.WriteLine("Spekite paslepta skaiciu nuo 1 iki 100");
            while (true)
            {   
                int userTry = int.Parse(Console.ReadLine());
                if (userTry == random1_100 )
                {
                    Console.WriteLine("Sveikinome jus spejote paslepta skaiciu, kuris buvo " + random1_100);
                    
                }
                else if (userTry > random1_100)
                {
                    Console.WriteLine("Pasleptas skaicus yra mazesnis");
                    continue;
                }
                else if (userTry < random1_100)
                {
                    Console.WriteLine("Pasleptas skaicus yra didesnis");
                    continue;
                }
                else
                {
                    Console.WriteLine("Ivyko klaida, bandykite dar karta");
                    continue;
                }
            }
        }
    }
}