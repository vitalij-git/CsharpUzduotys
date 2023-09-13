using _5.Entity_Framework_core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Entity_Framework_core
{
    internal class BookContext : DbContext
    {
        public DbSet<Page> Pages { get; set; }
        public DbSet<Book> Books { get; set; }  

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
         // optionsBuilder.UseSqlServer("Data Source=DESKTOP-O7DTL46;Initial Catalog=Books;Integrated Security=True;");
            optionsBuilder.UseSqlServer("Server=DESKTOP-O7DTL46; Database=Books; Trusted_Connection=True;TrustServerCertificate=true");
        }
    }
}
