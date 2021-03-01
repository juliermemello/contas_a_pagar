using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Contas.Repository.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContaPagar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 255, nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, defaultValue: 0m),
                    DataVencimento = table.Column<DateTime>(nullable: false),
                    DataPagamento = table.Column<DateTime>(nullable: false),
                    DiasAtrasado = table.Column<int>(nullable: false, defaultValue: 0),
                    Multa = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, defaultValue: 0m),
                    MultaValor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, defaultValue: 0m),
                    Juros = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, defaultValue: 0m),
                    JurosValor = table.Column<decimal>(type: "decimal(18, 2)", nullable: false, defaultValue: 0m)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContaPagar_Id", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContaPagar");
        }
    }
}
