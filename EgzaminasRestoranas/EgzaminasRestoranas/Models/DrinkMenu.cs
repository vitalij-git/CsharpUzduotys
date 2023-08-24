using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models
{
    public class DrinkMenu
    {
        public DrinkMenu()
        {
        }

        public DrinkMenu(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }
    }
}
