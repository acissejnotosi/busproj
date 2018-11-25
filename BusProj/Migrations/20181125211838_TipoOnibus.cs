using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BusCore.Migrations
{
    public partial class TipoOnibus : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalRPNFabrica",
                table: "Linha",
                newName: "TotalRPNSuspensaoFabrica");

            migrationBuilder.RenameColumn(
                name: "RPNCalculado",
                table: "Linha",
                newName: "TotalRPNFreiosFabrica");

            migrationBuilder.RenameColumn(
                name: "Peso",
                table: "Linha",
                newName: "TotalRPNEmbreagemFabrica");

            migrationBuilder.RenameColumn(
                name: "NumSemnaforo",
                table: "Linha",
                newName: "TipoOnibusId");

            migrationBuilder.RenameColumn(
                name: "NumLomnbadas",
                table: "Linha",
                newName: "NumSemaforo");

            migrationBuilder.AddColumn<int>(
                name: "NumLombadas",
                table: "Linha",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<double>(
                name: "TotalKmEmbreagemFabrica",
                table: "Linha",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalKmFreiosFabrica",
                table: "Linha",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalKmSuspensaoFabrica",
                table: "Linha",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "TipoOnibus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Descricao = table.Column<string>(nullable: true),
                    Peso = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOnibus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Linha_TipoOnibusId",
                table: "Linha",
                column: "TipoOnibusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Linha_TipoOnibus_TipoOnibusId",
                table: "Linha",
                column: "TipoOnibusId",
                principalTable: "TipoOnibus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Linha_TipoOnibus_TipoOnibusId",
                table: "Linha");

            migrationBuilder.DropTable(
                name: "TipoOnibus");

            migrationBuilder.DropIndex(
                name: "IX_Linha_TipoOnibusId",
                table: "Linha");

            migrationBuilder.DropColumn(
                name: "NumLombadas",
                table: "Linha");

            migrationBuilder.DropColumn(
                name: "TotalKmEmbreagemFabrica",
                table: "Linha");

            migrationBuilder.DropColumn(
                name: "TotalKmFreiosFabrica",
                table: "Linha");

            migrationBuilder.DropColumn(
                name: "TotalKmSuspensaoFabrica",
                table: "Linha");

            migrationBuilder.RenameColumn(
                name: "TotalRPNSuspensaoFabrica",
                table: "Linha",
                newName: "TotalRPNFabrica");

            migrationBuilder.RenameColumn(
                name: "TotalRPNFreiosFabrica",
                table: "Linha",
                newName: "RPNCalculado");

            migrationBuilder.RenameColumn(
                name: "TotalRPNEmbreagemFabrica",
                table: "Linha",
                newName: "Peso");

            migrationBuilder.RenameColumn(
                name: "TipoOnibusId",
                table: "Linha",
                newName: "NumSemnaforo");

            migrationBuilder.RenameColumn(
                name: "NumSemaforo",
                table: "Linha",
                newName: "NumLomnbadas");
        }
    }
}
