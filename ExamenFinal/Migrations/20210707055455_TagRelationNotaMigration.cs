using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamenFinal.Migrations
{
    public partial class TagRelationNotaMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddForeignKey(
                name: "FK_NotaTag_Nota_NotaId",
                table: "NotaTag",
                column: "NotaId",
                principalTable: "Nota",
                principalColumn: "NotaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaTag_Nota_NotaId",
                table: "NotaTag");
        }
    }
}
