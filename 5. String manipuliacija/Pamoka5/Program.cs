using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Pamoka5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringMethod();
            //TaskNr2();
            //TaskNr3();
            //TaskNr3_1();
            //userAge();
            Subway();
        }
        static void Task1()
        {
            Console.WriteLine("Iveskite zodi");
            string zodis = Console.ReadLine();
            char[] masyvas = zodis.ToCharArray();
            masyvas[0] = char.ToUpper(masyvas[0]);
            Console.WriteLine(masyvas);

            ///
            Console.WriteLine("Iveskite zodi");
            char[] charMasyvas = Console.ReadLine().ToCharArray();
            Console.WriteLine(charMasyvas);
            charMasyvas[2] = 'g';
            charMasyvas[4] = 'b';
            charMasyvas[6] = '*';
            charMasyvas[8] = 'x';
            charMasyvas[10] = 'w';
            Console.WriteLine(charMasyvas);
            //
            

        }
        static void Task2()
        {
            Console.WriteLine("Iveskite  zodi");
            string input = Console.ReadLine(); 

            if(input.Length != 5)
            {
                Console.WriteLine("Ivestis privalo buti 5 simboliu");
                return;
            }
             int codeValue =int.Parse(Console.ReadLine());
             //input[0] += (int)(codeValue);


        }
        static void StringMethod()
        {
            double numberForFormating = 26541.125222;
            Console.WriteLine(numberForFormating.ToString("0.00"));

            string v1 = null;
            string v2 = "54554";
            string v3 = "1211.2";
            string v4 = "5151,52";
            string v5 = "-45511";
            string v6 = "+667511";
            string v7 = "(100)";
            string v8 = "02FE";
            string v9= "0x01FA";
            string v10 = "001";

            bool success1 = int.TryParse(v1, out int number1);
            Console.WriteLine(success1);
            bool success2 = int.TryParse(v2, out int _);
            Console.WriteLine(success2);

        }
        static void TaskNr2()
        {   //1
            Console.Write("Parasykite sakini: ");
            var sakinis = Console.ReadLine();
            sakinis = sakinis.Replace("a", "uo");
            sakinis = sakinis.Replace("i", "e");
            Console.WriteLine(sakinis);
            //    //2
            Console.WriteLine("Parasykite teksta");
            var eilerastis = Console.ReadLine();
            Console.WriteLine(eilerastis);
            Console.WriteLine("parasykite koki zodi noretume pakeisti?");
            var oldWord = Console.ReadLine();
            if (eilerastis.Contains(oldWord))
            {
                Console.WriteLine("Parasykite nauja zodi kuris pasikeis vietoje seno");
                var newWord = Console.ReadLine();
                eilerastis = eilerastis.Replace(oldWord, newWord);
                Console.WriteLine(eilerastis);
            }
            else
            {
                Console.WriteLine("Parasete blogai sena zodi arba tokio zodzio tekste nera");
            }
           
        }
        static void userAge()
        {
            Console.WriteLine("Kiek jums metu?");
            int userInputAge = int.Parse(Console.ReadLine());
            calculatorUserAge(userInputAge);
            Console.WriteLine($"Iki 90 metu jums liko: {calculatorUserAge(userInputAge)}");
        }
        static string calculatorUserAge(int userInputAge)
        {
            int userAgeMax = 90;
            int userAgeYearsLeft = userAgeMax - userInputAge;
            int userAgeMonthsLeft = userAgeYearsLeft * 12;
            int userAgeWeeksLeft = userAgeYearsLeft * 52;
            int userAgeDaysLeft = userAgeYearsLeft * 365;
            string result = userAgeYearsLeft + " metu " + userAgeMonthsLeft + " menesiu " + userAgeWeeksLeft + " savaiciu " + userAgeDaysLeft + " dienu";
            return result;
        }
        static void TaskNr3()
        {
            Console.WriteLine("Parasykite zodi:");
            var word = Console.ReadLine(); 
            if (char.IsUpper(word, 0))
            {
                word = word.ToUpper();
                Console.WriteLine(word);
            }
            else
            {
                word = char.ToUpper(word[0])+word.Substring(1);
                Console.WriteLine(word);
            }
        }
        static void TaskNr3_1() {
            Console.WriteLine("Parasykite zodi");
            var wordOfIndex = Console.ReadLine();
            if (wordOfIndex.Contains("a"))
            {
                var indexA = wordOfIndex.IndexOf("a");
                Console.WriteLine($"Jusu zodis: {wordOfIndex} indekso a vieta yra: {indexA} ");
            }
            else
            {
                Console.WriteLine("Simbolis 'a' nerasta");
            }

        }
        static void TaskNr3_2()
        {
            Console.WriteLine("Parasykite zodi");
            var wordOfReverse = Console.ReadLine();
            wordOfReverse = wordOfReverse.ToLower().Trim();
            if(wordOfReverse == "labas")
            {
                var newWordOfReverse = wordOfReverse.Reverse();
                Console.WriteLine();
            }
        }
        static void Subway()
        {
            Console.WriteLine("Meniu:\n1 - Tamsi duona\n2 - Sviesi duona\n3 - Batonas");
            int bread = int.Parse(Console.ReadLine());
            double breadPrice = 0;
            double endPrice = 0;
            switch (bread)
            {
                case 1:
                    breadPrice += 1;
                    break;
                case 2:
                    breadPrice += 0.9;
                    break;
                case 3:
                    breadPrice += 0.6;
                    break;
                default:
                    Console.WriteLine("Something wrong.. try again");
                    Subway();
                    break;
            }
            endPrice += breadPrice;
            double soucePrice = 0;
            endPrice += Souce(soucePrice);
            double ingredientPrice = 0;
            endPrice += Ingredient(ingredientPrice); ;
            Console.WriteLine("Ar norite papilditi dar ingrendientu?");
            var ingrendientAnsver = Console.ReadLine().ToLower().Trim();
            if (ingrendientAnsver == "taip")
            {
                endPrice+=Ingredient(ingredientPrice);
            }
            else
            {
                Console.WriteLine("Galutine kaina: " + endPrice + " Eur.");
            }
            

        }
        static double Ingredient(double ingredientPrice)
        {   
            Console.WriteLine("Pagrindinis ingrendientas:\n1 - Saliami\n2 - Bekonas\n3 - Fetos sūris \n4 - Macarelo sūris\n5 - Pomidoras\n6 - Agurkas\n7 -  parmezanas");
            int sandwichIngredient = int.Parse(Console.ReadLine());
            switch (sandwichIngredient)
            {
                case 1: ingredientPrice += 0.7; break;
                case 2: ingredientPrice += 0.9; break;
                case 3: ingredientPrice += 1.2; break;
                case 4: ingredientPrice += 0.8; break;
                case 5: ingredientPrice += 0.25; break;
                case 6: ingredientPrice += 0.2; break;
                case 7: ingredientPrice += 1.3; break;
                default:
                    Console.WriteLine("Something wrong.. try again");
                    Ingredient(ingredientPrice);
                    break;
            }
            return ingredientPrice;
        }
        static double Souce(double soucePrice)
        {
            Console.WriteLine("Ar noresite sutepti duona?");
            var souceAnswer = Console.ReadLine().ToLower().Trim();
            if (souceAnswer == "taip")
            {
                Console.WriteLine("1 - Sviestas\n2 - padažas");
                int breadSouce = int.Parse(Console.ReadLine());
                switch (breadSouce)
                {
                    case 1:
                        soucePrice += 0.2; break;
                    case 2:
                        soucePrice += 0.4; break;
                    default:
                        Console.WriteLine("Something wrong.. try again");
                        Souce(soucePrice);
                        break;
                }
            }
            return soucePrice;     
        }
        static void TaskNr5()
        {
            Console.WriteLine("Iveskite telefono numeri su kodu");
            var phoneNumber = Console.ReadLine();
            if (phoneNumber.StartsWith("+370"))
            {
                Console.Write("tai yra lietuvos telefono numeris");
            }
        }
    }
}
