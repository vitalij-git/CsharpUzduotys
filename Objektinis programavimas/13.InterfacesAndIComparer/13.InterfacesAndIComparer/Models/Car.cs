using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.InterfacesAndIComparer.Models
{
    internal abstract class Car : IVehicle
    {
        public Car() { }

        public Car(string model, int fuel, int fuelTank)
        {
            Model = model;
            Fuel = fuel;
            FuelTank = fuelTank;
        }

        public  abstract string Model { get; set; }
        public abstract int Fuel { get; set; }
        public  int  FuelTank { get; set; }
        public bool Drive()
        {
            if (Fuel > 0)
            {
                return true;
            }
            return false;
        }
        public bool Refuel(double refuel)
        {
            if (refuel > 0 && refuel + Fuel < FuelTank)
            {
                return true;
            }
            return false;
        }
    }
}
