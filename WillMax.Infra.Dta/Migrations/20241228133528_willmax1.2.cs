using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WillMax.Infra.Dta.Migrations
{
    /// <inheritdoc />
    public partial class willmax12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartamentes_Location_LocationId",
                table: "Apartamentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Location",
                table: "Location");

            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Locations",
                table: "Locations",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartamentes_Locations_LocationId",
                table: "Apartamentes",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartamentes_Locations_LocationId",
                table: "Apartamentes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Locations",
                table: "Locations");

            migrationBuilder.RenameTable(
                name: "Locations",
                newName: "Location");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Location",
                table: "Location",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartamentes_Location_LocationId",
                table: "Apartamentes",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id");
        }
    }
}
