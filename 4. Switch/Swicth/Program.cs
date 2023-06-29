using System;

namespace Swicth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            Task7();
            //Task8();
            //Task9();
        }
        static void Task1()
        {
            Console.Write("Enter a number of days: ");
            var day = Console.ReadLine();
            switch (day)
            {
                case "1":
                    Console.WriteLine("Monday");
                    break;
                case "2":
                    Console.WriteLine("Tuesday");
                    break;
                case "3":
                    Console.WriteLine("Wednesday");
                    break;
                case "4":
                    Console.WriteLine("Thursday");
                    break;
                case "5":
                    Console.WriteLine("Friday");
                    break;
                case "6":
                    Console.WriteLine("Saturday");
                    break;
                case "7":
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("something wrong... try again");
                    Task1();
                    break;
            }
        }
        static void Task2()
         {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                switch (age) { 
                case >=7 and <=18:
                        Console.WriteLine("Schoolboy");
                        break;
                case >18 and <26:
                        Console.WriteLine("Student");
                        break;
                case >=66:
                        Console.WriteLine("Pensioner");
                        break;
                default:
                        Console.WriteLine("something wrong... try again");
                        Task2();
                        break;
                }
         }
        static void Task3()
        {
            Console.Write("Enter a number of months: ");
            var month = Console.ReadLine();
            switch (month)
            {
                case "1":
                    Console.WriteLine("January");
                    break;
                case "2":
                    Console.WriteLine("February");
                    break;
                case "3":
                    Console.WriteLine("March");
                    break;
                case "4":
                    Console.WriteLine("April");
                    break;
                case "5":
                    Console.WriteLine("May");
                    break;
                case "6":
                    Console.WriteLine("June");
                    break;
                case "7":
                    Console.WriteLine("Jule");
                    break;
                case "8":
                    Console.WriteLine("August");
                    break;
                case "9":
                    Console.WriteLine("September");
                    break;
                case "10":
                    Console.WriteLine("Oktober");
                    break;
                case "11":
                    Console.WriteLine("November");
                    break;
                case "12":
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("something wrong... try again");
                    Task3();
                    break;
            }
        }
        static void Task4()
        {
           Console.WriteLine("1 - Square\n2 - Circle\n3 - Triangle\n4 - Rectangle");
           Console.Write("choose a figure and write a figure id");
            int figure = int.Parse(Console.ReadLine());
            switch (figure)
            {
                case 1:
                    Console.Write("Enter a sqaure length: ");
                    double sqaure = double.Parse(Console.ReadLine());
                    Console.WriteLine($"Sqaure area: {Math.Pow(sqaure,2)}");
                    break;
                case 2:
                    Console.Write("Enter a circle radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    double circle = Math.PI * Math.Pow(radius, 2);  
                    Console.WriteLine($"Circle area: {circle}");
                    break;
                case 3:
                    Console.Write("Enter a triangle length: ");
                    double triangleLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter a triangle height: ");
                    double triangleHeight= double.Parse(Console.ReadLine());
                    double triangleArea = triangleLength * triangleHeight / 2;
                    Console.WriteLine($"Triangle area: {triangleArea}");
                    break;
                case 4:
                    Console.Write("Enter a rectangle length: ");
                    double rectangleLength = double.Parse(Console.ReadLine());
                    Console.Write("Enter a triangle height: ");
                    double rectangleWidth = double.Parse(Console.ReadLine());
                    double rectangleArea = rectangleLength * rectangleWidth;
                    Console.WriteLine($"Triangle area: {rectangleArea}");
                    break;
                default:
                    Console.WriteLine("something wrong... try again");
                    Task4();
                    break;
            }
        }
        static void Task5()
        {
            Console.WriteLine("1 - Fire\n2 - Air\n3 - Water\n4 - Earth\n5 - Ether");
            Console.WriteLine("Write element by ID");
            int element = int.Parse(Console.ReadLine());
            switch (element)
            {
                case 1:
                    Console.WriteLine("Fire");
                    break;
                case 2:
                    Console.WriteLine("Air");
                    break;
                case 3:
                    Console.WriteLine("Water");
                    break;
                case 4:
                    Console.WriteLine("Earth");
                    break;
                case 5:
                    Console.WriteLine("Ether");
                    break;
                default:
                    Console.WriteLine("something wrong... try again");
                    Task5();
                    break;
            }
        }
        static void Task6() {
            Console.WriteLine("1 - Nathematics\n2 - Physics\n3 - Informatics\n4 - Biology");
            Console.WriteLine("Choose the desired specialty");
            int spiecialtyID = int.Parse(Console.ReadLine());
            Console.WriteLine("Write your egzamin average");
            double egzaminAverage = double.Parse(Console.ReadLine());   
            switch(spiecialtyID) {
                case 1:
                case 2:
                    switch (egzaminAverage) {
                        case <= 5:
                            Console.WriteLine("You don't have a chance to get a place at the university");
                            break;
                        case > 5 and <= 7:
                            Console.WriteLine("You can to get a paid place at the university");
                            break;
                        case > 7 and < 9:
                            Console.WriteLine("You can to get a free place at the university");
                            break;
                        case > 9 and <= 10:
                            Console.WriteLine("You can to get a paid place at the university with stipendium");
                            break;
                        default:
                            Console.WriteLine("something wrong... try again");
                            Task6();
                            break;
                    }
                    break;
                    case 3:
                    case 4: 
                    Random random = new Random();
                    bool randomBool = random.Next(2) == 1;
                    switch (randomBool)
                    {
                        case true:
                            Console.WriteLine("You can to get a free place at the university");
                            break;
                        case false:
                            Console.WriteLine("You can to get a paid place at the university");
                            break;
                        default:
                            Console.WriteLine("something wrong... try again");
                            Task6();
                            break;
                    }
                    break;
                    default:
                    Console.WriteLine("something wrong... try again");
                    Task6();
                    break;

            }
        }
        static void Task7()
        {
            Console.WriteLine("Iveskite menesio numeri");
            int monthNumber = int.Parse(Console.ReadLine());
            var months = monthNumber switch
            {
                1 or 2 or 12 => "Ziema",
                3 or 4 or 5 =>"Pavasaris",
                6 or 7 or 8 =>"Vasara",
                9 or 10 or 11 =>"Ruduo",
                _=>"Blogai parasewte skaiciu"
            };
            Console.WriteLine(months);
        }
        static void Task8()//Calculator

        {   
            Console.WriteLine("Iveskite pirma skaiciu");
            double firstNubmer = double.Parse(Console.ReadLine());
            Console.WriteLine("Iveskite aritmetikos zenkla");
            var arithemtic = Console.ReadLine();
            Console.WriteLine("Iveskite antra skaiciu");
            double secondNubmer = double.Parse(Console.ReadLine());
            switch (arithemtic)
            {
                case "+":
                    Console.WriteLine($"Suma: {firstNubmer+secondNubmer}");
                    break;
                case "-":
                    Console.WriteLine($"Skirtumas: {firstNubmer - secondNubmer}");
                    break;
                case "*":
                    Console.WriteLine($"Daugyba: {firstNubmer * secondNubmer}");
                    break;
                case "/":
                    Console.WriteLine($"Dalyba: {firstNubmer/secondNubmer}");
                    break;
                case "^":
                    Console.WriteLine($"Kelimas: {Math.Pow(firstNubmer, secondNubmer)}");
                    break;
                case "√":
                    Console.WriteLine($"Saknis: {Math.Pow(firstNubmer, (1 / secondNubmer))}");
                    Console.WriteLine($"Saknis pirmo skaiciaus: {Math.Sqrt(firstNubmer)} saknis antro skaiciaus: {Math.Sqrt(secondNubmer)}");
                    break;
                default:
                    Console.WriteLine("something wrong... try again");
                    Task8();
                    break;
            }

        }
        static void Task9()
        {
            Console.WriteLine("1 - USD\n2 - EUR\n3 - GBP\n4 - JPY");
            Console.WriteLine("Pasirinkite valiuta pagal ID");
            int currency =int.Parse(Console.ReadLine());
            Console.Write("Iveskite norima suma: ");
            double currencySum = double.Parse(Console.ReadLine());
            switch(currency) {
                case 1:
                    Console.WriteLine($" Eur: {currencySum * 0.91}\nGBP: {currencySum * 0.78}\nJPY: {currencySum * 140.31}");
                    break;  
                case 2:
                    Console.WriteLine($" USD: {currencySum * 1.09}\nGBP: {currencySum * 0.86}\nJPY: {currencySum * 153.56}");
                    break;
                case 3:
                    Console.WriteLine($" USD: {currencySum * 1.28}\nEUR: {currencySum * 1.17}\nJPY: {currencySum * 179.27}");
                    break;
                case 4:
                    Console.WriteLine($" USD: {currencySum * 0.0071}\nEUR: {currencySum * 0.0065}\nGBP: {currencySum * 0.0056}");
                    break;
                default:
                    Console.WriteLine("something wrong... try again");
                    Task9();
                    break;
            }
        }
    }
}