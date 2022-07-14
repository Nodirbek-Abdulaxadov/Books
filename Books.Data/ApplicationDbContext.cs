using Books.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Books.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
        Database.EnsureCreated();
    }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(
                new Category()
                { 
                    Id = 1,
                    Name = "Engineering"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Science"
                }
            );

        modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = 1,
                    Name = "C# 10 and .NET 6 – Modern Cross-Platform Development: Build apps, websites, and services with ASP.NET Core 6, Blazor, and EF Core 6 using Visual Studio 2022 and Visual Studio Code, 6th Edition",
                    Price = 39.16,
                    Author = "Mark J.Price",
                    UrlToBook = "https://www.amazon.com/10-NET-Cross-Platform-Development-websites/dp/1801077363/ref=sr_1_1?keywords=.net+6+and+C%23+10&qid=1652594355&s=books&sr=1-1-catcorr",
                    CategoryId = 1
                },
                new Book()
                {
                    Id = 2,
                    Name = "All the Math You Missed ((But Need to Know for Graduate School))",
                    Price = 26.36,
                    Author = "Thomas A. Garrity",
                    UrlToBook = "https://www.amazon.com/Math-Missed-Need-Graduate-School/dp/1009009192/ref=sr_1_4?keywords=math&qid=1652594784&s=books&sr=1-4",
                    CategoryId = 2
                },
                new Book()
                {
                    Id = 3,
                    Name = "C# 10 and .NET 6 – Modern Cross-Platform Development: Build apps, websites, and services with ASP.NET Core 6, Blazor, and EF Core 6 using Visual Studio 2022 and Visual Studio Code, 6th Edition",
                    Price = 39.16,
                    Author = "Mark J.Price",
                    UrlToBook = "https://www.amazon.com/10-NET-Cross-Platform-Development-websites/dp/1801077363/ref=sr_1_1?keywords=.net+6+and+C%23+10&qid=1652594355&s=books&sr=1-1-catcorr",
                    CategoryId = 1
                },
                new Book()
                {
                    Id = 4,
                    Name = "All the Math You Missed ((But Need to Know for Graduate School))",
                    Price = 26.36,
                    Author = "Thomas A. Garrity",
                    UrlToBook = "https://www.amazon.com/Math-Missed-Need-Graduate-School/dp/1009009192/ref=sr_1_4?keywords=math&qid=1652594784&s=books&sr=1-4",
                    CategoryId = 2
                },
                new Book()
                {
                    Id = 5,
                    Name = "C# 10 and .NET 6 – Modern Cross-Platform Development: Build apps, websites, and services with ASP.NET Core 6, Blazor, and EF Core 6 using Visual Studio 2022 and Visual Studio Code, 6th Edition",
                    Price = 39.16,
                    Author = "Mark J.Price",
                    UrlToBook = "https://www.amazon.com/10-NET-Cross-Platform-Development-websites/dp/1801077363/ref=sr_1_1?keywords=.net+6+and+C%23+10&qid=1652594355&s=books&sr=1-1-catcorr",
                    CategoryId = 1
                },
                new Book()
                {
                    Id = 6,
                    Name = "All the Math You Missed ((But Need to Know for Graduate School))",
                    Price = 26.36,
                    Author = "Thomas A. Garrity",
                    UrlToBook = "https://www.amazon.com/Math-Missed-Need-Graduate-School/dp/1009009192/ref=sr_1_4?keywords=math&qid=1652594784&s=books&sr=1-4",
                    CategoryId = 2
                }
            );
    }
}
