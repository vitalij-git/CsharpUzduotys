using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.OOP_Pradzia.models
{
    internal class Car
    {

        public Car()
        {
            
        }
        public string Brand { get; set; }
        public int Doors { get; set; }
        public double MaxSpeed { get; set; }
        public DateTime CreationDate { get; set; }
        public List<string> Cars { get; set;}

        
    }
}
