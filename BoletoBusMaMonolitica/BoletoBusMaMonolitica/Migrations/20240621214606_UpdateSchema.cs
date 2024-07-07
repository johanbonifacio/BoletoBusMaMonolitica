using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoletoBusMaMonolitica.Migrations
{
    public partial class UpdateSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Modificar la migración para agregar la columna 'Discriminator' a la tabla 'Ruta'
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Ruta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            // Crear las tablas 'RutaSaveModels' y 'RutaUpdateModels' como estaba originalmente
            migrationBuilder.CreateTable(
                name: "RutaSaveModels",
                columns: table => new
                {
                    IdRuta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeUser = table.Column<int>(type: "int", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutaSaveModels", x => x.IdRuta);
                });

            migrationBuilder.CreateTable(
                name: "RutaUpdateModels",
                columns: table => new
                {
                    IdRuta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeUser = table.Column<int>(type: "int", nullable: false),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutaUpdateModels", x => x.IdRuta);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Eliminar la columna 'Discriminator' de la tabla 'Ruta'
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Ruta");

            // Eliminar las tablas 'RutaSaveModels' y 'RutaUpdateModels' como estaba originalmente
            migrationBuilder.DropTable(
                name: "RutaSaveModels");

            migrationBuilder.DropTable(
                name: "RutaUpdateModels");
        }
    }
}