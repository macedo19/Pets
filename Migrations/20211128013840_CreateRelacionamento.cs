using Microsoft.EntityFrameworkCore.Migrations;

namespace EcommerceAPI.Migrations
{
    public partial class CreateRelacionamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HorarioId",
                table: "Servicos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_ClienteId",
                table: "Servicos",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Servicos_HorarioId",
                table: "Servicos",
                column: "HorarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Clientes_ClienteId",
                table: "Servicos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servicos_Horarios_HorarioId",
                table: "Servicos",
                column: "HorarioId",
                principalTable: "Horarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Clientes_ClienteId",
                table: "Servicos");

            migrationBuilder.DropForeignKey(
                name: "FK_Servicos_Horarios_HorarioId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_ClienteId",
                table: "Servicos");

            migrationBuilder.DropIndex(
                name: "IX_Servicos_HorarioId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "Servicos");

            migrationBuilder.DropColumn(
                name: "HorarioId",
                table: "Servicos");
        }
    }
}
