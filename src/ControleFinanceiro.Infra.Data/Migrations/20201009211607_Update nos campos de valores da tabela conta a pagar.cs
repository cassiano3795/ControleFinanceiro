using Microsoft.EntityFrameworkCore.Migrations;

namespace ControleFinanceiro.Infra.Data.Migrations
{
    public partial class Updatenoscamposdevaloresdatabelacontaapagar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "valor_original",
                table: "conta_a_pagar",
                type: "decimal(13,7)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(13,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor_corrigido",
                table: "conta_a_pagar",
                type: "decimal(13,7)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(13,2)",
                oldDefaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "valor_original",
                table: "conta_a_pagar",
                type: "decimal(13,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(13,7)");

            migrationBuilder.AlterColumn<decimal>(
                name: "valor_corrigido",
                table: "conta_a_pagar",
                type: "decimal(13,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(13,7)",
                oldDefaultValue: 0m);
        }
    }
}
