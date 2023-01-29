using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class featureOtherDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeatureOthers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FeatureOthers",
                columns: table => new
                {
                    FeatureOthersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureOthersDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureOthersImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FeatureOthersStatus = table.Column<bool>(type: "bit", nullable: false),
                    FeatureOthersTitle = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureOthers", x => x.FeatureOthersID);
                });
        }
    }
}
