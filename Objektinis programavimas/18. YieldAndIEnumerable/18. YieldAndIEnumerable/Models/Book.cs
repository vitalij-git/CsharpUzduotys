using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18._YieldAndIEnumerable.Models
{
    internal class Book
    {
        public Book(string name, int pages, string author, string iSBN)
        {
            Name = name;
            Pages = pages;
            Author = author;
            ISBN = iSBN;
        }

        public string Name { get; set; }
        public int Pages { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
