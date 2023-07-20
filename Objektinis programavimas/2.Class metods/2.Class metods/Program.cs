using _2.Class_metods.Metods;

namespace _2.Class_metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numbers();
           // RectangleArea();
            //CircleArea();
            BooksLibrary();
        }

        static void Numbers()
        {
            var numbers = new ListOfNumbers(new List<int>());
            for(int i = 0; i < 10; i++)
            {
                numbers.Numbers.Add(GetInteger());
            }
            
            numbers.PrintNumbers();
        }

        static int GetInteger()
        {
            var userIntNumber = Console.ReadLine();
            if (int.TryParse(userIntNumber, out var number))
            {
                return number;
            }
           return 1;
        }

        static void RectangleArea()
        {
            var height = GetInteger();
            var width = GetInteger();
            var rectangle = new Rectangle(height,width);
            Console.WriteLine(rectangle.RectangleArea()); 

        }
        static double GetDouble()
        {
            var userDoubleNumber = Console.ReadLine();
            if (double.TryParse(userDoubleNumber, out var number))
            {
                return number;
            }
            return 1;
        }

        static void CircleArea()
        {
            var radius = GetDouble();
            var circle = new Circle(radius);
            Console.WriteLine(circle.CircleArea());
        }

        static void BooksLibrary()
        {
            var booksLibrary = new Library();
            AddBook(booksLibrary);
            booksLibrary.PrintBooks();
            RemoveBook(booksLibrary);
            booksLibrary.PrintBooks();
        }
        static void AddBook(Library booksLibrary)
        {
            var book= Console.ReadLine();
            booksLibrary.Books.Add(new Book(book));
        }

        static void RemoveBook(Library booksLibrary)
        {
            var book = Console.ReadLine();
            booksLibrary.RemoveBook(new Book(book));
        }
    }
}