using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class DetalleVentaUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_DetalleVenta_DetalleVentaId_Det",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_DetalleVentaId_Det",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "DetalleVentaId_Det",
                table: "Productos");

            migrationBuilder.AddColumn<int[]>(
                name: "Productos",
                table: "DetalleVenta",
                type: "integer[]",
                nullable: false,
                defaultValue: new int[0]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Productos",
                table: "DetalleVenta");

            migrationBuilder.AddColumn<int>(
                name: "DetalleVentaId_Det",
                table: "Productos",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_DetalleVentaId_Det",
                table: "Productos",
                column: "DetalleVentaId_Det");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_DetalleVenta_DetalleVentaId_Det",
                table: "Productos",
                column: "DetalleVentaId_Det",
                principalTable: "DetalleVenta",
                principalColumn: "Id_Det");
        }
    }
}
