using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WillMax.Infra.Dta.Migrations
{
    /// <inheritdoc />
    public partial class willmax15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TypeListingId",
                table: "Apartamentes",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
