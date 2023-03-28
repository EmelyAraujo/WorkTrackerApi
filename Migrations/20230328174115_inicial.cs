using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkTrackerApi.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "materiales",
                columns: table => new
                {
                    ObraId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    DuenoObra = table.Column<string>(type: "TEXT", nullable: true),
                    Fecha = table.Column<DateTime>(type: "TEXT", nullable: true),
                    Descripcion = table.Column<string>(type: "TEXT", nullable: true),
                    Cantidad = table.Column<int>(type: "INTEGER", nullable: false),
                    CantRetirada = table.Column<int>(type: "INTEGER", nullable: false),
                    CantFaltante = table.Column<int>(type: "INTEGER", nullable: false),
                    Suplidor = table.Column<string>(type: "TEXT", nullable: true),
                    PrecioUd = table.Column<double>(type: "REAL", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_materiales", x => x.ObraId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "materiales");
        }
    }
}
