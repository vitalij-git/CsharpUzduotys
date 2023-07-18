using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods.Metods
{
    internal class Library
    {
        public List<string> Books { get; set; } = new List<string>();

        public List<string> AddBook(string book)
        {
            Books.Add(book);
            return Books;
        }
        public List<string> RemoveBook(string book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
            }
            return Books;
        }
    }
} 
