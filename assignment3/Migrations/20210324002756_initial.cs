using Microsoft.EntityFrameworkCore.Migrations;

namespace assignment3.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "films",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    category = table.Column<string>(type: "TEXT", nullable: false),
                    title = table.Column<string>(type: "TEXT", nullable: false),
                    year = table.Column<int>(type: "INTEGER", nullable: false),
                    director = table.Column<string>(type: "TEXT", nullable: false),
                    rating = table.Column<string>(type: "TEXT", nullable: false),
                    edited = table.Column<bool>(type: "INTEGER", nullable: false),
                    lent = table.Column<string>(type: "TEXT", nullable: true),
                    notes = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_films", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "films",
                columns: new[] { "id", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { -6, "Action/Adventure", "Joss Whedon", false, "", "Awesome", "PG-13", "The Avengers", 2012 });

            migrationBuilder.InsertData(
                table: "films",
                columns: new[] { "id", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { -5, "Action/Adventure", "Christopher Nolan", false, "", "", "PG-13", "Batman Begins", 2005 });

            migrationBuilder.InsertData(
                table: "films",
                columns: new[] { "id", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { -4, "Comedy", "Tom Shadyac", false, "", "", "PG-13", "Ace Ventura: Pet Detective", 1994 });

            migrationBuilder.InsertData(
                table: "films",
                columns: new[] { "id", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { -3, "Drama", "Frank Darabont", true, "", "", "R", "The Shawshank Redemption", 1994 });

            migrationBuilder.InsertData(
                table: "films",
                columns: new[] { "id", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { -2, "Family", "John Lasseter", false, "Spencer", "the kids LOVED it", "G", "Cars", 2006 });

            migrationBuilder.InsertData(
                table: "films",
                columns: new[] { "id", "category", "director", "edited", "lent", "notes", "rating", "title", "year" },
                values: new object[] { -1, "Horror/Suspense", "Gore Verbinski", false, "", "never again", "PG-13", "The Ring", 2002 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "films");
        }
    }
}
