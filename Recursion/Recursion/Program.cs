namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {   int factorialFromInput =int.Parse(Console.ReadLine());
            Recursion(factorialFromInput);
           
        }
        static void Recursion(int factorialNumber )
        {
            if (factorialNumber == 0)
            {
                Console.WriteLine(factorialNumber);
                return;
            }

             Recursion(factorialNumber-1) ;
           

        }
    }
}