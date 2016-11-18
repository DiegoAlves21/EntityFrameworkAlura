using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using lojaComEntity;

namespace lojaComEntity.Migrations
{
    [DbContext(typeof(EntidadesContext))]
    partial class EntidadesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("lojaComEntity.Entidades.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entidades.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoriaID");

                    b.Property<string>("Nome");

                    b.Property<decimal>("Preco");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entidades.ProdutoVenda", b =>
                {
                    b.Property<int>("VendaId");

                    b.Property<int>("ProdutoId");

                    b.HasKey("VendaId", "ProdutoId");
                });

            modelBuilder.Entity("lojaComEntity.Entidades.Usuario", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nome");

                    b.Property<string>("Senha");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entidades.Venda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("UsuarioID");

                    b.HasKey("ID");
                });

            modelBuilder.Entity("lojaComEntity.Entidades.Produto", b =>
                {
                    b.HasOne("lojaComEntity.Entidades.Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaID");
                });

            modelBuilder.Entity("lojaComEntity.Entidades.ProdutoVenda", b =>
                {
                    b.HasOne("lojaComEntity.Entidades.Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoId");

                    b.HasOne("lojaComEntity.Entidades.Venda")
                        .WithMany()
                        .HasForeignKey("VendaId");
                });

            modelBuilder.Entity("lojaComEntity.Entidades.Venda", b =>
                {
                    b.HasOne("lojaComEntity.Entidades.Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID");
                });
        }
    }
}
