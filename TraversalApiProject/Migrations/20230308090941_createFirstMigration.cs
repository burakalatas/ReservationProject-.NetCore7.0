using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TraversalApiProject.Migrations
{
    /// <inheritdoc />
    public partial class createFirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    VisitorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VisitorMail = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.VisitorID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitors");
        }
    }
}
