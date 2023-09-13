using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _8.ManyToMany.Models
{
    [Table("Blog")]
    internal class Blog
    {
        [Key]
        [Column (Order =0)]
        
        public int BlogId { get; set; }
        [Column(Order = 2)]
        public decimal Rating { get; set; } = 0;
        [Column("BlogName", Order = 1)]
        public string Name { get; set; }
        public IList<Post> Posts { get; set; } = new List<Post>();
        public IList<AuthorBlog> AuthorBlogs { get; set; }

    }
}
