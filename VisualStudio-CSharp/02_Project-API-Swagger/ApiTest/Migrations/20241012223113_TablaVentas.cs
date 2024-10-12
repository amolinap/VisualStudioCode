using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class TablaVentas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VentaId_Ven",
                table: "Productos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Ventas",
                columns: table => new
                {
                    Id_Ven = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Total = table.Column<double>(type: "double precision", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ventas", x => x.Id_Ven);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Productos_VentaId_Ven",
                table: "Productos",
                column: "VentaId_Ven");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Ventas_VentaId_Ven",
                table: "Productos",
                column: "VentaId_Ven",
                principalTable: "Ventas",
                principalColumn: "Id_Ven");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ventas_VentaId_Ven",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "Ventas");

            migrationBuilder.DropIndex(
                name: "IX_Productos_VentaId_Ven",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "VentaId_Ven",
                table: "Productos");
        }
    }
}
