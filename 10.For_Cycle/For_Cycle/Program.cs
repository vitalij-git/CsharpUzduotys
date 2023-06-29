namespace For_Cycle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1_1();
            //Task1_2();
            //Task1_3_1();
            //Task1_4();
            //Task1_5();
            Task1_6();

        }
       
        
        static void Task1_1()
        {
            for (int i = 2; i <= 100; i+=2) 
            { 
                Console.WriteLine(i);
            }
        }

        static void Task1_2()
        {
            int userNumberFromInput = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            for (int i = 0; i<= userNumberFromInput; i++){
                result += i;
            }
            Console.WriteLine(result);
        }

        static void Task1_3()
        {
            
            int numberFromInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= numberFromInput; i++)
            {
                
                if (i == 2)
                {
                    Console.WriteLine("Prime number is: " + i);
                    Console.WriteLine("Square of the number is: " + Math.Pow(i, 2));
                }
                else if (isPrime(i))
                {
                    Console.WriteLine("Prime number is: " + i);
                    Console.WriteLine("Square of the number is: " + Math.Pow(i, 2));
                }
               
            }
        }

        static bool isPrime(int checkOfPrimeNumber)
        {
            if (checkOfPrimeNumber > 1)
            {
                return Enumerable.Range(1, checkOfPrimeNumber).Where(x => checkOfPrimeNumber % x == 0)
                                 .SequenceEqual(new[] { 1, checkOfPrimeNumber });
            }

            return false;
        }

        static void Task1_3_1()
        {

            int numberFromInput = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= numberFromInput; i++)
            {

                if (i == 2)
                {
                    Console.WriteLine("Prime number is: " + i);
                    Console.WriteLine("Square of the number is: " + Math.Pow(i, 2));
                }
                else if (CheckIsPrime(i))
                {
                    Console.WriteLine("Prime number is: " + i);
                    Console.WriteLine("Square of the number is: " + Math.Pow(i, 2));
                }

            }
        }

        static bool CheckIsPrime(int checkOfPrimeNumber)
        {
            for (int i = 2; i < checkOfPrimeNumber - 1; i++)
            {
                if (checkOfPrimeNumber % i == 0)
                {
                    return false;
                }   
                if(checkOfPrimeNumber%i != 0)
                {
                    continue;
                }
                
            }
            return true;
        }

        static void Task1_4()
        {
            Console.Write("Iveskite skaiciu: ");
            int numberFromInput = Convert.ToInt32(Console.ReadLine());
            int sumResults = 0;
            int numbCount = 0;
            for (int i = 1; i < numberFromInput; i++)
            {
                sumResults += i;
                numbCount++;
            }
            int averageResults= Average(sumResults, numbCount);
            Console.WriteLine(averageResults);

        }
   
        static int Average(int sumResult, int numbCount )
        {
            return sumResult / numbCount;
        }

        static void Task1_5()
        {
            Console.Write("Iveskite skaiciu: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1;i<= userNumber;i++)
            {
                Console.WriteLine("*");
            }
        }

        static void Task1_6()
        {
            Console.Write("Iveskite skaiciu: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 3;i <= userNumber; i+=3)
            {
                Console.Write(i + ",");
            }
        }
        static void DivideBy3()
        {
            Console.Write("Iveskite skaiciu: ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + ",");
                }
            }
        }
        
    }
}