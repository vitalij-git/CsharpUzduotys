using _5.Entity_Framework_core.Models;

namespace _5.Entity_Framework_core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using var dbContext = new BookContext();
            var page = new Page(1, "Text text");
            dbContext.Add(page);
            dbContext.SaveChanges();

        }
    }
}