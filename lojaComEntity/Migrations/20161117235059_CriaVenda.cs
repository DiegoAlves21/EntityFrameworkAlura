using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Metadata;

namespace lojaComEntity.Migrations
{
    public partial class CriaVenda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaID", table: "Produto");
            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UsuarioID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Venda", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Venda_Usuario_UsuarioID",
                        column: x => x.UsuarioID,
                        principalTable: "Usuario",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.CreateTable(
                name: "ProdutoVenda",
                columns: table => new
                {
                    VendaId = table.Column<int>(nullable: false),
                    ProdutoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProdutoVenda", x => new { x.VendaId, x.ProdutoId });
                    table.ForeignKey(
                        name: "FK_ProdutoVenda_Produto_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produto",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProdutoVenda_Venda_VendaId",
                        column: x => x.VendaId,
                        principalTable: "Venda",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaID",
                table: "Produto",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Produto_Categoria_CategoriaID", table: "Produto");
            migrationBuilder.DropTable("ProdutoVenda");
            migrationBuilder.DropTable("Venda");
            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaID",
                table: "Produto",
                column: "CategoriaID",
                principalTable: "Categoria",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
