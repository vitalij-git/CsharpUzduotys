namespace _12._Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1_1();
            Task1_2();
           // Task1_3();
            //Task1_4();

        }

        static void Task1_1()
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            NumbersArray(array);
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }

        static int[] NumbersArray(int[] arrayNumbers)
        {
            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                arrayNumbers[i] = SquareOfNumber(arrayNumbers[i]);
            }
            return arrayNumbers;
        }

        static int SquareOfNumber(int number)
        {
            return (int)Math.Pow(number, 2);
        }

        static void Task1_2()
        {
            int[] arrayFromInput = ArrayFromInput();
            int arraySum = ArraySum(arrayFromInput);
            Console.WriteLine($"Masyvo suma: {arraySum}");
        }

        static int[] ArrayFromInput()
        {   
            var list = new List<int>();
            var userAnswerFromInput="";
            while (true)
            {
                Console.WriteLine("Iveskite sveikaji skaiciu");
                if(int.TryParse(Console.ReadLine(), out int number))
                {
                    list.Add(number);
                    Console.WriteLine($"Jusu skaicius {number}, sekmingai pridetas i masyva");
                    Console.WriteLine("Norite dar prideti skaiciu?(taip/ne)");
                    userAnswerFromInput = Console.ReadLine().ToLower().Trim();
                    if(userAnswerFromInput == "taip")
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
            int[] userArrayFromInput = list.ToArray();
            return userArrayFromInput;
        }
        
        static int ArraySum(int[] userArrayFromInput)
        {
            int result = 0;
            foreach (int i in userArrayFromInput)
            {
                result+= i;
            }
            return result;
        }

        static void Task1_3()
        {
            int[] numbersArray = { 1, 2, 3,70, 5, 6, 7, 80, 9, 10 };
            Console.WriteLine(numbersArray.Max());
            int maxValue = 0;
            for ( int i = 0; i < numbersArray.Length;i++) 
            { 
                if (numbersArray[i] > maxValue)
                {
                    maxValue = numbersArray[i];
                }
            }
            Console.WriteLine(maxValue);
        }

        static void Task1_4()
        {
            int[] numbersArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] reverseArray = new int[10];
            int reverseindex = 0;
            for ( int i = numbersArray.Length-1; i >= 0; i--)
            {
                reverseArray[reverseindex] = numbersArray[i]; 
                reverseindex++;
            }
            foreach (int i in reverseArray)
            {
                Console.WriteLine(i);
            }
        }
    }
}