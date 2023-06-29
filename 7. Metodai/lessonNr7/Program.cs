namespace lessonNr7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TaskNr1_1();
            //TaskNr1_2();
            //TaskNr1_3();
            //TaskNr2_1();
            //TaskNr2_2();
            //TaskNr2_3();
            TaskNr2_4();
        }
        static void TaskNr1_1()
        {
            string userPassword = Console.ReadLine();
            bool checkUserPassword = IsPasswordValid(userPassword);
            Console.WriteLine(checkUserPassword);
        }

        static bool IsPasswordValid (string password) 
        {
            return password.Length>8;
        }

        static void TaskNr1_2()
        {
            string userEmail = Console.ReadLine();
            bool checkUserEmail = IsEmailValid(userEmail);
            Console.WriteLine(checkUserEmail);
        }
        static bool  IsEmailValid(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }
        static void TaskNr1_3()
        {
            double dollarsFromInput= double.Parse(Console.ReadLine());
            double convertToEurosValue = ConvertToEuros(dollarsFromInput);
            Console.WriteLine($"{dollarsFromInput}$ yra {convertToEurosValue} Eur.");
        }
        static double ConvertToEuros(double eurosValue) {
            return eurosValue * 0.85;
        }
        static void TaskNr2_1()
        {
            Console.WriteLine("Parasykite vardas");
            string nameFromInput = Console.ReadLine();
            Console.WriteLine("Parasykite pavarde");
            string surnameFromInput = Console.ReadLine();
            string fullName = GetInitials(nameFromInput, surnameFromInput);
            Console.WriteLine(fullName);
        }
        static string GetInitials(string name, string surname)
        {
            return name +" "+surname;
        }
        static void TaskNr2_2()
        {
            Console.WriteLine("Parasykite cilindro radiusa");
            double cylinderRadiusFromInput = double.Parse(Console.ReadLine());
            Console.WriteLine("Parasykite cilindro auksti");
            double cylinderHeightFromInput = double.Parse(Console.ReadLine());
            double cylinderVolume = CalculateCylinderVolume(cylinderRadiusFromInput, cylinderHeightFromInput);
            Console.WriteLine(cylinderVolume.ToString("F3"));

        }
        static double CalculateCylinderVolume(double cylinderRadius, double cylinderHeight)
        {
            return Math.PI * Math.Pow(cylinderRadius,2)*cylinderHeight;
        }
        static void TaskNr2_3()
        {
            int numberFromInput = int.Parse(Console.ReadLine());
            Console.WriteLine(IsNumberEven(numberFromInput));
        }
        static bool IsNumberEven(int number) { 
           return number % 2 == 0;
        }
        static void TaskNr2_4()
        {
            Console.WriteLine("Parasykite staciakampio ilgi");
            double rectangleLengthFromInput = double.Parse(Console.ReadLine());
            Console.WriteLine("Parasykite staciakampio ploti");
            double rectangleWidthFromInput = double.Parse(Console.ReadLine());
            double rectangleArea = CalculateRectangleArea(rectangleLengthFromInput, rectangleWidthFromInput);
            Console.WriteLine(rectangleArea);
        }
        static double CalculateRectangleArea(double rectangleLength, double rectangleWidth)
        {
            return rectangleLength * rectangleWidth;
        }
        
    }
}