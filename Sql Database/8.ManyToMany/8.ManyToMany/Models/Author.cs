using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace _8.ManyToMany.Models
{
    [Table("Author")]
    internal class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [MaxLength(150)]
        [Required]
        public string FirstName { get; set; }
        [MaxLength(150)]
        public string LastName { get; set; }
        public IList<AuthorBlog> AuthorBlogs { get; set; }
    }
}
