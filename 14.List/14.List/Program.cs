using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14._List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StringList();
            //IntList();
            //ASCII();
            //Factorial();
            Prime();

        
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

        // Metodas kuris apskaiciuoja string ilgiu vidurki
        static int ListLengthAverage(List<string> userList)
        {
            int sum = 0;
            foreach (var item in userList)
            {
                sum += item.Count();
                
            }
            return sum / userList.Count();

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

        //ASCII uzduotys
        static void ASCII()
        {
            List<string> userList = GetStringListFromInput();
            List<string> evenAsciiList = AsciiBytesSum(userList);
            if (evenAsciiList.Count()>0)
            foreach (string item in evenAsciiList)
            {
                Console.WriteLine(item);
            }
            else { Console.WriteLine("nera zodzio, kurių raidžių suma yra lyginis skaičius"); }
           
        }

        //Grazina ASCII  zodziu lygine suma
        static List<string> AsciiBytesSum(List<string> userList)
        {
            List<string> evenAsciiList = new List<string>();
            foreach (string item in userList)
            {
                byte[] asciiBytes = Encoding.ASCII.GetBytes(item);
                int asciiSum = 0;
                foreach (byte b in asciiBytes)
                {
                    asciiSum += b;
                }
                if (asciiSum % 2 == 0)
                {
                    evenAsciiList.Add(item);
                }
            }
            return evenAsciiList;
        }
       
        //Faktorialas
        static void Factorial()
        {
           List<int> userInt = GetIntListFromInput();
           List<int> FactorialList = new List<int>();
            int count = 0;
            foreach (int item in userInt)
            {
                int factorialMultiplyResult = FactorialMultiply(item);
                FactorialList.Add(factorialMultiplyResult);  
            }
            if (FactorialList.Count() > 0)
            {
                foreach (var item in userInt)
                {   
                    Console.Write($"Faktorialas skaiciaus {item} yra ");
                    for (int i = count; i < FactorialList.Count; i++) 
                    {
                        Console.WriteLine(FactorialList[i]);
                        break;
                    }
                    count++;
                }
            }

        }

        //Skaiciuoja faktoriala
        static int FactorialMultiply(int number)
        {
            int factorialMuliply = 1;
            for (int i = 1; i <= number; i++)
            {
                factorialMuliply *= i;
            }
            return factorialMuliply;
        }

        //ASCII kodo pirmine skaiciu suma
        static void Prime()
        {
            List<string> userList = GetStringListFromInput();
            List<string> primeAsciiList =AsciiBytesPrimeSum(userList);
            if(primeAsciiList.Count > 0)
            {
                foreach (var item in primeAsciiList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("Nerado pirminiu skaiciu");
            }
        }

        //Skaiciuoja ASCII
        static List<string> AsciiBytesPrimeSum(List<string> userList)
        {
            List<string> primeAsciiList = new List<string>();
            foreach (string item in userList)
            {
                byte[] asciiBytes = Encoding.ASCII.GetBytes(item);
                int asciiSum = 0;
                foreach (byte b in asciiBytes)
                {
                    asciiSum += b;
                }
                if (CheckIsPrime(asciiSum)  == true)
                {
                    primeAsciiList.Add(item);
                }
            }
            return primeAsciiList;
        }


        //Tikrina ar pirminis 
        static bool CheckIsPrime(int checkOfPrimeNumber)
        {
            for (int i = 2;i < checkOfPrimeNumber; i++)
            {
                if (checkOfPrimeNumber % i == 0)
                {
                    return false;
                }
                if (checkOfPrimeNumber % i != 0)
                {
                    continue;
                }

            }
            return true;
        }
    }
}