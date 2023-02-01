using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class destinationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DestinationCoverImage",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationDetails",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationDetails2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationSubImage1",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DestinationSubImage2",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationCoverImage",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationDetails",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationDetails2",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationSubImage1",
                table: "Destinations");

            migrationBuilder.DropColumn(
                name: "DestinationSubImage2",
                table: "Destinations");
        }
    }
}
