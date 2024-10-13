using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class PostgreSQLUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Productos_Id_Pro",
                table: "DetalleVenta");

            migrationBuilder.DropIndex(
                name: "IX_DetalleVenta_Id_Pro",
                table: "DetalleVenta");

            migrationBuilder.DropColumn(
                name: "Id_Pro",
                table: "DetalleVenta");

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
                name: "Id_Pro",
                table: "DetalleVenta",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_Id_Pro",
                table: "DetalleVenta",
                column: "Id_Pro");

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Productos_Id_Pro",
                table: "DetalleVenta",
                column: "Id_Pro",
                principalTable: "Productos",
                principalColumn: "Id_Pro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
