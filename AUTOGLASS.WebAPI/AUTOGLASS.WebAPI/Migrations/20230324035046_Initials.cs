using Microsoft.EntityFrameworkCore.Migrations;

namespace AUTOGLASS.WebAPI.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Situacao_Produto",
                table: "Produtos",
                newName: "SituacaoProduto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SituacaoProduto",
                table: "Produtos",
                newName: "Situacao_Produto");
        }
    }
}
