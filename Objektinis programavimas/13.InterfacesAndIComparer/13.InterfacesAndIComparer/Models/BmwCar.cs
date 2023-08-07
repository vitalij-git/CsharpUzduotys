using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.InterfacesAndIComparer.Models
{
    internal class BmwCar : Car
    {
        public BmwCar(bool isXDrive, string model, int fuel)
        {
            IsXDrive = isXDrive;
            Model = model;
            Fuel = fuel;
        }

        public  bool IsXDrive { get; set; }
        public override string Model { get; set; }
        public override int Fuel { get; set; }
    }
}
