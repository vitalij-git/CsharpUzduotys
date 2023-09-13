using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Entity_Framework_core.Models
{
    internal class Page
    {
        
        public Page(int number, string content)
        {
            Number = number;
            Content = content;
            Id = Guid.NewGuid();
        }

        public  Guid Id { get; set; }
        public int Number { get; set; }
        public string Content { get; set; }
    }
}
