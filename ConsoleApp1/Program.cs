using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;

class Program
{
    static void Main(string[] args)
    {
        using (var context = new AppDbContext())
        {
            context.Database.EnsureCreated();

            AddAutorWithBlogs(context);
            FetchAndDisplayAutorsWithBlogs(context);
        }
    }

    static void AddAutorWithBlogs(AppDbContext context)
    {
        var autor = new Autor
        {
            Name = "Jan Kowalski",
            Blogs = new List<Blog>
            {
                new Blog { Title = "Blog kulinarny" },
                new Blog { Title = "Blog podróżniczy" }
            }
        };

        context.Autors.Add(autor);
        context.SaveChanges();
    }

    static void FetchAndDisplayAutorsWithBlogs(AppDbContext context)
    {
        var autors = context.Autors
            .Include(a => a.Blogs)
            .ToList();

        foreach (var autor in autors)
        {
            Console.WriteLine($"Autor: {autor.Name}");
            foreach (var blog in autor.Blogs)
            {
                Console.WriteLine($"  Blog: {blog.Title}");
            }
        }
    }
}




