using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.Infra.Data.Migrations
{
    public partial class Updatenatabeladecontasapagar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valor",
                table: "conta_a_pagar");

            migrationBuilder.AddColumn<decimal>(
                name: "valor_corrigido",
                table: "conta_a_pagar",
                type: "decimal(13,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "valor_original",
                table: "conta_a_pagar",
                type: "decimal(13,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valor_corrigido",
                table: "conta_a_pagar");

            migrationBuilder.DropColumn(
                name: "valor_original",
                table: "conta_a_pagar");

            migrationBuilder.AddColumn<decimal>(
                name: "valor",
                table: "conta_a_pagar",
                type: "decimal(13,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
