using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntList();

        }

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
        static int ListLengthAverage(List<string> userList)
        {   
            int sum= 0;
            int length = 0;
            foreach (var item in userList)
            {
                sum += userList.Count();
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
                Console.WriteLine(numberMoreTenResult);
            }
            else
            {
                Console.WriteLine("Sarase nera skaiciu, kurie didesni uz 10");
            }
            

        }
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
        
        static int IntListAverage(List<int> intList)
        {
            int sum = 0;
            int length = 0;
            foreach (int item in intList)
            {
                sum += item;
                length++;
            }
            return sum / length;
        }


        
    }
}