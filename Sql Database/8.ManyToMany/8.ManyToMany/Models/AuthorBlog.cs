using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ManyToMany.Models
{
    internal class AuthorBlog
    {
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
