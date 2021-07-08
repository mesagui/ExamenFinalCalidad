using Microsoft.EntityFrameworkCore.Migrations;

namespace ExamenFinal.Migrations
{
    public partial class TagRelationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_NotaTag_TagId",
                table: "NotaTag",
                column: "TagId");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaTag_Tag_TagId",
                table: "NotaTag",
                column: "TagId",
                principalTable: "Tag",
                principalColumn: "TagId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NotaTag_Tag_TagId",
                table: "NotaTag");

            migrationBuilder.DropIndex(
                name: "IX_NotaTag_TagId",
                table: "NotaTag");
        }
    }
}
