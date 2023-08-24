using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminasRestoranas.Models
{
   public class DrinkComboBoxItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
