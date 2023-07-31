using System.Reflection;

namespace _11._Advanced_Delegatas
{
    internal class Program
    {
        private delegate string Person(string firstName, string lastName, int age);
        private delegate int DelegateInteger(int number1, int number2);
        private delegate List<int> DelegateList(List<int> numbers,int step);
        private delegate T GenericsDelegate<T>(T t);
        static void Main(string[] args)
        {
            var person = new Person(ShowPerson);
            Console.WriteLine(person("Tomas","Jonaitis",25));
            var delegateList = new DelegateList(PutNumbersInList);
            delegateList += DelegateNewList;
            Console.WriteLine(delegateList);
           // var genericDelegate = new GenericsDelegate<T>(Generics<T>);

        }

        static string ShowPerson(string firstName, string lastName, int age) 
        {
            return $"Frist name is {firstName}, last name is {lastName} and age is {age}";
        }

        static int NumbersReturn(int number1, int number2)
        {
            return number1 + number2;
        }
        static List<int> PutNumbersInList(List<int> numbers, int step)
        {
            for (int i = 0; i < 20; i++)
            {
                numbers.Add(i); 
            }
            return numbers;
        }
        static List<int> DelegateNewList(List<int> numbers, int step)
        {
            var newList = new List<int>();
            for (int i = 0; i < numbers.Count(); i += step)
            {
                newList.Add(numbers[i]);    
            }
            return newList;
        }
        
        static string Generics<T>(T generics)
        {
            return typeof(T).ToString();
        }
        
    }
}