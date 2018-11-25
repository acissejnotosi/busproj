using Microsoft.EntityFrameworkCore.Migrations;

namespace BusCore.Migrations
{
    public partial class NovosRPNs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RPNBuraco",
                table: "Suspensao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNCarga",
                table: "Suspensao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNKmFabrica",
                table: "Suspensao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNRedutor",
                table: "Suspensao",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNPontosParada",
                table: "Freio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNRedutores",
                table: "Freio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNSemaforo",
                table: "Freio",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNParada",
                table: "Embreagem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNRedutores",
                table: "Embreagem",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RPNSemaforo",
                table: "Embreagem",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RPNBuraco",
                table: "Suspensao");

            migrationBuilder.DropColumn(
                name: "RPNCarga",
                table: "Suspensao");

            migrationBuilder.DropColumn(
                name: "RPNKmFabrica",
                table: "Suspensao");

            migrationBuilder.DropColumn(
                name: "RPNRedutor",
                table: "Suspensao");

            migrationBuilder.DropColumn(
                name: "RPNPontosParada",
                table: "Freio");

            migrationBuilder.DropColumn(
                name: "RPNRedutores",
                table: "Freio");

            migrationBuilder.DropColumn(
                name: "RPNSemaforo",
                table: "Freio");

            migrationBuilder.DropColumn(
                name: "RPNParada",
                table: "Embreagem");

            migrationBuilder.DropColumn(
                name: "RPNRedutores",
                table: "Embreagem");

            migrationBuilder.DropColumn(
                name: "RPNSemaforo",
                table: "Embreagem");
        }
    }
}
