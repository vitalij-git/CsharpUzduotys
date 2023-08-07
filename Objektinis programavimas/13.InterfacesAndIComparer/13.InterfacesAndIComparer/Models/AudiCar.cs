using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.InterfacesAndIComparer.Models
{
    internal class AudiCar : Car
    {
        public AudiCar(bool isQuattro, int fuel, string model)
        {
            IsQuattro = isQuattro;
            Fuel = fuel;
            Model = model;  
        }

        public bool IsQuattro { get; set; }
        public override int Fuel { get; set; }
        public override string Model { get; set; }
    }
}
