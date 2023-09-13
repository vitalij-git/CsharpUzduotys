using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Entity_Framework_core.Models
{
    internal class Book
    {
        public Book(string name)
        {
            Name = name;
            Id = Guid.NewGuid();
            Pages = new List<Page>();
        }

        public Guid Id { get; set; } 
        public string Name { get; set; }
        public List<Page> Pages { get; set; }   

    }
}
