using DatabaseTesting.Models;
using Microsoft.EntityFrameworkCore;

await using var db = new BloggingContext();

Console.WriteLine("Inserting a new blog");
db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
await db.SaveChangesAsync();

Console.WriteLine("Querying for a blog");
var blog = await db.Blogs
    .OrderBy(b => b.BlogId)
    .FirstAsync();

Console.WriteLine("Updating the blog and adding a post");
#pragma warning disable S1075
blog.Url = "https://devblogs.microsoft.com/dotnet";
#pragma warning restore S1075
blog.Posts.Add(
    new() { Title = "Hello World", Content = "I wrote an app using EF Core!" });
await db.SaveChangesAsync();

Console.WriteLine("Delete the blog?");
var response = Console.ReadLine();

if(response?.ToLower() != "y")
{
    Console.WriteLine("Exiting without deleting the blog.");
    return;
}

Console.WriteLine("Deleting the blog");
db.Remove(blog);
await db.SaveChangesAsync();
