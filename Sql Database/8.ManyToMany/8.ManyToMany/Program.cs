using _8.ManyToMany.Database;
using _8.ManyToMany.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace _8.ManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddBlog("Prgramavimas");
            AddPost("Csharp", 1);
            AddAuthor("Petras", "Petrauskas", 1);

            GetBlogs_EagerLoading();

        }
        static void AddBlog(string name)
        {
            using var context = new BloggingContext();
            context.Blogs.Add(new Blog { Name = name });
            context.SaveChanges();
        }
        static void AddPost(string title, int blogId)
        {
            using var context = new BloggingContext();
            var blog = context.Blogs.Find(blogId);
            blog.Posts.Add(new Post { Title = title });
            context.SaveChanges();
        }

        static void AddAuthor(string firstName, string lastName, int blogId)
        {
            using var context = new BloggingContext();
            context.AuthorBlogs.Add(
                new AuthorBlog
                {
                    Author = new Author
                    {
                        FirstName = firstName,
                        LastName = lastName,
                    }
                });
            context.SaveChanges();
        }
        public static void GetBlogs_EagerLoading()
        {
            using var context = new BloggingContext();
            var blogs = context.Blogs.Include(b => b.Posts);

            foreach (var blog in blogs)
            {
                Console.WriteLine($"** {blog.BlogId} {blog.Name}");
                foreach(var post in blog.Posts)
                {
                    Console.WriteLine($"\t-{post.PostId} {post.Title}");
                }
            }
        }
    }
}