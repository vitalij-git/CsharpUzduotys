using _4._Abstrakcijos.models;

namespace _4._Abstrakcijos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicleList = new List<Vehicle>();
            FigureOfSquare();
            FigureOfTriangle();
            AnimalNoise();
            TransportBrakingDistance(vehicleList);

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

        static void TransportBrakingDistance(List<Vehicle> vehicleList)
        {
            var car = new Car(90,1500,3);
            vehicleList.Add(car);
            var truck = new Truck(70,30000,6);
            vehicleList.Add(truck);
            var bus = new Bus(80,10000,4);
            vehicleList.Add(bus);
            var carBrakingDistance = car.BrakingDistance();
            var truckBrakingDistance = truck.BrakingDistance();
            var busBrakingDistance = bus.BrakingDistance();
            Console.WriteLine($"Car braking distance: {carBrakingDistance}\n" +
                $"Truck braking distance: {truckBrakingDistance}\n" +
                $"Bus brakin distance: {busBrakingDistance}");
        }
    }
}