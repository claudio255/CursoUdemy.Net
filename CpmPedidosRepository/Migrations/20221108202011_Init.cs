using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CpmPedidosRepository.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_categoria_produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_categoria_produto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_cidade",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    uf = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cidade", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_imagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    File_Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Main = table.Column<bool>(type: "boolean", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_imagem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Code = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(17,2)", precision: 17, scale: 2, nullable: false),
                    Id_category_product = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_produto_tb_categoria_produto_Id_category_product",
                        column: x => x.Id_category_product,
                        principalTable: "tb_categoria_produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<byte>(type: "smallint", nullable: false),
                    Street = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    District = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    Number = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Complement = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    Cep = table.Column<string>(type: "character varying(8)", maxLength: 8, nullable: false),
                    Id_City = table.Column<int>(type: "integer", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_endereco_tb_cidade_Id_City",
                        column: x => x.Id_City,
                        principalTable: "tb_cidade",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_combo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(17,2)", precision: 17, scale: 2, nullable: false),
                    Id_image = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_combo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_combo_tb_imagem_Id_image",
                        column: x => x.Id_image,
                        principalTable: "tb_imagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_image_product",
                columns: table => new
                {
                    id_image = table.Column<int>(type: "integer", nullable: false),
                    id_product = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_image_product", x => new { x.id_image, x.id_product });
                    table.ForeignKey(
                        name: "FK_tb_image_product_tb_imagem_id_image",
                        column: x => x.id_image,
                        principalTable: "tb_imagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_image_product_tb_produto_id_product",
                        column: x => x.id_product,
                        principalTable: "tb_produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_promocao_produto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(17,2)", precision: 17, scale: 2, nullable: false),
                    Id_image = table.Column<int>(type: "integer", nullable: false),
                    Id_product = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_promocao_produto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_promocao_produto_tb_imagem_Id_image",
                        column: x => x.Id_image,
                        principalTable: "tb_imagem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_promocao_produto_tb_produto_Id_product",
                        column: x => x.Id_product,
                        principalTable: "tb_produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_cliente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Cpf = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    Id_Address = table.Column<int>(type: "integer", nullable: false),
                    Active = table.Column<bool>(type: "boolean", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_cliente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_cliente_tb_endereco_Id_Address",
                        column: x => x.Id_Address,
                        principalTable: "tb_endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_product_combo",
                columns: table => new
                {
                    id_product = table.Column<int>(type: "integer", nullable: false),
                    id_combo = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_product_combo", x => new { x.id_product, x.id_combo });
                    table.ForeignKey(
                        name: "FK_tb_product_combo_tb_combo_id_combo",
                        column: x => x.id_combo,
                        principalTable: "tb_combo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_product_combo_tb_produto_id_product",
                        column: x => x.id_product,
                        principalTable: "tb_produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Number = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Amount = table.Column<decimal>(type: "numeric(17,2)", precision: 17, scale: 2, nullable: false),
                    Delivery = table.Column<TimeSpan>(type: "interval", nullable: false),
                    Id_client = table.Column<int>(type: "integer", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_pedido_tb_cliente_Id_client",
                        column: x => x.Id_client,
                        principalTable: "tb_cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "tb_produto_pedido",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Quantity = table.Column<int>(type: "integer", precision: 2, nullable: false),
                    Price = table.Column<decimal>(type: "numeric(17,2)", precision: 17, scale: 2, nullable: false),
                    Id_product = table.Column<int>(type: "integer", nullable: false),
                    Id_request = table.Column<int>(type: "integer", nullable: false),
                    Created_In = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_produto_pedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tb_produto_pedido_tb_pedido_Id_request",
                        column: x => x.Id_request,
                        principalTable: "tb_pedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_tb_produto_pedido_tb_produto_Id_request",
                        column: x => x.Id_request,
                        principalTable: "tb_produto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tb_cliente_Id_Address",
                table: "tb_cliente",
                column: "Id_Address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_tb_combo_Id_image",
                table: "tb_combo",
                column: "Id_image");

            migrationBuilder.CreateIndex(
                name: "IX_tb_endereco_Id_City",
                table: "tb_endereco",
                column: "Id_City");

            migrationBuilder.CreateIndex(
                name: "IX_tb_image_product_id_product",
                table: "tb_image_product",
                column: "id_product");

            migrationBuilder.CreateIndex(
                name: "IX_tb_pedido_Id_client",
                table: "tb_pedido",
                column: "Id_client");

            migrationBuilder.CreateIndex(
                name: "IX_tb_product_combo_id_combo",
                table: "tb_product_combo",
                column: "id_combo");

            migrationBuilder.CreateIndex(
                name: "IX_tb_produto_Id_category_product",
                table: "tb_produto",
                column: "Id_category_product");

            migrationBuilder.CreateIndex(
                name: "IX_tb_produto_pedido_Id_request",
                table: "tb_produto_pedido",
                column: "Id_request");

            migrationBuilder.CreateIndex(
                name: "IX_tb_promocao_produto_Id_image",
                table: "tb_promocao_produto",
                column: "Id_image");

            migrationBuilder.CreateIndex(
                name: "IX_tb_promocao_produto_Id_product",
                table: "tb_promocao_produto",
                column: "Id_product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_image_product");

            migrationBuilder.DropTable(
                name: "tb_product_combo");

            migrationBuilder.DropTable(
                name: "tb_produto_pedido");

            migrationBuilder.DropTable(
                name: "tb_promocao_produto");

            migrationBuilder.DropTable(
                name: "tb_combo");

            migrationBuilder.DropTable(
                name: "tb_pedido");

            migrationBuilder.DropTable(
                name: "tb_produto");

            migrationBuilder.DropTable(
                name: "tb_imagem");

            migrationBuilder.DropTable(
                name: "tb_cliente");

            migrationBuilder.DropTable(
                name: "tb_categoria_produto");

            migrationBuilder.DropTable(
                name: "tb_endereco");

            migrationBuilder.DropTable(
                name: "tb_cidade");
        }
    }
}
