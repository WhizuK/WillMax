using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WillMax.Infra.Dta.Migrations
{
    /// <inheritdoc />
    public partial class willmax155 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartamentes_TypeListing_TypeListingId",
                table: "Apartamentes");

            migrationBuilder.DropTable(
                name: "TypeListing");

            migrationBuilder.DropIndex(
                name: "IX_Apartamentes_TypeListingId",
                table: "Apartamentes");

            migrationBuilder.DropColumn(
                name: "TypeListingId",
                table: "Apartamentes");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Apartamentes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Apartamentes");

            migrationBuilder.AddColumn<int>(
                name: "TypeListingId",
                table: "Apartamentes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeListing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeListing", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartamentes_TypeListingId",
                table: "Apartamentes",
                column: "TypeListingId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartamentes_TypeListing_TypeListingId",
                table: "Apartamentes",
                column: "TypeListingId",
                principalTable: "TypeListing",
                principalColumn: "Id");
        }
    }
}
