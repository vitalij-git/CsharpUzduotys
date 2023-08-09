using _18._YieldAndIEnumerable.Models;

namespace _18._YieldAndIEnumerable
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //NumberGenerator();
            //Fibonacci();
            ListOfPeoples();
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
    }

}