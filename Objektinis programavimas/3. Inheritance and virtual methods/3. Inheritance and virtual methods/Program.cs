using _3._Inheritance_and_virtual_methods.Metods;

namespace _3._Inheritance_and_virtual_methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // CarSpeed();
            //BikeSpeed();    
            // ManagerInfo();
            var programmer = new Programmer( "Tomas", 1400);
            var programmer1 = new Programmer( "Simas", 1600);
            var programmer2 = new Programmer( "Jonas", 1800);
            programmer.ProgrammerOutput();
            programmer1.ProgrammerOutput();
            programmer2.ProgrammerOutput();
            var manager = new Manager();
            manager.Employees.Add(programmer);
            manager.Employees.Add(programmer1);
            manager.Employees.Add(programmer2);
            manager.OutputEmployees();
            //var manager = new Manager();
            //OutputProgramersList(manager);
        }

        static void CarSpeed()
        {
            var car = new Car(90);
            Console.WriteLine(car.Speed);
        }
        
        static void BikeSpeed()
        {
            var bike = new Bike(25);
            Console.WriteLine(bike.Speed);
        }

        static void ManagerInfo()
        {
            int salary = 1000;
            string name = "Justas";
            var manager = new Manager();
            Console.WriteLine($"{manager.Name} {manager.Salary} {manager.Employees}");
        }

       

       
    }
}