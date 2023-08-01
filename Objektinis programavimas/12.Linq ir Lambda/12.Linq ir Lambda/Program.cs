using System.Runtime.CompilerServices;

namespace _12.Linq_ir_Lambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinQAndLambda();
            LINQWithClass();
        }

        static void LinQAndLambda()
        {
            //1
            var numbers = new List<int>() { 2, 5, 6, 8, 9, 1, 4, 7, 5, 6 };
            var newNumbers = numbers.Select(x => Math.Pow(x,2));
            //2
            var numbersPositiveAndNegative = new List<int>() { 2, 5, -2, -9, -5, 81, -69, -58, 58, 72, -14 };
            var onlyPositive = numbersPositiveAndNegative.Where(x => x > 0);
            //3
            var numbersPositiveAndOver10 = numbersPositiveAndNegative.Where((x) => x > 0 && x <10);
            //4
            var numbersOrderBy = numbersPositiveAndNegative.OrderBy(x => x);  
            //5
            var numberOrderByDescending= numbersPositiveAndNegative.OrderByDescending(x => x); 
            //6
            var maxNumber = numbersPositiveAndNegative.Max(x => x);

        }

        static void LINQWithClass()
        {
            var listOfPersons = new List<Person>();
            var person1 = new Person("Tomas", 25);
            listOfPersons.Add(person1);
            var person2 = new Person("Jonas", 32);
            listOfPersons.Add(person2);
            var person3 = new Person("Simas", 7);
            listOfPersons.Add(person3);
            var person4 = new Person("Kitas", 14);
            listOfPersons.Add(person4);
            var person5 = new Person("Tas", 43);
            listOfPersons.Add(person5);
            var person6 = new Person("Junk", 17);
            listOfPersons.Add(person6);
            var person7 = new Person("Arnas", 55);
            listOfPersons.Add(person7);
            //1
            var listOfName = listOfPersons.Select(x => x.Name);
            var listOfAge = listOfPersons.Select(x=>x.Age);
            //2
            var listOfDescendingAge = listOfPersons.Select(x=> x.Age).OrderByDescending(x => x);
            //3
            var listOfNameWhereStartsFromA = listOfPersons.Select(x => x.Name).Where(x=>x.StartsWith("A"));
            //4
            var listOfNameOrderBy= listOfPersons.Select(x=>x.Name).OrderBy(x=>x);
            var listOfAgeOver40AndOrder = listOfPersons.Where(x=> x.Age>40).Select(x=>x.Name).OrderBy(x=>x);

        }
    }
}