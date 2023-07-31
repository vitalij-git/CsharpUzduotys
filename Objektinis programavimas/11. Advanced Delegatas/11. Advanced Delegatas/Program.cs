using System.Reflection;
using System.Text;

namespace _11._Advanced_Delegatas
{
    internal class Program
    {
        private delegate string Person1(string firstName, string lastName, int age);
        private delegate int DelegateInteger(int number1, int number2);
        public delegate List<int> DelegateList(List<int> numbers,int step);
        private delegate T GenericsDelegate<T>(T t);
        private delegate bool Filter (Person person);
        static void Main(string[] args)
        {
            //var person = new Person1(ShowPerson);
            //Console.WriteLine(person("Tomas","Jonaitis",25));
            //var numbersSum = new DelegateInteger(SumReturn);
            //Console.WriteLine(numbersSum(10,20));
            //var delegateList = new DelegateList(PutNumbersInList);
            //delegateList +=DelegateNewList;
            //var genericDelegate = new GenericsDelegate<string>(Generics<string>);
            //Console.WriteLine(genericDelegate);


            Person1 human = delegate (string firstName, string lastName, int age)
            {
                return $"Frist name is {firstName}, last name is {lastName} and age is {age}";
            };
            Console.WriteLine(human("Jonas","Jonaitis",13));
            //3
            List<Person> persons = new List<Person>();
            var person = new Person("Simas", 25);
            persons.Add(person);
            var person1 = new Person("Kevin", 8);
            persons.Add(person1);   
            var person2 = new Person("Buzz", 66);
            persons.Add(person2);
            Filter isChild = delegate (Person person)
            {
                return IsChild(person);
            };
            DisplayPeople("Children", persons, isChild);
            Filter isAdult = delegate (Person person)
            {
                return IsAdult(person);
            };
            DisplayPeople("Adult", persons, isAdult);
            Filter isSenior = delegate (Person person)
            {
                return IsSenior(person);
            };
            DisplayPeople("Senior", persons, isSenior);
        }

        static string ShowPerson(string firstName, string lastName, int age) 
        {
            return $"Frist name is {firstName}, last name is {lastName} and age is {age}";
        }

        static int SumReturn(int number1, int number2)
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
            StringBuilder str = new StringBuilder();
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

        //3
        static bool IsChild (Person person)
        {
            if (person.Age < 18)
            {
                return true;
            }
            return false;
        }

        //3
        static bool IsAdult(Person person)
        {
            if (person.Age>=18 && person.Age < 65)
            {
                return true;
            }
            return false;
        }
        
        //3
        static bool IsSenior(Person person)
        {
            if (person.Age >= 65)
            {
                return true;
            }
            return false;
        }   

        //3
        static void DisplayPeople(string title, List<Person> persons, Filter person)
        {
            foreach (var item in persons)
            {
                Console.WriteLine(title + " " +item.Name + " " + person(item)); 
            }
            
        }
    }
}