using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamenFinal.Migrations
{
    public partial class NotaUsuarioModeloMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NotaUsuario",
                columns: table => new
                {
                    NotaId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaUsuario", x => new { x.NotaId, x.UserId });
                    table.ForeignKey(
                        name: "FK_NotaUsuario_Nota_NotaId",
                        column: x => x.NotaId,
                        principalTable: "Nota",
                        principalColumn: "NotaId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaUsuario");
        }
    }
}
