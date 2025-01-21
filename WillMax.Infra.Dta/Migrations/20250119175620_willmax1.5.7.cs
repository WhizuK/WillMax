using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WillMax.Infra.Dta.Migrations
{
    /// <inheritdoc />
    public partial class willmax157 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apartamentes_Stats_StatsId",
                table: "Apartamentes");

            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.DropIndex(
                name: "IX_Apartamentes_StatsId",
                table: "Apartamentes");

            migrationBuilder.DropColumn(
                name: "StatsId",
                table: "Apartamentes");

            migrationBuilder.AddColumn<string>(
                name: "Stats",
                table: "Apartamentes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stats",
                table: "Apartamentes");

            migrationBuilder.AddColumn<int>(
                name: "StatsId",
                table: "Apartamentes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apartamentes_StatsId",
                table: "Apartamentes",
                column: "StatsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apartamentes_Stats_StatsId",
                table: "Apartamentes",
                column: "StatsId",
                principalTable: "Stats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
