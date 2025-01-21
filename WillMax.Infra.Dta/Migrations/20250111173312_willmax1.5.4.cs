using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WillMax.Infra.Dta.Migrations
{
    /// <inheritdoc />
    public partial class willmax154 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartamentes_TypeListing_TypeListingId",
                table: "Apartamentes");

            migrationBuilder.AlterColumn<int>(
                name: "TypeListingId",
                table: "Apartamentes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartamentes_TypeListing_TypeListingId",
                table: "Apartamentes",
                column: "TypeListingId",
                principalTable: "TypeListing",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartamentes_TypeListing_TypeListingId",
                table: "Apartamentes");

            migrationBuilder.AlterColumn<int>(
                name: "TypeListingId",
                table: "Apartamentes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Apartamentes_TypeListing_TypeListingId",
                table: "Apartamentes",
                column: "TypeListingId",
                principalTable: "TypeListing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
