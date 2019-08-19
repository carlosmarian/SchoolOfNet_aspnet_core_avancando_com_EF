using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCurso.Migrations
{
    public partial class MudarTabelaProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categorias_categoriaId",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Produtos_Alt");

            migrationBuilder.RenameColumn(
                name: "categoriaId",
                table: "Produtos_Alt",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_categoriaId",
                table: "Produtos_Alt",
                newName: "IX_Produtos_Alt_CategoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos_Alt",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos_Alt",
                table: "Produtos_Alt",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Alt_Categorias_CategoriaId",
                table: "Produtos_Alt",
                column: "CategoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Alt_Categorias_CategoriaId",
                table: "Produtos_Alt");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos_Alt",
                table: "Produtos_Alt");

            migrationBuilder.RenameTable(
                name: "Produtos_Alt",
                newName: "Produtos");

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "Produtos",
                newName: "categoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_Alt_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_categoriaId");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Produtos",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categorias_categoriaId",
                table: "Produtos",
                column: "categoriaId",
                principalTable: "Categorias",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
