using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ApiTest.Migrations
{
    /// <inheritdoc />
    public partial class TablaDetalleVenta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Ventas_VentaId_Ven",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_VentaId_Ven",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "VentaId_Ven",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Pro",
                table: "Productos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<double>(
                name: "Precio",
                table: "Productos",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "DetalleVenta",
                columns: table => new
                {
                    Id_Det = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Id_Ven = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleVenta", x => x.Id_Det);
                    table.ForeignKey(
                        name: "FK_DetalleVenta_Ventas_Id_Ven",
                        column: x => x.Id_Ven,
                        principalTable: "Ventas",
                        principalColumn: "Id_Ven",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DetalleVenta_Id_Ven",
                table: "DetalleVenta",
                column: "Id_Ven");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_DetalleVenta_Id_Pro",
                table: "Productos",
                column: "Id_Pro",
                principalTable: "DetalleVenta",
                principalColumn: "Id_Det",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_DetalleVenta_Id_Pro",
                table: "Productos");

            migrationBuilder.DropTable(
                name: "DetalleVenta");

            migrationBuilder.DropColumn(
                name: "Precio",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "Id_Pro",
                table: "Productos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddColumn<int>(
                name: "VentaId_Ven",
                table: "Productos",
                type: "integer",
                nullable: true);

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
    }
}
