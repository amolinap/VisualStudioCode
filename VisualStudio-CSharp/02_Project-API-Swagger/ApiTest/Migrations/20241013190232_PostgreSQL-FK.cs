using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class PostgreSQLFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_Id_Pro",
                table: "DetalleVenta",
                column: "Id_Pro");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_Id_Ven",
                table: "DetalleVenta",
                column: "Id_Ven");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Productos_Id_Pro",
                table: "DetalleVenta",
                column: "Id_Pro",
                principalTable: "Productos",
                principalColumn: "Id_Pro",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Ventas_Id_Ven",
                table: "DetalleVenta",
                column: "Id_Ven",
                principalTable: "Ventas",
                principalColumn: "Id_Ven",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Productos_Id_Pro",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Ventas_Id_Ven",
                table: "DetalleVenta");

            migrationBuilder.DropIndex(
                name: "IX_DetalleVenta_Id_Pro",
                table: "DetalleVenta");

            migrationBuilder.DropIndex(
                name: "IX_DetalleVenta_Id_Ven",
                table: "DetalleVenta");
        }
    }
}
