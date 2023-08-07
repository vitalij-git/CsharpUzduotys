using _13.InterfacesAndIComparer.Models;

namespace _13.InterfacesAndIComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var audi = new AudiCar(true,20,"A4");
            var bmw = new BmwCar(false,"320",25);
           
            if (audi.Drive() == true)
            {
                Console.WriteLine("You can drive");
            }
            else
            {
                Console.WriteLine("fuel tank don't have a fuel");
            }
            var fuelTankStatus = audi.Refuel(20);
            if (fuelTankStatus == true)
            {
                Console.WriteLine($"{audi.Fuel} l fuel is pouring");
            }
            else
            {
                Console.WriteLine("fuel is too much for fuel tank or fuel value with negative");
            }

        }

        static void FirstTask()
        {
            //var audi = new Car("A6", 25, 60);
            //var bmw = new Car("320", 10, 50);

            //if (audi.Drive() == true)
            //{
            //    Console.WriteLine("You can drive");
            //}
            //else
            //{
            //    Console.WriteLine("fuel tank don't have a fuel");
            //}
            //var fuelTankStatus = audi.Refuel(20);
            //if (fuelTankStatus == true)
            //{
            //    Console.WriteLine($"{audi.Fuel} l fuel is pouring");
            //}
            //else
            //{
            //    Console.WriteLine("fuel is too much for fuel tank or fuel value with negative");
            //}
        }
    }
}