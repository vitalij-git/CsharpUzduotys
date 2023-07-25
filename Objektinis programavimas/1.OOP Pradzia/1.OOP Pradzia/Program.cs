using _1.OOP_Pradzia.models;

namespace _1.OOP_Pradzia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreateCar("Tayota");
            //Car car1 = CreateCar("Lexus");
            //PrintCarDetails(car1);
            CreatePerson();
            Console.ReadKey();
        }

        static Car CreateCar(string brand)
        {
            Car car = new Car();
            car.Brand = brand;
            car.Doors = 4;
            car.MaxSpeed = 200;
            car.CreationDate = new DateTime(2000,10,1);
            return car;
        }

        static void PrintCarDetails(Car car)
        {
            Console.WriteLine($"{car.Brand} {car.Doors} {car.MaxSpeed} {car.CreationDate}");
        }

        static void CreatePerson()
        {
           var person = new Person("Jonas",25);
           person.ShowPerson();
           var student = new Person("John", 19, 1.85);
            student.ShowPersonWithHeight();

        }
    }
}