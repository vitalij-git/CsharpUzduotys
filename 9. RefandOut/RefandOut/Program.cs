namespace RefandOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1_1();
            //Task1_2();
            //Task1_3();
            //Task2_1();
           Task2_3();
            //Task2_2();
        }

        static void Task1_1()
        {
            int value1 = 100;
            int value2 = 20;
            Console.WriteLine(value1+" "+value2);
            Swap(ref value1, ref value2);
            Console.WriteLine(value1 + " " + value2);

        }

        static void Swap(ref int value1, ref int value2)
        {
           int temporaryValue = value1;
            value1 = value2;  
            value2 = temporaryValue;
        }

        static void Task1_2()
        {
            int primaryNumber = 50;
            Console.WriteLine(primaryNumber);
            IncrementByN(ref primaryNumber);
            Console.WriteLine(primaryNumber);
        }

        static void IncrementByN(ref int newNumber)
        {
            Console.WriteLine("suteikite nauja reiksme");
            newNumber = int.Parse(Console.ReadLine());
        }

        static void Task1_3()
        {
            string primaryText = Console.ReadLine();
            TrimAndCapitalize(ref primaryText);
            Console.WriteLine(primaryText);
        }
        
        static void TrimAndCapitalize(ref string changeText)
        {
            changeText = changeText.Trim();
            changeText = char.ToUpper(changeText[0])+changeText.Substring(1);
        }
        static void Task2_1()
        {
            GetUserData(out string userName, out string userSurname);
            Console.WriteLine(userName +" "+userSurname);
        }
        static void GetUserData(out string userName, out string userSurname)
        {
            Console.Write("Parasykite varda: ");
            userName = Console.ReadLine();
            Console.Write("Parasykite pavarde: ");
            userSurname = Console.ReadLine();
        }
        static void Task2_2()
        {
            Console.WriteLine("iveskite skaiciu");
            TryParse(out int numberFromInput, out bool tryParseConversionBool);
            Console.WriteLine($"Your number is: {numberFromInput} status: {tryParseConversionBool}");
        }
        static int TryParse(out int numberFromInput, out bool tryParseConversionBool)
        {
            numberFromInput = 0;
            tryParseConversionBool = false;
            while(!tryParseConversionBool) 
            {
                if ( !int.TryParse(Console.ReadLine(), out  numberFromInput))
                {
                    Console.WriteLine("Ivestas blogas skaicius");
                    continue;  
                }
                else if (numberFromInput < 100)
                {
                    Console.WriteLine("Ivestas skaicius mazesnis uz 100");
                    continue;
                };
                tryParseConversionBool = true;  
            };
            return numberFromInput;
        }
        static void Task2_3()
        {
            Divide(out int resultOfDivision, out double remainderOfDivision, out bool result);
            if (result == true)
            {
                Console.WriteLine($"Dalyba yra: {resultOfDivision} \nLiekana yra: {remainderOfDivision}");
            }
            else
            {
                Console.WriteLine("Jus bandote dalinti is nulio, bandykite dar karta");
                Task2_3();
            }

        }
        static bool Divide(out int resultOfDivision, out double remainderOfDivision, out bool result)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            if(secondNumber == 0)
            {
                resultOfDivision = 0;
                remainderOfDivision = 0;
                return result=false;
            }
            else
            {
                resultOfDivision = Convert.ToInt32(firstNumber / secondNumber);
                remainderOfDivision = firstNumber % secondNumber;
               return result = true;
            }
            
        }
    }

}