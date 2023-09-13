using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ManyToMany.Models
{
    [Table("Post")]
    internal class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title{ get; set; }
        public string? Content { get; set; }
        public int BlogId { get; set;}
        public Blog Blog { get; set; }
    }
}
