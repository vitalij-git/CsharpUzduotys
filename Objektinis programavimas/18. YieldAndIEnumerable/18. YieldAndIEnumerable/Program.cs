using _18._YieldAndIEnumerable.Models;
using System.Data.SqlClient;
namespace _18._YieldAndIEnumerable
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //NumberGenerator();
            //Fibonacci();
            //ListOfPeoples();
            //NumbersOfSquare();

            //data base
            //var products = new Products();
            //products.ReadFromDataBase();

            //3.1
            //TextFile();
            //3.2
            //ShowDate();
            //3.3
            Library();
        }

        static IEnumerable<int> GetEvenNumbers(int max)
        {
            for(int i = 0; i < max; i++)
            {
                if(i%2 == 0)
                {
                    yield return i;
                }
            }
        }

        static void StringPrinter()
        {
            var stringPrinter = new StringPrinter();
            stringPrinter.AddLine("Mano pasaulis");
            stringPrinter.AddLine("Tavo pasaulis");
            stringPrinter.AddLine("Yra");
            foreach (var item in stringPrinter)
            {
                Console.WriteLine(item);
            }
        }
        
        static void NumberGenerator()
        {
            var numberGenerator = new NumberGenerator(10,20);
            foreach (var number in numberGenerator)
            {
                Console.WriteLine(number);
            }

        }

        static void Fibonacci()
        {
            var fibonacciSequence = new FibonacciSequence(5421);
            foreach (var number in fibonacciSequence)
            {
                Console.WriteLine(number);
            }
        }

        static void ListOfPeoples()
        {
            var listOfPeoples = new PeopleCollection("PeopleList.txt");
            listOfPeoples.AddPerson("simas","simaus",16);
            listOfPeoples.AddPerson("Vardas", "Pavarde", 28);
            listOfPeoples.WriterToFile();
            foreach(var people in listOfPeoples)
            {
                Console.WriteLine($"Name is {people.Name} surname is {people.Surname} age is {people.Age}");
            }
        }

        static void NumbersOfSquare()
        {
            var numbers = NumberFromFile();
            foreach (var number in numbers)
            {
                if (int.TryParse(number, out int convertNumber))
                {
                    Console.WriteLine(Math.Pow(convertNumber, 2));
                }
            }
        }
        static IEnumerable<string> NumberFromFile()
        {
            string filePath = @"C:\Users\Vitalis\Desktop\Programavimo darbai\Objektinis programavimas\18. YieldAndIEnumerable\18. YieldAndIEnumerable\bin\Debug\net7.0\numbers.txt";
            using(var streamReader = new StreamReader(filePath))
            {
                string? line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    foreach(var part in parts)
                    {
                       
                        yield return part;
                    }
                }
            }   
        }

        static void TextFile()
        {
            var lines = GetLinesFromFile();
            lines= lines.Where(line => line.Length > 12);
            foreach (var line in lines) 
            {
                Console.WriteLine(line);
            }
        }

        static IEnumerable<string> GetLinesFromFile()
        {
            string path = @"C:\Users\Vitalis\Desktop\Programavimo darbai\Objektinis programavimas\18. YieldAndIEnumerable\18. YieldAndIEnumerable\bin\Debug\net7.0\text.txt";
            using (var streamReader = new StreamReader(path))
            {
                string? line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    string[] parts = line.Split(' ');
                    foreach (var part in parts)
                    {

                        yield return part;
                    }
                }
            }
        }
        static void ShowDate()
        {
            var showDate = GetDate(8,30);
            foreach (var date in showDate)
            {
                Console.WriteLine(date);
            }
        }
        static IEnumerable<DateTime> GetDate(int months, int day)
        {
           DateTime dateNow = DateTime.Now;
            for(int i = 1; i <= months; i++)
            {
               yield return dateNow.AddMonths(i);
               
            }
            for (int i = 1; i <= day; i++)
            {
                
                yield return dateNow.AddDays(i);
            }
        }

        static void Library()
        {
            var library = new Library();
            var book = new Book("dangus", 456, "Tomas", "0-5607-6691-2");
            //library.AddBook(book);
            //library.ReadFromDataBase();
            //library.GetBooksByNameOrByAuthor("Name", "Pasaulis");
            library.GetBooksAveragePage();
        }
    }

}