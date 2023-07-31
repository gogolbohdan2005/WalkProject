using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WalkMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Road = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Spots = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Links = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Links", "Name", "Road", "Spots" },
                values: new object[,]
                {
                    { 1, "No links", "Lazeshchyna (Yasinna)", "Using train from Lviv or Ivano-Frankivsk is very conveniet and preferable", "You can get to mountais Kukul, Petros, Drahobrat, it`s waterfall, lake Ivor and waterfall Trufanets, " },
                    { 2, "No links", "Dzembronya", "Using regular (12:00, 15:00 am) bus from Verhovyna, Verhovyna can be reached from Ivano-Frankivsk using bus", "Able to reach awesome mountain Pip Ivan, Dzembronya and it`s waterfall and even second biggest mountain -- Brebenescyl" },
                    { 3, "No links", "Zaroslak", "Using train or bus to Vorohta, then catching taxi or unregular bus to base Zaroslak", "Visit Hoverla, polonuna Pozhyzhevska, lake Nesamovute, mountains Rebra, Hytun-Tomnatyk, Shputzi" },
                    { 4, "No links", "Yaremche", "Using bus from IvanoFrankivsk or train from Frankivsk, Lviv, other cities", "You can visit various waterfalls, old aqueducs, polonynas and small mountain" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Regions");
        }
    }
}
