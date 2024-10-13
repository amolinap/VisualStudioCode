using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class DetalleVentaRemove_FK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Ventas_Id_Ven",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_DetalleVenta_Id_Pro",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "Id_Ven",
                table: "DetalleVenta",
                newName: "VentaId_Ven");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_Id_Ven",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_VentaId_Ven");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Pro",
                table: "Productos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
                name: "FK_DetalleVenta_Ventas_VentaId_Ven",
                table: "DetalleVenta",
                column: "VentaId_Ven",
                principalTable: "Ventas",
                principalColumn: "Id_Ven",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_DetalleVenta_DetalleVentaId_Det",
                table: "Productos",
                column: "DetalleVentaId_Det",
                principalTable: "DetalleVenta",
                principalColumn: "Id_Det");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetalleVenta_Ventas_VentaId_Ven",
                table: "DetalleVenta");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_DetalleVenta_DetalleVentaId_Det",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_DetalleVentaId_Det",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "DetalleVentaId_Det",
                table: "Productos");

            migrationBuilder.RenameColumn(
                name: "VentaId_Ven",
                table: "DetalleVenta",
                newName: "Id_Ven");

            migrationBuilder.RenameIndex(
                name: "IX_DetalleVenta_VentaId_Ven",
                table: "DetalleVenta",
                newName: "IX_DetalleVenta_Id_Ven");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Pro",
                table: "Productos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_DetalleVenta_Ventas_Id_Ven",
                table: "DetalleVenta",
                column: "Id_Ven",
                principalTable: "Ventas",
                principalColumn: "Id_Ven",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_DetalleVenta_Id_Pro",
                table: "Productos",
                column: "Id_Pro",
                principalTable: "DetalleVenta",
                principalColumn: "Id_Det",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
