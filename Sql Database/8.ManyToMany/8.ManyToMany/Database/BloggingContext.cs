using _8.ManyToMany.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.ManyToMany.Database
{
    internal class BloggingContext : DbContext
    {
        public BloggingContext()
        {
            ConnectionString = "Data Source=DESKTOP-O7DTL46;Initial Catalog=Blog;Integrated Security=True;TrustServerCertificate=true";
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<AuthorBlog> AuthorBlogs { get; set; }
        public string ConnectionString { get;  }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuthorBlog>()
                .HasKey(ab => new {ab.AuthorId, ab.BlogId});
            modelBuilder.Entity<AuthorBlog>()
                .HasOne<Author>(ab => ab.Author)
                .WithMany(a => a.AuthorBlogs)
                .HasForeignKey(ab => ab.AuthorId);
            modelBuilder.Entity<AuthorBlog>().HasOne<Blog>(ab => ab.Blog)
                .WithMany(a => a.AuthorBlogs)
                .HasForeignKey(ab => ab.AuthorId);
        }
    }
}
