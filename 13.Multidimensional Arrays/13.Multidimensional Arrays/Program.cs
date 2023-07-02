using System.Text;

namespace _13.Multidimensional_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CreateMDArrayFromInput();
        }

        static void CreateMDArrayFromInput()
        {
            Console.WriteLine("Sukurikime dvimati masyva");
            Console.Write("Iveskite norima eiluciu kieki: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Iveskite norima stulpeliu kieki: ");
            int columns = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows, columns];
            Console.WriteLine("Parasykite taip jei Matrica uzpildysite patys, arba ne jeigu matrica uzpildys automatiskai");
            string userAnswerFromInput = Console.ReadLine();
            if (userAnswerFromInput == "taip") 
            {
                matrix = UserFillMDArray(out matrix, rows, columns);
            }
            else if(userAnswerFromInput == "ne")
            {
                Console.WriteLine("Iveskite nuo kiek iki kiek uzpildytu random skaiciais");
                Console.Write("Pradzia: ");
                int randomStart = int.Parse(Console.ReadLine());
                Console.Write("Pabaiga: ");
                int randomEnd = int.Parse(Console.ReadLine());
                matrix = RandomFillMDArray(out matrix, rows, columns,randomStart,randomEnd);
            }
            ArrayOutput(matrix, rows, columns);
            string arrayDuplicates = ArrayDuplicates(matrix);
            Console.WriteLine(arrayDuplicates);
        }

        static int[,] RandomFillMDArray(out int[,] array, int rows, int columns, int randomStart, int randomEnd)
        {
            array = new int[rows, columns];
            Random rand = new Random();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    
                    array[r, c] = rand.Next(randomStart, randomEnd+1);                     
                }
            }
            return array;
        }

        static int[,] UserFillMDArray(out int[,] array, int rows, int columns)
        {
            array = new int[rows, columns];
            Random rand = new Random();
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    Console.Write($"Iveskite skaiciu, kordinates [{r},{c}]: ");
                    array[r, c] = int.Parse(Console.ReadLine());
                }
            }
            return array;
        }
        static void ArrayOutput(int[,] array, int rows, int columns)
        {
            int i, j;
            for (i = 0; i < rows; i++)
            {
                for (j = 0; j < columns; j++)
                    Console.Write($"{array[i, j]}\t" );
                Console.WriteLine();
            }
        }

        static string ArrayDuplicates(int[,] array)
        {
            StringBuilder duplicatesNumbers = new StringBuilder();
            HashSet<int> notUnique = new HashSet<int>();
            List<int> duplicateList = new List<int>();
            foreach(int item in array)
            {
                if (!notUnique.Add(item))
                {
                    duplicateList.Add(item);               
                }
            }
            HashSet<int> unique = new HashSet<int>(duplicateList);
            foreach (int item in duplicateList)
            {
                if (unique.Add(item))
                {
                    duplicatesNumbers.Append(item + ",");
                }
            }
            return duplicatesNumbers.ToString();    
        }
    }
}