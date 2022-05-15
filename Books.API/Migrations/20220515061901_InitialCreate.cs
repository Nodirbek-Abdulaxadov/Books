using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Books.API.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    UrlToBook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 1, "Engineering" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "Name" },
                values: new object[] { 2, "Science" });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "Author", "CategoryId", "Name", "Price", "UrlToBook" },
                values: new object[,]
                {
                    { 1, "Mark J.Price", 1, "C# 10 and .NET 6 – Modern Cross-Platform Development: Build apps, websites, and services with ASP.NET Core 6, Blazor, and EF Core 6 using Visual Studio 2022 and Visual Studio Code, 6th Edition", 39.159999999999997, "https://www.amazon.com/10-NET-Cross-Platform-Development-websites/dp/1801077363/ref=sr_1_1?keywords=.net+6+and+C%23+10&qid=1652594355&s=books&sr=1-1-catcorr" },
                    { 2, "Thomas A. Garrity", 2, "All the Math You Missed ((But Need to Know for Graduate School))", 26.359999999999999, "https://www.amazon.com/Math-Missed-Need-Graduate-School/dp/1009009192/ref=sr_1_4?keywords=math&qid=1652594784&s=books&sr=1-4" },
                    { 3, "Mark J.Price", 1, "C# 10 and .NET 6 – Modern Cross-Platform Development: Build apps, websites, and services with ASP.NET Core 6, Blazor, and EF Core 6 using Visual Studio 2022 and Visual Studio Code, 6th Edition", 39.159999999999997, "https://www.amazon.com/10-NET-Cross-Platform-Development-websites/dp/1801077363/ref=sr_1_1?keywords=.net+6+and+C%23+10&qid=1652594355&s=books&sr=1-1-catcorr" },
                    { 4, "Thomas A. Garrity", 2, "All the Math You Missed ((But Need to Know for Graduate School))", 26.359999999999999, "https://www.amazon.com/Math-Missed-Need-Graduate-School/dp/1009009192/ref=sr_1_4?keywords=math&qid=1652594784&s=books&sr=1-4" },
                    { 5, "Mark J.Price", 1, "C# 10 and .NET 6 – Modern Cross-Platform Development: Build apps, websites, and services with ASP.NET Core 6, Blazor, and EF Core 6 using Visual Studio 2022 and Visual Studio Code, 6th Edition", 39.159999999999997, "https://www.amazon.com/10-NET-Cross-Platform-Development-websites/dp/1801077363/ref=sr_1_1?keywords=.net+6+and+C%23+10&qid=1652594355&s=books&sr=1-1-catcorr" },
                    { 6, "Thomas A. Garrity", 2, "All the Math You Missed ((But Need to Know for Graduate School))", 26.359999999999999, "https://www.amazon.com/Math-Missed-Need-Graduate-School/dp/1009009192/ref=sr_1_4?keywords=math&qid=1652594784&s=books&sr=1-4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
