using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringList();
            //IntList();

        }

        // pirmos skaidres 1 uzduotys grazina sarasa su elemento ilgi ir papildomai elementu ilgio vidurki
        static void StringList()
        {
            List<string> userList = GetStringListFromInput();
            foreach (string item in userList)
            {
                Console.WriteLine($"Zodis is saraso: {item} ilgis: {item.Length}");
            }
            int userListElementsAverage = ListLengthAverage(userList);
            Console.WriteLine($"Saraso elementu vidurkis: {userListElementsAverage}");
        }

        //Metodas kuris priima string nuo inputo
        static List<string> GetStringListFromInput()
        {
            List<string> listFromInput = new List<string>();
            Console.WriteLine("Sarasas:");
            bool whileStatus = true;
            while (whileStatus)
            {
                Console.WriteLine("Iveskite norima zodi, kuris prides i sarasa");
                listFromInput.Add(Console.ReadLine());
                Console.WriteLine("Ar noresite dar papilditi sarasa?(taip/ne)");
                var userChoose = Console.ReadLine();
                if (userChoose == "taip")
                {
                    continue;
                }
                whileStatus = false;
            }
            return listFromInput;
        }

        // Metodas kuris apskaiciuoja string ilgi vidurki
        static int ListLengthAverage(List<string> userList)
        {
            int sum = 0;
            int length = 0;
            foreach (var item in userList)
            {
                sum += item.Count();
                length++;
            }
            return sum / length;

        }
        static void IntList()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Skaiciu sarasas: ");
            List<int> userIntList = GetIntListFromInput();
            foreach (var item in userIntList)
            {
                sb.Append(item + ",");
            }
            string result = sb.ToString().Remove(sb.ToString().LastIndexOf(','));
            Console.WriteLine(result);
            Console.WriteLine("Saraso skaiciu vidurkis yra: " + IntListAverage(userIntList));
            string result2 = UserNumberWhichMoreTen(userIntList);
            Console.WriteLine(result2);
        }
        //Metodas kur priima sveikosius skaicius nuo inputo
        static List<int> GetIntListFromInput()
        {
            List<int> intListFromInput = new List<int>();
            string userAnswerFromInput = "";
            while (true)
            {
                Console.WriteLine("Ivesikte norima sveikaji skaicu, kuris prides i sarasa");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    intListFromInput.Add(number);
                    Console.WriteLine($"Jusu skaicius {number}, sekmingai pridetas i sarasa");
                    Console.WriteLine("Norite dar prideti skaiciu?(taip/ne)");
                    userAnswerFromInput = Console.ReadLine().ToLower().Trim();
                    if (userAnswerFromInput == "taip")
                    {
                        continue;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("Ivestas blogas skaicius");
                    Console.WriteLine("Norite dar karta pabandyti?(taip/ne)");
                    userAnswerFromInput = Console.ReadLine().ToLower().Trim();
                    if (userAnswerFromInput == "taip")
                    {
                        continue;
                    }
                    break;
                }
            }
            return intListFromInput;

        }
        // Pirmos skaidres 2 uzuodotys grazina saraso elemento vidurki
        static int IntListAverage(List<int> intList)
        {
            int sum = 0;
            foreach (int item in intList)
            {
                sum += item;
            }
            return sum / intList.Count();
        }

        //Pirmos skaidres 3 Uzd metodas kuris grazina elementus kurie didesni uz 10
        static string UserNumberWhichMoreTen(List<int> userIntList)
        {
            StringBuilder numberMore10 = new StringBuilder();
            numberMore10.Append("Skaiciu sarasas, kurie daugiau uz 10: ");
            foreach (var item in userIntList)
            {
                if (item > 10)
                {
                    numberMore10.Append(item + ",");
                }
            }
            if (numberMore10.ToString().Length > 38)
            {
                string numberMoreTenResult = numberMore10.ToString().Remove(numberMore10.ToString().LastIndexOf(','));
                return numberMoreTenResult;
            }
            return "Sarase nera skaiciu, kurie didesni uz 10";
        }
    }
}