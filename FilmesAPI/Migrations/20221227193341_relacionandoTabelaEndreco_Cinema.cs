using Microsoft.EntityFrameworkCore.Migrations;

namespace FilmesAPI.Migrations
{
    public partial class relacionandoTabelaEndreco_Cinema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnderecoFK",
                table: "Cinema");

            migrationBuilder.DropColumn(
                name: "GerenteFK",
                table: "Cinema");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoId",
                table: "Cinema",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Cinema_EnderecoId",
                table: "Cinema",
                column: "EnderecoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cinema_Endereco_EnderecoId",
                table: "Cinema",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinema_Endereco_EnderecoId",
                table: "Cinema");

            migrationBuilder.DropIndex(
                name: "IX_Cinema_EnderecoId",
                table: "Cinema");

            migrationBuilder.RenameColumn(
                name: "EnderecoId",
                table: "Cinema",
                newName: "GerenteFK");

            migrationBuilder.AddColumn<int>(
                name: "EnderecoFK",
                table: "Cinema",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
