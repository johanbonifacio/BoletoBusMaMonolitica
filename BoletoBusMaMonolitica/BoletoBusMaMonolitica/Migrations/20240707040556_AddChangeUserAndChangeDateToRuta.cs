using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BoletoBusMaMonolitica.Migrations
{
    public partial class AddChangeUserAndChangeDateToRuta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RutaSaveModels");

            migrationBuilder.DropTable(
                name: "RutaUpdateModels");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Ruta");

            migrationBuilder.AddColumn<DateTime>(
                name: "ChangeDate",
                table: "Ruta",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ChangeUser",
                table: "Ruta",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ChangeDate",
                table: "Ruta");

            migrationBuilder.DropColumn(
                name: "ChangeUser",
                table: "Ruta");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Ruta",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "RutaSaveModels",
                columns: table => new
                {
                    IdRuta = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangeUser = table.Column<int>(type: "int", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false)
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
                    ChangeDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChangeUser = table.Column<int>(type: "int", nullable: false),
                    Destino = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origen = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RutaUpdateModels", x => x.IdRuta);
                });
        }
    }
}
