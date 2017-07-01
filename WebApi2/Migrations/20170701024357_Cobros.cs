using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApi2.Migrations
{
    public partial class Cobros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cobros",
                columns: table => new
                {
                    IdCobro = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    EsNulo = table.Column<bool>(nullable: false),
                    Fecha = table.Column<DateTime>(nullable: false),
                    IdRemoto = table.Column<int>(nullable: false),
                    IdRuta = table.Column<int>(nullable: false),
                    Latitud = table.Column<decimal>(nullable: false),
                    Longitud = table.Column<decimal>(nullable: false),
                    Monto = table.Column<decimal>(nullable: false),
                    Mora = table.Column<decimal>(nullable: false),
                    Referencia = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cobros", x => x.IdCobro);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cobros");
        }
    }
}
