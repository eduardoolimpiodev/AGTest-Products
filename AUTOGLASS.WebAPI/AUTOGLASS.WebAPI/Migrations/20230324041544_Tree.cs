using Microsoft.EntityFrameworkCore.Migrations;

namespace AUTOGLASS.WebAPI.Migrations
{
    public partial class Tree : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedoresId",
                table: "Produtos");

            migrationBuilder.DropIndex(
                name: "IX_Produtos_FornecedoresId",
                table: "Produtos");

            migrationBuilder.DropColumn(
                name: "FornecedoresId",
                table: "Produtos");

            migrationBuilder.AddColumn<int>(
                name: "ProdutoId",
                table: "Fornecedores",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedores_ProdutoId",
                table: "Fornecedores",
                column: "ProdutoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fornecedores_Produtos_ProdutoId",
                table: "Fornecedores",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fornecedores_Produtos_ProdutoId",
                table: "Fornecedores");

            migrationBuilder.DropIndex(
                name: "IX_Fornecedores_ProdutoId",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "ProdutoId",
                table: "Fornecedores");

            migrationBuilder.AddColumn<int>(
                name: "FornecedoresId",
                table: "Produtos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_FornecedoresId",
                table: "Produtos",
                column: "FornecedoresId");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Fornecedores_FornecedoresId",
                table: "Produtos",
                column: "FornecedoresId",
                principalTable: "Fornecedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
