using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Class_metods.Metods
{
    internal class Library
    {
        public List<Book> Books { get; set; } = new List<Book>();
        

        public void AddBook(Book book)
        {
            Books.Add(book);
            
        }
        public void RemoveBook(Book book)
        {
            if (Books.Contains(book))
            {
                Books.Remove(book);
            }
            
        }
        public void PrintBooks()
        { 
            foreach (var book in Books)
            {
                Console.WriteLine(book + " ");
            }
        }

       
    }
} 
