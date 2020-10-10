using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.Infra.Data.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "conta_a_pagar",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    data_criacao = table.Column<DateTime>(nullable: false),
                    data_atualizacao = table.Column<DateTime>(nullable: false),
                    nome = table.Column<string>(type: "varchar(200)", nullable: false),
                    valor = table.Column<decimal>(type: "decimal(13,2)", nullable: false),
                    data_vencimento = table.Column<DateTime>(type: "datetime", nullable: false),
                    data_pagamento = table.Column<DateTime>(type: "datetime", nullable: false),
                    qtd_dias_atraso = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    multa = table.Column<float>(type: "float", nullable: false, defaultValue: 0f),
                    juro = table.Column<float>(type: "float", nullable: false, defaultValue: 0f)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_conta_a_pagar", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "conta_a_pagar");
        }
    }
}
