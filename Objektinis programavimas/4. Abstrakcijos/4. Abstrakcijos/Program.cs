using _4._Abstrakcijos.models;

namespace _4._Abstrakcijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FigureOfSquare();
            FigureOfTriangle();
            AnimalNoise();
        }

        static void FigureOfSquare()
        {
            var square = new Square(5,6);
            double squareArea = square.GetArea();
            double sqarePerimeter = square.GetPerimeter();
            Console.WriteLine($"Area: {squareArea}  Perimeter: {sqarePerimeter}");
        }

        static void FigureOfTriangle()
        {
            var triangle = new Triangle(7,4,3,5);
            double triangleArea = triangle.GetArea(); 
            double trianglePerimeter = triangle.GetPerimeter();
            Console.WriteLine($"Area: {triangleArea}  Perimeter: {trianglePerimeter}");
        }

        static void AnimalNoise()
        {
            var dog = new Dog();
            var cat = new Cat();
            Console.Write("Dog say: ");
            dog.MakeNoise();
            Console.Write("Cat say: ");
            cat.MakeNoise();
        }
    }
}